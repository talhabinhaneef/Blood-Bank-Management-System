using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Blood_Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Contact Developer ");
            MessageBox.Show(" Whatsapp Me + 92 309 7068560 ");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtboxusername.Text.Trim() == "" && txtboxpassword.Text.Trim() == "")
            {
                MessageBox.Show(" Please Enter Username & Password ");
            }
            else if (txtboxpassword.Text == "admin" && txtboxusername.Text == "admin")
            {
                this.Hide();
                Select dash = new Select();  
                dash.ShowDialog();
                dash = null;
                this.Show();
            }
            else
            {
                MessageBox.Show(" Wrong Credentials, PLEASE! Enter Correct Details");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/mohammad-talha-bin-haneef");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
