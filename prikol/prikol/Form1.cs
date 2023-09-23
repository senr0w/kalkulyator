using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prikol
{
    public partial class Form1 : Form
    {
        public string D, num1;
        public bool num2;

        public Form1()
        {
            num2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_TextChanged(object sender, EventArgs e)
        {
            if(num2){
                num2 = false;
                TBone.Text = "0";
            }

            Button B=(Button)sender;
            if(TBone.Text=="0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text+B.Text;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Button B=(Button)sender;
            D = B.Text;
            num1 = TBone.Text;
            num2 = true;

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                TBone.Text = "0";
            }

            Button B = (Button)sender;
            if (TBone.Text == "0")
                TBone.Text = B.Text;
            else
                TBone.Text = TBone.Text + B.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            num1 = TBone.Text;
            num2 = true;
        }

        private void btnUmn_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            num1 = TBone.Text;
            num2 = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            num1 = TBone.Text;
            num2 = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            TBone.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRav_Click(object sender, EventArgs e)
        {
           double dn1, dn2,res;
            res = 0;
            dn1= Convert.ToDouble(num1);
            dn2= Convert.ToDouble(TBone.Text);
            if (D == "+")
            {
                res=dn1+ dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            D = "=";
            num2 = true;
            TBone.Text=res.ToString();
        }
    }
}
