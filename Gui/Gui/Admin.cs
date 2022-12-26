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

namespace Gui
{
    public partial class AdminInfo : Form
    {
        public AdminInfo()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManagerInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchNumber = txtSearch.Text;
            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = ("select * from Details where  CarNum='"+searchNumber+"';");
            SqlCommand cmd = new SqlCommand(sql, sqlCon_obj.Sqlcon);
            //cmd.ExecuteNonQuery();//data voranor jonno/insert jonno

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgvAdmin.DataSource = dt;
            }
            else {
                MessageBox.Show(" Number Not Found! ");
            
            }




            sqlCon_obj.Sqlcon.Close();
        }

        private void btnTCD_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime carDate = DTP_day.Value;
            string day = carDate.ToString("dd");

            SqlConnector sqlCon_1 = new SqlConnector();
            string sql_1 = "select * from incomeTable where date='"+day+"'";
            SqlCommand cmd_1 = new SqlCommand(sql_1,sqlCon_1.Sqlcon);

            SqlDataAdapter sda = new SqlDataAdapter(cmd_1);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                double total = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double tl = Convert.ToDouble(dt.Rows[i]["TollCollection"].ToString());
                    total = total + tl;
                }
                MessageBox.Show("Total " + total);
            }
            else {
                MessageBox.Show("Wroong Date! ");
            }
            sqlCon_1.Sqlcon.Close();

        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            DateTime carMonth = DTPmonth.Value;
            string month = carMonth.ToString("MMMM");

            SqlConnector sqlCon_2 = new SqlConnector();
            string sql_2 = "select * from incomeTable where Month='" + month + "'";
            SqlCommand cmd_2 = new SqlCommand(sql_2, sqlCon_2.Sqlcon);

            SqlDataAdapter sda = new SqlDataAdapter(cmd_2);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                double total_month = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double tl = Convert.ToDouble(dt.Rows[i]["TollCollection"].ToString());
                    total_month = total_month + tl;
                }
                MessageBox.Show("Total " + total_month);
            }
            else {
                MessageBox.Show("Wrong Month! ");
            }
            sqlCon_2.Sqlcon.Close();

        }

        private void btnyear_Click(object sender, EventArgs e)
        {
            DateTime carYear = DTPyear.Value;
            string year = carYear.ToString("yyyy");

            SqlConnector sqlCon_1 = new SqlConnector();
            string sql_1 = "select * from incomeTable where Year='" + year + "'";
            SqlCommand cmd_1 = new SqlCommand(sql_1, sqlCon_1.Sqlcon);

            SqlDataAdapter sda = new SqlDataAdapter(cmd_1);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                double total_year = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double tl = Convert.ToDouble(dt.Rows[i]["TollCollection"].ToString());
                    total_year = total_year + tl;
                }
                MessageBox.Show("Total " + total_year);
            }
            else {
                MessageBox.Show("Wrong Year!");
            }
            
            sqlCon_1.Sqlcon.Close();

        }
    }
}
