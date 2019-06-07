namespace Bai_TH_Lab_04
{
    partial class Lab04_Bai_02
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.rtbview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(482, 26);
            this.txtURL.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(12, 59);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(482, 26);
            this.txtPath.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(514, 27);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(133, 33);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // rtbview
            // 
            this.rtbview.Location = new System.Drawing.Point(12, 91);
            this.rtbview.Name = "rtbview";
            this.rtbview.ReadOnly = true;
            this.rtbview.Size = new System.Drawing.Size(635, 334);
            this.rtbview.TabIndex = 3;
            this.rtbview.Text = "";
            // 
            // Lab04_Bai_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 437);
            this.Controls.Add(this.rtbview);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtURL);
            this.Name = "Lab04_Bai_02";
            this.Text = "Lab04_Bai_02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox rtbview;
    }
}