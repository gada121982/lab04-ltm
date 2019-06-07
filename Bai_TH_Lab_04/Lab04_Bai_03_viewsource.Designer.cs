namespace Bai_TH_Lab_04
{
    partial class Lab04_Bai_03_viewsource
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
            this.txtViewSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtViewSource
            // 
            this.txtViewSource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewSource.Location = new System.Drawing.Point(12, 12);
            this.txtViewSource.Multiline = true;
            this.txtViewSource.Name = "txtViewSource";
            this.txtViewSource.ReadOnly = true;
            this.txtViewSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtViewSource.Size = new System.Drawing.Size(588, 389);
            this.txtViewSource.TabIndex = 0;
            this.txtViewSource.TextChanged += new System.EventHandler(this.txtViewSource_TextChanged);
            // 
            // Lab04_Bai_03_viewsource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 413);
            this.Controls.Add(this.txtViewSource);
            this.Name = "Lab04_Bai_03_viewsource";
            this.Text = "Lab04_Bai_03_viewsource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtViewSource;
    }
}