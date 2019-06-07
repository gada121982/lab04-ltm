namespace Bai_TH_Lab_04
{
    partial class Lab04_Bai_03
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(93, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(174, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(255, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 34);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(724, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownLoad.Location = new System.Drawing.Point(822, 27);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(98, 34);
            this.btnDownLoad.TabIndex = 5;
            this.btnDownLoad.Text = "Download";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSource.Location = new System.Drawing.Point(950, 27);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(93, 34);
            this.btnViewSource.TabIndex = 6;
            this.btnViewSource.Text = "ViewSource";
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(336, 35);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(371, 26);
            this.txtURL.TabIndex = 7;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 71);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1031, 386);
            this.webBrowser.TabIndex = 8;
            // 
            // Lab04_Bai_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 473);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "Lab04_Bai_03";
            this.Text = "Lab04_Bai_03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}