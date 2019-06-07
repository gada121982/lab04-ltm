using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Bai_TH_Lab_04
{
    public partial class Lab04_Bai_03_viewsource : Form
    {
        public Lab04_Bai_03_viewsource()
        {
            InitializeComponent();
            txtViewSource.Text = GetHTML(url);
        }
        public static string url = "";
        private string GetHTML(string szURL)
        {
            // tạo 1 request từ url
            WebRequest request = WebRequest.Create(szURL);

            // nhận response  . 
            WebResponse response = request.GetResponse();

            // lấy nội dung của stream containing trả về từ sever  . 

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);
            //  đọc nội dung 
            string responsefromsever = reader.ReadToEnd();

            response.Close();
            return responsefromsever;


        }

        private void txtViewSource_TextChanged(object sender, EventArgs e)
        {
            txtViewSource.ScrollBars = ScrollBars.Both;
        }
    }
}
