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
        int num1,num2,sum;

        public Form1()
        {
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
            TBone.Text = TBone.Text + "1";
            num1 = 1;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "2";
            num2 = 2;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "5";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "+";

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "-";
        }

        private void btnUmn_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "*";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TBone.Text = TBone.Text + "/";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRav_Click(object sender, EventArgs e)
        {
            sum = num1 + num2;
            TBone.Text = sum.ToString();
        }
    }
}
