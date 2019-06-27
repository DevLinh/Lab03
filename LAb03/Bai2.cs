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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        int USCLN(int a, int b)
        {


            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int a = Math.Abs(int.Parse(txtA.Text));
            int b = Math.Abs(int.Parse(txtB.Text));

            if (rbtnU.Checked)
            {
                txtResult.Text = USCLN(a, b).ToString();
            }
            if (rbtnB.Checked)
            {
                txtResult.Text = BSCNN(a, b).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtA.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtB.Text.Contains('.') == true : true))
                e.Handled = true;
        }
    }
}
