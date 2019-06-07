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
using HtmlAgilityPack;

namespace Bai_TH_Lab_04
{
    public partial class Lab04_Bai_03 : Form
    {
        public Lab04_Bai_03()
        {
            InitializeComponent();
        }
        string returnstring(string a) // hàm này để định dạng đuôi file . cắt 3 kí tự cuối cùng. vd : jpg , png , gif , để khi tải về định dạng được . 
        {
            string result = "";
            result = a.Substring(a.Length - 4);
            return result;

        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtURL.Text, false);
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            Lab04_Bai_03_viewsource.url = txtURL.Text; // gán url cho biến url ở form Lab04-bai03-viewsource
            Lab04_Bai_03_viewsource bai3view = new Lab04_Bai_03_viewsource();
            bai3view.Show();
        }
        string ChangePathToGoal(  string path)
        {

            char c = (char)92;
           
           
            for (int i = 0; i < path.Length; i ++)
            {
               if (path[i] == c )
                {

                    path = path.Insert(i, c.ToString());
                    i++; 

                }
               
            }
            return path; 

        }
        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                string path = Path.GetFullPath(fbd.SelectedPath);

                path = ChangePathToGoal(path);

               

                // Những file có thể tải là . css , javascript , image (một số định dạng cơ bản png v.v.v , gif ,   

                int checkcss = 0, checkjs = 0, checkimage = 0; // check đã load URL với path lưu file linksrc.txt thành công chưa 

                int i = 0; // biến lưu thứ tự của image được lưu .

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument docfilecss = new HtmlAgilityPack.HtmlDocument(); // tải file css hoặc những file trong thuộc tính href của thẻ link 
                HtmlAgilityPack.HtmlDocument docfilejs = new HtmlAgilityPack.HtmlDocument(); // tải file js hoặc những file khác có đuôi 2 kí tự trong thuộc tính href của thẻ link 
                HtmlAgilityPack.HtmlDocument docfileimage = new HtmlAgilityPack.HtmlDocument();

                FileStream fs = null;
                StreamWriter sw = null; // tạo 2 biến này để lưu lại URL những link bắt được để tải về. để kiểm tra xem những link nào không tải được. 

                WebClient myclient1 = new WebClient();

                Stream response = myclient1.OpenRead(txtURL.Text);

                myclient1.DownloadFile(txtURL.Text, path + "\\index.html"); // Download file html xuống . 

                response.Close();
                //---------Đọc file img , gif--------------

                try
                {
                    // load URL 
                    docfileimage = web.Load(txtURL.Text);
                    fs = new FileStream(path + "\\" + "text.txt", FileMode.OpenOrCreate); // cô bỏ file chứa tất cả link src này ở đâu củng đươc để check những gì nó get đươc nha
                    sw = new StreamWriter(fs);
                    checkimage = 1;
                }
                catch (Exception h10)
                {

                    MessageBox.Show(h10.Message);

                }

                if (checkimage == 1) // khi load URL thành công
                {
                       
                    try
                    {
                        foreach (HtmlNode link in docfileimage.DocumentNode.SelectNodes("//img")) // chọn thẻ img
                        {
                            try
                            {
                                string a = link.Attributes["src"].Value; // chọn src trong thẻ img

                                sw.WriteLine(a);
                                string savefile = path + "\\" + i + returnstring(a);
                                WebClient myclient = new WebClient();
                                myclient.DownloadFile(a, savefile);
                                i++;

                            }
                            catch
                            {

                                try
                                {
                                    // một số urlg khi get về không đúng định dạng , có thể nó lưu trong cache , vd chỉ /abc/xyz/ayk.png . nên phải fix url lại để có thể download được . 
                                    string a = txtURL.Text + link.Attributes["src"].Value;
                                    sw.WriteLine(a);
                                    string savefile = path + "\\" + i + returnstring(a);
                                    WebClient myclient = new WebClient();
                                    myclient.DownloadFile(a, savefile);
                                    i++;

                                }
                                catch
                                {
                                    MessageBox.Show("sever error return file"); // có một số web không thể get file về được như youtube .v.v. 
                                }

                            }
                        }
                    }
                    catch (Exception k4)
                    {
                        MessageBox.Show(k4.Message);

                    }
                }


                //// -----------Đọc file css------------------

                try
                {
                    // load URL 
                    docfilecss = web.Load(txtURL.Text);

                    checkcss = 1;
                }
                catch (Exception k)
                {

                    MessageBox.Show(k.Message);

                }

                if (checkcss == 1) // khi load URL thành công
                {
                    try
                    {
                        foreach (HtmlNode link in docfilecss.DocumentNode.SelectNodes("//link")) // chọn thẻ link
                        {

                            try
                            {
                                string a = link.Attributes["href"].Value;


                                string savefile = path + "\\" + i + returnstring(a);
                                WebClient myclient = new WebClient();
                                myclient.DownloadFile(a, savefile);
                                i++;
                                sw.WriteLine(a);

                            }
                            catch
                            {
                                MessageBox.Show("có link không tải được");
                                // một số url khi get về không đúng định dạng , có thể nó lưu trong cache , vd chỉ /abc/xyz/ayk.png . nên phải fix url lại để có thể download được . 
                                string a = txtURL.Text + link.Attributes["href"].Value;
                                sw.WriteLine(link.Attributes["href"].Value);
                                string savefile = path + "\\" + i + returnstring(a);

                                WebClient myclient = new WebClient();
                                try
                                {
                                    myclient.DownloadFile(a, savefile);
                                    i++;

                                }
                                catch (Exception k1)
                                {
                                    MessageBox.Show(k1.Message);
                                }

                            }
                        }
                    }
                    catch (Exception k3)
                    {
                        MessageBox.Show(k3.Message);
                    }
                }
                // ---- docfile javascript ------ 
                try
                {
                    // load URL 
                    docfilejs = web.Load(txtURL.Text);

                    checkjs = 1;
                }
                catch (Exception k6)
                {

                    MessageBox.Show(k6.Message);

                }

                if (checkjs == 1) // khi load URL thành công
                {
                    try
                    {
                        foreach (HtmlNode link in docfilejs.DocumentNode.SelectNodes("//script")) // chọn thẻ link
                        {

                            try
                            {
                                string a = link.Attributes["src"].Value; // chọn src trong thẻ script

                                string savefile = path + "\\" + i + ".js";
                                WebClient myclient = new WebClient();
                                myclient.DownloadFile(a, savefile);
                                i++;
                                sw.WriteLine(a);

                            }
                            catch
                            {
                                MessageBox.Show("có link không tải được");

                                string a = txtURL.Text + link.Attributes["src"].Value;
                                sw.WriteLine(link.Attributes["src"].Value);
                                string savefile = path + "\\" + i + returnstring(a);

                                WebClient myclient = new WebClient();
                                try
                                {
                                    myclient.DownloadFile(a, savefile);
                                    i++;

                                }
                                catch (Exception k1)
                                {
                                    MessageBox.Show(k1.Message);
                                }

                            }
                        }
                    }
                    catch (Exception k5)
                    {
                        MessageBox.Show(k5.Message);
                    }
                }
                MessageBox.Show("Tất cả lưu ở " + path); 

            }


        }
    }
}
