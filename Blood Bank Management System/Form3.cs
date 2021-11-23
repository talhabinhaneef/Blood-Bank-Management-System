using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blood_Bank_Management_System
{
    public partial class Form3 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\BS.IT\5th Semester\VP Project\Database\DataBackup.mdb");
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbDataAdapter da = new OleDbDataAdapter("SELEcT * From DONOR order by Donor_ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();



        }
    }
}
