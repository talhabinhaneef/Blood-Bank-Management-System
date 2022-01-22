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
using System.Data.SqlClient;

namespace Blood_Bank_Management_System
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"SERVER=admin.c8tiwocbpmxj.us-east-1.rds.amazonaws.com; USER ID=admin; PASSWORD=hkAkGmTLNuutqzy8ht6e; DATABASE=BLOODBANK;");

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
            string username = txtboxusername.Text;
            string password = txtboxpassword.Text;
             string query = "SELECT * FROM dbo.login WHERE username='" + txtboxusername.Text.Trim() + "' AND Password='" + txtboxpassword.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();    
            adapter.Fill(dtb);
            if(dtb.Rows.Count ==1)
            {
                this.Hide();
                var Select = new Select();
                Select.Show();

            }
            else
            {
                MessageBox.Show(" Wrong Uername OR Password");
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            regform reg = new regform();    
            reg.Show();
        }
    }
}
