using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAb03
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            txtSecurityCode.Text += x.Text;
        }

        private void ButtonCheckIn_Click(object sender, EventArgs e)
        {
            int pw;

            if(!int.TryParse(txtSecurityCode.Text, out pw))
            {
                MessageBox.Show("Không đúng định dạng dữ liệu. Vui lòng Clear và nhập trở lại đúng dạng!");
                return;
            }

            if ( pw < 1000 || pw > 9999)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Restricted Access!");
                txtSecurityCode.Clear();
            }
            if (pw == 1645 || pw == 1689)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Technicians");
                txtSecurityCode.Clear();
            }
            if (pw == 8345)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Custodians");
                txtSecurityCode.Clear();
            }

            if (pw == 9998 || pw == 1006 || pw == 1007 || pw == 1008)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Scientist");
                txtSecurityCode.Clear();
            }
        }
    }
}
