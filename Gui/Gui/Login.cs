using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // sql connect 
            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = "select * from Table_1 where EmpNAME='"+textusername.Text+"'and EmpPASS='"+textpass.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, sqlCon_obj.Sqlcon);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["EmpRole"].ToString() == "Admin")
                    {
                        new AdminInfo().Show();
                        this.Hide();
                        //Console.WriteLine("Admin");
                    }
                    else
                    {
                        new VehicleInfo().Show();
                        this.Hide();
                       // Console.WriteLine("Employee");
                    }
                }
            }
            else {
                MessageBox.Show("Wrong Username and Password ");
            }
            /*SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                Console.WriteLine("{0} {1} {2} {3} {4} ", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
                    string name = rdr.GetString(1);
               // Console.WriteLine("UserName is : " + username);
                if (textusername.Text == name)
                {
                   string  pass = rdr.GetString(2);
                    if (textpass.Text == pass)
                    {
                        
                        *//*new VehicleInfo().Show();
                        this.Hide();*//*
                        MessageBox.Show("Login Successfull !");
                        new AdminInfo().Show();
                        this.Hide();
                        *//*new VehicleInfo().Show();
                        this.Hide();*//*
                    }
                    else
                    {
                        MessageBox.Show("PassWord or Username Doesnot Match_1");
                    }
                }
                else
                {
                    MessageBox.Show("PassWord or Username Doesnot Match_2");
                }

                
            }*/
            


         
        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
