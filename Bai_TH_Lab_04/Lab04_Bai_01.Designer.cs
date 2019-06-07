namespace Bai_TH_Lab_04
{
    partial class Lab04_Bai_01
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.rtbView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(566, 21);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(118, 29);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(12, 21);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(494, 26);
            this.txtURL.TabIndex = 1;
            // 
            // rtbView
            // 
            this.rtbView.Location = new System.Drawing.Point(12, 69);
            this.rtbView.Name = "rtbView";
            this.rtbView.ReadOnly = true;
            this.rtbView.Size = new System.Drawing.Size(672, 349);
            this.rtbView.TabIndex = 2;
            this.rtbView.Text = "";
            // 
            // Lab04_Bai_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 430);
            this.Controls.Add(this.rtbView);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnGet);
            this.Name = "Lab04_Bai_01";
            this.Text = "Bai_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RichTextBox rtbView;
    }
}

