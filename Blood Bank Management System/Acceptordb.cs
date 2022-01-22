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
    public partial class Acceptordb : Form
    {
        SqlConnection conn = new SqlConnection(@"SERVER=admin.c8tiwocbpmxj.us-east-1.rds.amazonaws.com; USER ID=admin; PASSWORD=hkAkGmTLNuutqzy8ht6e; DATABASE=BLOODBANK;");

        public Acceptordb()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELEcT * From ACCEPTOR", conn);
    
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select s = new Select();
            s.ShowDialog();
        }
    }
}
