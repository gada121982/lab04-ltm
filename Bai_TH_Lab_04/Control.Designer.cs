namespace Bai_TH_Lab_04
{
    partial class Control
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
            this.btnBai01 = new System.Windows.Forms.Button();
            this.btnBai03 = new System.Windows.Forms.Button();
            this.btnBai02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai01
            // 
            this.btnBai01.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai01.Location = new System.Drawing.Point(30, 80);
            this.btnBai01.Name = "btnBai01";
            this.btnBai01.Size = new System.Drawing.Size(104, 42);
            this.btnBai01.TabIndex = 0;
            this.btnBai01.Text = "Bài 01";
            this.btnBai01.UseVisualStyleBackColor = true;
            this.btnBai01.Click += new System.EventHandler(this.btnBai01_Click);
            // 
            // btnBai03
            // 
            this.btnBai03.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai03.Location = new System.Drawing.Point(137, 162);
            this.btnBai03.Name = "btnBai03";
            this.btnBai03.Size = new System.Drawing.Size(104, 42);
            this.btnBai03.TabIndex = 1;
            this.btnBai03.Text = "Bài 03";
            this.btnBai03.UseVisualStyleBackColor = true;
            this.btnBai03.Click += new System.EventHandler(this.btnBai03_Click);
            // 
            // btnBai02
            // 
            this.btnBai02.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai02.Location = new System.Drawing.Point(238, 80);
            this.btnBai02.Name = "btnBai02";
            this.btnBai02.Size = new System.Drawing.Size(104, 42);
            this.btnBai02.TabIndex = 2;
            this.btnBai02.Text = "Bài 02";
            this.btnBai02.UseVisualStyleBackColor = true;
            this.btnBai02.Click += new System.EventHandler(this.btnBai02_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 288);
            this.Controls.Add(this.btnBai02);
            this.Controls.Add(this.btnBai03);
            this.Controls.Add(this.btnBai01);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai01;
        private System.Windows.Forms.Button btnBai03;
        private System.Windows.Forms.Button btnBai02;
    }
}