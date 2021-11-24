
namespace Laba5
{
    partial class Opus
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_AES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Rijndael = new System.Windows.Forms.LinkLabel();
            this.linkLabel_RC2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_TriplDES = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laba5.Properties.Resources.sharp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Програма використовує симетричні алгоритми  ";
            // 
            // linkLabel_AES
            // 
            this.linkLabel_AES.AutoSize = true;
            this.linkLabel_AES.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_AES.Location = new System.Drawing.Point(234, 142);
            this.linkLabel_AES.Name = "linkLabel_AES";
            this.linkLabel_AES.Size = new System.Drawing.Size(54, 26);
            this.linkLabel_AES.TabIndex = 2;
            this.linkLabel_AES.TabStop = true;
            this.linkLabel_AES.Text = "AES";
            this.linkLabel_AES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AES_LinkClicked);
            // 
            // linkLabel_Rijndael
            // 
            this.linkLabel_Rijndael.AutoSize = true;
            this.linkLabel_Rijndael.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_Rijndael.Location = new System.Drawing.Point(234, 179);
            this.linkLabel_Rijndael.Name = "linkLabel_Rijndael";
            this.linkLabel_Rijndael.Size = new System.Drawing.Size(89, 26);
            this.linkLabel_Rijndael.TabIndex = 3;
            this.linkLabel_Rijndael.TabStop = true;
            this.linkLabel_Rijndael.Text = "Rijndael";
            this.linkLabel_Rijndael.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Rijndael_LinkClicked);
            // 
            // linkLabel_RC2
            // 
            this.linkLabel_RC2.AutoSize = true;
            this.linkLabel_RC2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_RC2.Location = new System.Drawing.Point(234, 217);
            this.linkLabel_RC2.Name = "linkLabel_RC2";
            this.linkLabel_RC2.Size = new System.Drawing.Size(53, 26);
            this.linkLabel_RC2.TabIndex = 4;
            this.linkLabel_RC2.TabStop = true;
            this.linkLabel_RC2.Text = "RC2";
            this.linkLabel_RC2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_RC2_LinkClicked);
            // 
            // linkLabel_DES
            // 
            this.linkLabel_DES.AutoSize = true;
            this.linkLabel_DES.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_DES.Location = new System.Drawing.Point(234, 257);
            this.linkLabel_DES.Name = "linkLabel_DES";
            this.linkLabel_DES.Size = new System.Drawing.Size(54, 26);
            this.linkLabel_DES.TabIndex = 5;
            this.linkLabel_DES.TabStop = true;
            this.linkLabel_DES.Text = "DES";
            this.linkLabel_DES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DES_LinkClicked);
            // 
            // linkLabel_TriplDES
            // 
            this.linkLabel_TriplDES.AutoSize = true;
            this.linkLabel_TriplDES.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_TriplDES.Location = new System.Drawing.Point(234, 291);
            this.linkLabel_TriplDES.Name = "linkLabel_TriplDES";
            this.linkLabel_TriplDES.Size = new System.Drawing.Size(101, 26);
            this.linkLabel_TriplDES.TabIndex = 6;
            this.linkLabel_TriplDES.TabStop = true;
            this.linkLabel_TriplDES.Text = "TripIDES";
            this.linkLabel_TriplDES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TriplDES_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "шифрування, які містяться в .NET Framework";
            // 
            // Opus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel_TriplDES);
            this.Controls.Add(this.linkLabel_DES);
            this.Controls.Add(this.linkLabel_RC2);
            this.Controls.Add(this.linkLabel_Rijndael);
            this.Controls.Add(this.linkLabel_AES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(585, 415);
            this.MinimumSize = new System.Drawing.Size(585, 415);
            this.Name = "Opus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_AES;
        private System.Windows.Forms.LinkLabel linkLabel_Rijndael;
        private System.Windows.Forms.LinkLabel linkLabel_RC2;
        private System.Windows.Forms.LinkLabel linkLabel_DES;
        private System.Windows.Forms.LinkLabel linkLabel_TriplDES;
        private System.Windows.Forms.Label label2;
    }
}