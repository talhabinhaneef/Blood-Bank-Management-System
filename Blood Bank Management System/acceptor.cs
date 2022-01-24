using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Bank_Management_System
{
    public partial class acceptor : Form
    {
        SqlConnection conn = new SqlConnection(@"SERVER=serverIP; USER ID=Server Username; PASSWORD=server password; DATABASE=database name;");


        public acceptor()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            availability availability = new availability();
            availability.ShowDialog();
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void acceptor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT into [ACCEPTOR](A_id,A_name,A_phone,A_age,A_add,A_purpose,A_Blood) Values ('" + acceptorid.Text + "','" + txtboxname.Text + "','" + txtboxphone.Text + "','" + comboBoxage.Text + "','" + txtboxaddress.Text + "','" + purpose.Text + "','" + comboBoxselectblood.Text + "')";
            //cmd.CommandText = "INSERT INTO [DONOR](Name1) Values ('"+ txtboxname.Text +"')";

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" Successful ");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select s = new Select();
            s.ShowDialog(); 
        }
    }
}
