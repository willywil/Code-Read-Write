using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace Code_Read_Write
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Discovers all capture devices and adds to the Combo box
                CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo Device in CaptureDevice)
                {

                    CamCombo.Items.Add(Device.Name); //Adds to Combobox

                    

                }
                //if (CamCombo.Items.Count != 0)
                //{
                    CamCombo.SelectedIndex = 0;
                //}
                //else if (CamCombo.SelectedIndex == -1)
                //{
                    
                //}
            } catch
              {
                CamCombo.Items.Add("No camera devices available!");
                CamCombo.SelectedIndex = 0;
              }
           
            FinalFrame = new VideoCaptureDevice();
            /*
            string[] type = new string[20] {"AZTEC", "CODABAR", "CODE_39", "CODE_93", "CODE_128", "DATA_MATRIX", "EAN_8", "EAN_13", "ITF", "MAXICODE", "PDF_417", "QR_CODE", "RSS_14", "RSS_EXPANDED", "UPC_A", "UPC_E", "ALL_1D", "UPC_EAN_EXTENSION", "MSI", "PLESSEY" };
            for (int i = 0; i < 20; i++)
            {
                CodeCombo.Items.Add(type[i]);
            }
             */
            string[] type = new string[2] { "CODE_128", "QR_CODE"};
            for (int i = 0; i < 2; i++)
            {
                CodeCombo.Items.Add(type[i]);
            }
            
        }
        
        
        private void EnBtn_Click(object sender, EventArgs e) // Button to Encode value in text field. Need to add SQL database fuctionality.
        {
            pictureBox1.Image = null;
            FinalFrame.Stop();
            timer1.Enabled = false; //Need to update once timer function is removed
            if (EncodeINput.Text == "")
            {
                EncodeINput.Text = "Enter value to encode";
            }
            else
            {
                int x = Convert.ToInt32(xSize.Value);
                int y = Convert.ToInt32(ySize.Value);
                String code = EncodeINput.Text;
                try
                {
                    switch (CodeCombo.Text)
                    {
                        case "CODE_128":
                            //Default for 10 inch scan distance and 1IN x 1IN code size 1 in = 96 
                            IBarcodeWriter enco = new BarcodeWriter { Format = BarcodeFormat.CODE_128 }; // Variable to change the format
                            Bitmap qrpic;
                            var result = enco.Write(code);
                            qrpic = new Bitmap(result);
                            qrpic = resizeImage(qrpic, new Size(x, y)); //Variable to change the size
                            pictureBox1.Image = qrpic as Image;
                            break;
                        case "QR_CODE":
                            IBarcodeWriter enco1 = new BarcodeWriter { Format = BarcodeFormat.QR_CODE }; // Variable to change the format
                            Bitmap qrpica;
                            var result1 = enco1.Write(code);
                            qrpica = new Bitmap(result1);
                            qrpica = resizeImage(qrpica, new Size(x, y)); //Variable to change the size
                            pictureBox1.Image = qrpica as Image;
                            break;
                        //Need to add Default!!!!!!!!!!!!
                    }
                }
                catch (Exception ex)
                {
                    EncodeINput.Text = "Enter value to encode";
                }
            }
        }

        private Bitmap resizeImage(Bitmap qrpic, System.Drawing.Size size)
        {
            return (Bitmap)(new Bitmap(qrpic, size));
        }

        private void BrBtn_Click(object sender, EventArgs e) //Button to Browse for file to decode
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = o.FileName;
                SaveCombo.Items.Add(o.FileName);
                SaveCombo.Text = o.FileName;
            }
        }

        private void DeBtn_Click(object sender, EventArgs e)
        {
            
            
            
            //Remove timer and turn into a function that can be called by a thread and create the thread here
            //
            
            
            
            if (pictureBox1.Image != null)
            {
                timer1.Enabled = true;
            }
        }

        private void StBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevice[CamCombo.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                pictureBox1.Visible = true;
                FinalFrame.Start();
                timer1.Enabled = false;
                
                
                //Stop the decode thread here




            } catch
            {
                MessageBox.Show("Please select a camera device!");
            }
            
            
        }

        private void SaBtn_Click(object sender, EventArgs e) //Button to save image in pic box. Can I validate if pic is a code first
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image.Save(s.FileName);
                }
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e) //private void picDecode()
        {
            
                //Every interval time this function is called
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                int x = 0;
                try
                {
                    string decoded = result.ToString().Trim(); //This can also be a SQL query
                    TxtOut.Text = decoded;
                    if (TxtOut.CausesValidation) //??????
                    {
                        
                    }
                }
                catch (Exception ex) //I need to handle this better
                {
                    TxtOut.Text = "Code can not be read";
                    x++;
                    if (x == 10)
                    {
                        x = 0;
                        pictureBox1.Visible = false;
                        FinalFrame.Stop();
                        timer1.Enabled = false;

                    }
                }
        }

        private void CamStop_Click(object sender, EventArgs e) //Button to stop the camera process
        {
            pictureBox1.Image = null;
            FinalFrame.Stop();
            timer1.Enabled = false;
        }

        private void EncodeINput_GotFocus(object sender, EventArgs e)
        {
            EncodeINput.Clear();
        }

    }
}
