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
    public partial class Lab04_Bai_02 : Form
    {
        public Lab04_Bai_02()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string savefile = txtPath.Text + "//SaveFile.txt";


            try
            {
                WebClient myclient = new WebClient();

                Stream response = myclient.OpenRead(txtURL.Text);

                myclient.DownloadFile(txtURL.Text, savefile); // Download file xuống . 

                response.Close();

                WebRequest request = WebRequest.Create(txtURL.Text);  // nhận response  . 


                WebResponse response1 = request.GetResponse();  // lấy nội dung của stream containing trả về từ sever  . 

                Stream dataStream = response1.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);  //  đọc nội dung 

                string responsefromsever = reader.ReadToEnd();

                rtbview.Text = responsefromsever;

                response1.Close();


            }
            catch
            {
                MessageBox.Show("Fail to download file or link Url be false");

            }


        }
    }
}
