namespace Code_Read_Write
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.CamCombo = new System.Windows.Forms.ComboBox();
            this.EncodeINput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveCombo = new System.Windows.Forms.ComboBox();
            this.BrBtn = new System.Windows.Forms.Button();
            this.SaBtn = new System.Windows.Forms.Button();
            this.CodeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StBtn = new System.Windows.Forms.Button();
            this.DeBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CamStop = new System.Windows.Forms.Button();
            this.xSize = new System.Windows.Forms.NumericUpDown();
            this.ySize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EnBtn
            // 
            this.EnBtn.Location = new System.Drawing.Point(318, 40);
            this.EnBtn.Name = "EnBtn";
            this.EnBtn.Size = new System.Drawing.Size(75, 23);
            this.EnBtn.TabIndex = 1;
            this.EnBtn.Text = "Encode";
            this.EnBtn.UseVisualStyleBackColor = true;
            this.EnBtn.Click += new System.EventHandler(this.EnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Camera";
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(318, 188);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(322, 126);
            this.TxtOut.TabIndex = 3;
            this.TxtOut.Text = "Decoded Value";
            // 
            // CamCombo
            // 
            this.CamCombo.FormattingEnabled = true;
            this.CamCombo.Location = new System.Drawing.Point(418, 9);
            this.CamCombo.Name = "CamCombo";
            this.CamCombo.Size = new System.Drawing.Size(222, 21);
            this.CamCombo.TabIndex = 4;
            // 
            // EncodeINput
            // 
            this.EncodeINput.Location = new System.Drawing.Point(399, 40);
            this.EncodeINput.Multiline = true;
            this.EncodeINput.Name = "EncodeINput";
            this.EncodeINput.Size = new System.Drawing.Size(241, 23);
            this.EncodeINput.TabIndex = 5;
            this.EncodeINput.Text = "Enter value to encode";
            this.EncodeINput.GotFocus += new System.EventHandler(this.EncodeINput_GotFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size";
            // 
            // SaveCombo
            // 
            this.SaveCombo.FormattingEnabled = true;
            this.SaveCombo.Location = new System.Drawing.Point(317, 130);
            this.SaveCombo.Name = "SaveCombo";
            this.SaveCombo.Size = new System.Drawing.Size(241, 21);
            this.SaveCombo.TabIndex = 9;
            this.SaveCombo.Text = "Select Browse to Decode an Image";
            // 
            // BrBtn
            // 
            this.BrBtn.Location = new System.Drawing.Point(565, 130);
            this.BrBtn.Name = "BrBtn";
            this.BrBtn.Size = new System.Drawing.Size(75, 23);
            this.BrBtn.TabIndex = 10;
            this.BrBtn.Text = "Browse";
            this.BrBtn.UseVisualStyleBackColor = true;
            this.BrBtn.Click += new System.EventHandler(this.BrBtn_Click);
            // 
            // SaBtn
            // 
            this.SaBtn.Location = new System.Drawing.Point(318, 159);
            this.SaBtn.Name = "SaBtn";
            this.SaBtn.Size = new System.Drawing.Size(75, 23);
            this.SaBtn.TabIndex = 11;
            this.SaBtn.Text = "Save Code";
            this.SaBtn.UseVisualStyleBackColor = true;
            this.SaBtn.Click += new System.EventHandler(this.SaBtn_Click);
            // 
            // CodeCombo
            // 
            this.CodeCombo.FormattingEnabled = true;
            this.CodeCombo.Location = new System.Drawing.Point(399, 98);
            this.CodeCombo.Name = "CodeCombo";
            this.CodeCombo.Size = new System.Drawing.Size(241, 21);
            this.CodeCombo.TabIndex = 12;
            this.CodeCombo.Text = "Select Code Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Code Type";
            // 
            // StBtn
            // 
            this.StBtn.Location = new System.Drawing.Point(399, 159);
            this.StBtn.Name = "StBtn";
            this.StBtn.Size = new System.Drawing.Size(77, 23);
            this.StBtn.TabIndex = 14;
            this.StBtn.Text = "Start Camera";
            this.StBtn.UseVisualStyleBackColor = true;
            this.StBtn.Click += new System.EventHandler(this.StBtn_Click);
            // 
            // DeBtn
            // 
            this.DeBtn.Location = new System.Drawing.Point(565, 159);
            this.DeBtn.Name = "DeBtn";
            this.DeBtn.Size = new System.Drawing.Size(75, 23);
            this.DeBtn.TabIndex = 15;
            this.DeBtn.Text = "Decode";
            this.DeBtn.UseVisualStyleBackColor = true;
            this.DeBtn.Click += new System.EventHandler(this.DeBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CamStop
            // 
            this.CamStop.Location = new System.Drawing.Point(482, 159);
            this.CamStop.Name = "CamStop";
            this.CamStop.Size = new System.Drawing.Size(77, 23);
            this.CamStop.TabIndex = 16;
            this.CamStop.Text = "Stop Camera";
            this.CamStop.UseVisualStyleBackColor = true;
            this.CamStop.Click += new System.EventHandler(this.CamStop_Click);
            // 
            // xSize
            // 
            this.xSize.Location = new System.Drawing.Point(364, 72);
            this.xSize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.xSize.Name = "xSize";
            this.xSize.Size = new System.Drawing.Size(130, 20);
            this.xSize.TabIndex = 17;
            this.xSize.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // ySize
            // 
            this.ySize.Location = new System.Drawing.Point(510, 72);
            this.ySize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ySize.Name = "ySize";
            this.ySize.Size = new System.Drawing.Size(130, 20);
            this.ySize.TabIndex = 18;
            this.ySize.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 320);
            this.Controls.Add(this.ySize);
            this.Controls.Add(this.xSize);
            this.Controls.Add(this.CamStop);
            this.Controls.Add(this.DeBtn);
            this.Controls.Add(this.StBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodeCombo);
            this.Controls.Add(this.SaBtn);
            this.Controls.Add(this.BrBtn);
            this.Controls.Add(this.SaveCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EncodeINput);
            this.Controls.Add(this.CamCombo);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Code Read Write";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.ComboBox CamCombo;
        private System.Windows.Forms.TextBox EncodeINput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SaveCombo;
        private System.Windows.Forms.Button BrBtn;
        private System.Windows.Forms.Button SaBtn;
        private System.Windows.Forms.ComboBox CodeCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StBtn;
        private System.Windows.Forms.Button DeBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CamStop;
        private System.Windows.Forms.NumericUpDown xSize;
        private System.Windows.Forms.NumericUpDown ySize;
    }
}

