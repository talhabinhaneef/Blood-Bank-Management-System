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
using System.Data.OleDb;

namespace Blood_Bank_Management_System
{
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\BS.IT\5th Semester\VP Project\Database\DataBackup.mdb");

        public Form2()
        {
            InitializeComponent();


           


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/mohammad-talha-bin-haneef");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
           cmd.CommandText = "INSERT into [DONOR](Name1,phone,age,address,L_donation,Blood_g) Values ('" + txtboxname.Text + "','" + txtboxphone.Text + "','" + comboBoxage.Text + "','" + txtboxaddress.Text + "','" + comboBoxduration.Text + "','" + comboBoxselectblood.Text + "')";
            //cmd.CommandText = "INSERT INTO [DONOR](Name1) Values ('"+ txtboxname.Text +"')";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Successful ");


        }

        private void comboBoxselectblood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
