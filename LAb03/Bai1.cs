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
    public partial class Bai1 : Form
    {
        double a, b, result;
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            result = a + b;
            txtResult.Text = result.ToString();
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            result = a - b;
            txtResult.Text = result.ToString();
        }

        private void BtnMuntiply_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            result = a * b;
            txtResult.Text = result.ToString();
        }

        private void BtnDevide_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtB.Text) != 0)
            {
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                result = a / b;
                txtResult.Text = result.ToString();
            } else
            {

            }
            
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
