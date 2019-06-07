using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_TH_Lab_04
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab04_Bai_01 bai01 = new Lab04_Bai_01();
            bai01.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab04_Bai_02 bai02 = new Lab04_Bai_02();
            bai02.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab04_Bai_03 bai03 = new Lab04_Bai_03();
            bai03.Show();
        }
    }
}
