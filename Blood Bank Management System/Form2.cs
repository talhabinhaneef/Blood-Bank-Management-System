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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"SERVER=serverIP; USER ID=Server Username; PASSWORD=server password; DATABASE=database name;");


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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
           cmd.CommandText = "INSERT into [DONOR](D_id,D_name,D_phone,D_age,D_add,D_last,D_Blood) Values ('" + txtid.Text + "','" + txtboxname.Text + "','" + txtboxphone.Text + "','" + comboBoxage.Text + "','" + txtboxaddress.Text + "','" + comboBoxduration.Text + "','" + comboBoxselectblood.Text + "')";
            //cmd.CommandText = "INSERT INTO [DONOR](Name1) Values ('"+ txtboxname.Text +"')";

            cmd.ExecuteNonQuery();
            conn.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select s = new Select();
            s.ShowDialog();
        }
    }
}
