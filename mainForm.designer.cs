namespace TeleserviceTools
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTFTP = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtDevicename = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtIPEIwithChkSum = new System.Windows.Forms.TextBox();
            this.lblIPEIchecksum = new System.Windows.Forms.Label();
            this.btnIPEI = new System.Windows.Forms.Button();
            this.txtIPEI = new System.Windows.Forms.TextBox();
            this.lblIPEI = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aboutText = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtTFTP);
            this.tabPage1.Controls.Add(this.btnDecode);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.txtDevicename);
            this.tabPage1.Controls.Add(this.txtExtension);
            this.tabPage1.Controls.Add(this.lblDeviceName);
            this.tabPage1.Controls.Add(this.lblExtension);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cisco IP Communicator DeviceName Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtTFTP
            // 
            this.txtTFTP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTFTP.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTFTP.Location = new System.Drawing.Point(8, 74);
            this.txtTFTP.Multiline = true;
            this.txtTFTP.Name = "txtTFTP";
            this.txtTFTP.ReadOnly = true;
            this.txtTFTP.Size = new System.Drawing.Size(690, 116);
            this.txtTFTP.TabIndex = 14;
            // 
            // btnDecode
            // 
            this.btnDecode.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(538, 38);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(160, 30);
            this.btnDecode.TabIndex = 13;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(539, 6);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(159, 30);
            this.btnEncode.TabIndex = 12;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // txtDevicename
            // 
            this.txtDevicename.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevicename.Location = new System.Drawing.Point(283, 39);
            this.txtDevicename.MaxLength = 15;
            this.txtDevicename.Name = "txtDevicename";
            this.txtDevicename.Size = new System.Drawing.Size(249, 31);
            this.txtDevicename.TabIndex = 11;
            this.txtDevicename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevicename_KeyPress);
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(283, 6);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(249, 31);
            this.txtExtension.TabIndex = 10;
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtension_KeyPress);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(85, 42);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(142, 23);
            this.lblDeviceName.TabIndex = 9;
            this.lblDeviceName.Text = "Device name:";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(85, 9);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(192, 23);
            this.lblExtension.TabIndex = 8;
            this.lblExtension.Text = "Extension number:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.txtIPEIwithChkSum);
            this.tabPage2.Controls.Add(this.lblIPEIchecksum);
            this.tabPage2.Controls.Add(this.btnIPEI);
            this.tabPage2.Controls.Add(this.txtIPEI);
            this.tabPage2.Controls.Add(this.lblIPEI);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IPEI Checksum Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtIPEIwithChkSum
            // 
            this.txtIPEIwithChkSum.BackColor = System.Drawing.SystemColors.Window;
            this.txtIPEIwithChkSum.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txtIPEIwithChkSum.Location = new System.Drawing.Point(307, 36);
            this.txtIPEIwithChkSum.MaxLength = 13;
            this.txtIPEIwithChkSum.Name = "txtIPEIwithChkSum";
            this.txtIPEIwithChkSum.ReadOnly = true;
            this.txtIPEIwithChkSum.Size = new System.Drawing.Size(161, 31);
            this.txtIPEIwithChkSum.TabIndex = 4;
            // 
            // lblIPEIchecksum
            // 
            this.lblIPEIchecksum.AutoSize = true;
            this.lblIPEIchecksum.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblIPEIchecksum.Location = new System.Drawing.Point(91, 39);
            this.lblIPEIchecksum.Name = "lblIPEIchecksum";
            this.lblIPEIchecksum.Size = new System.Drawing.Size(214, 23);
            this.lblIPEIchecksum.TabIndex = 3;
            this.lblIPEIchecksum.Text = "IPEI with checksum: ";
            // 
            // btnIPEI
            // 
            this.btnIPEI.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btnIPEI.Location = new System.Drawing.Point(474, 6);
            this.btnIPEI.Name = "btnIPEI";
            this.btnIPEI.Size = new System.Drawing.Size(223, 30);
            this.btnIPEI.TabIndex = 2;
            this.btnIPEI.Text = "Calculate Checksum";
            this.btnIPEI.UseVisualStyleBackColor = true;
            this.btnIPEI.Click += new System.EventHandler(this.btnIPEI_Click);
            // 
            // txtIPEI
            // 
            this.txtIPEI.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txtIPEI.Location = new System.Drawing.Point(307, 5);
            this.txtIPEI.MaxLength = 12;
            this.txtIPEI.Name = "txtIPEI";
            this.txtIPEI.Size = new System.Drawing.Size(161, 31);
            this.txtIPEI.TabIndex = 1;
            this.txtIPEI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPEI_KeyPress);
            // 
            // lblIPEI
            // 
            this.lblIPEI.AutoSize = true;
            this.lblIPEI.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblIPEI.Location = new System.Drawing.Point(91, 8);
            this.lblIPEI.Name = "lblIPEI";
            this.lblIPEI.Size = new System.Drawing.Size(210, 23);
            this.lblIPEI.TabIndex = 0;
            this.lblIPEI.Text = "IPEI w/o checksum: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.aboutText);
            this.tabPage3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(712, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // aboutText
            // 
            this.aboutText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutText.Location = new System.Drawing.Point(6, 6);
            this.aboutText.Multiline = true;
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(302, 182);
            this.aboutText.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(416, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 182);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 227);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Teleservice Tools";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTFTP;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtDevicename;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtIPEI;
        private System.Windows.Forms.Label lblIPEI;
        private System.Windows.Forms.Button btnIPEI;
        private System.Windows.Forms.Label lblIPEIchecksum;
        private System.Windows.Forms.TextBox txtIPEIwithChkSum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox aboutText;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}

