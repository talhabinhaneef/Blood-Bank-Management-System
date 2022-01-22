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
    public partial class availability : Form
    {
        SqlConnection con = new SqlConnection(@"SERVER=admin.c8tiwocbpmxj.us-east-1.rds.amazonaws.com; USER ID=admin; PASSWORD=hkAkGmTLNuutqzy8ht6e; DATABASE=BLOODBANK;");
        public availability()
        {
            InitializeComponent();
        }

        private void availability_Load(object sender, EventArgs e)
        {
             con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select D_blood, COUNT (*) AS TOTAL FROM DONOR GROUP BY D_BLOOD", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"result");
            dataGridView1.DataSource=ds.Tables["result"].DefaultView;    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            acceptor acceptor = new acceptor();
            acceptor.ShowDialog();
        }
    }
}
