using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
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
            
        
        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = "select * from Table_1 where EmpNAME='" + textusername.Text + "'and EmpPASS='" + textpass.Text + "'";
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
                       
                    }
                    else
                    {
                        new VehicleInfo().Show();
                        this.Hide();
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Username and Password ");
            }

            sqlCon_obj.Sqlcon.Close();

        }
    }
}
