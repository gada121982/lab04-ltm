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
    public partial class Lab04_Bai_01 : Form
    {
        public Lab04_Bai_01()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {


                WebRequest request = WebRequest.Create(txtURL.Text);

                // nhận response  . 
                WebResponse response = request.GetResponse();

                // lấy nội dung của stream containing trả về từ sever  . 

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                //  đọc nội dung 
                rtbView.Text = reader.ReadToEnd();

                response.Close();


            }
            catch
            {

                MessageBox.Show("URL bị lỗi");
            }





        }
    }
}
