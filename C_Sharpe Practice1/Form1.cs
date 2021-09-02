using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharpe_Practice1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            MessageBox.Show("はじまるよ！");

            DialogResult result = MessageBox.Show("ABCの次はEである。","問題１", MessageBoxButtons.YesNo);
            judge1(result.ToString());

            result = MessageBox.Show("1+1は2である。", "問題２", MessageBoxButtons.YesNo);
            judge2(result.ToString());

            result = MessageBox.Show("月は惑星である。", "問題３", MessageBoxButtons.YesNo);
            judge1(result.ToString());

            //何問追加してもよし




            MessageBox.Show("おわりです！");

            MessageBox.Show("君の点数は10問中 " + label1.Text + "点だよ！");

            this.Close();
            

        }

        private void judge1(string result) 
        {
            if (result == "Yes")
            {
                label3.Text = "不正解";
            }
            else
            {
                label3.Text = "正解！";
                label1.Text = (Int32.Parse(label1.Text) + 1).ToString();
                
            }
        }

        private void judge2(string result)
        {
            if (result == "Yes")
            {
                label3.Text = "正解！";
                label1.Text = (Int32.Parse(label1.Text) + 1).ToString();
            }
            else
            {
                label3.Text = "不正解";
            }
        }
    }
}
