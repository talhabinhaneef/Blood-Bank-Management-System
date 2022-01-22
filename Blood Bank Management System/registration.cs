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
    public partial class regform : Form
    {
        SqlConnection conn= new SqlConnection(@"SERVER=admin.c8tiwocbpmxj.us-east-1.rds.amazonaws.com; USER ID=admin; PASSWORD=hkAkGmTLNuutqzy8ht6e; DATABASE=BLOODBANK;");

        public regform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtboxpassword.Text == "")|| (txtboxusername.Text ==""))
                {
                    MessageBox.Show(" Fill Username & Password"); 
                }
                else
                {
                    
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT into [login](password,username) Values ('" + txtboxpassword.Text + "','" + txtboxusername.Text + "')";

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(" Successful ");
                    string msg = "Registered Successfully!";
                    string title = "Registered!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(msg, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        var Form1 = new Form1();
                        Form1.ShowDialog();
                    }

                
                        
                        }

            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }  
        }
    }
}
