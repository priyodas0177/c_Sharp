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
    public partial class BikeInfo : Form
    {
        public BikeInfo()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string bikeNumber = bNum.Text;
            string bikeDate = bDate.Text;
            string bikeTime = bTime.Text;
            double bikeMoneyReceived = Convert.ToDouble(bmoneyReceived.Text);
            double bikeMoneyBack = Convert.ToDouble(bMoneyBack.Text);

            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = "Insert into Details(MoneyReceived,MoneyBack,CarNum,Date,Time) values('" + bikeMoneyReceived + "','" + bikeMoneyBack + "','" + bikeNumber + "', '" + bikeDate + "', '" + bikeTime + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlCon_obj.Sqlcon);
            cmd.ExecuteNonQuery();
            sqlCon_obj.Sqlcon.Close();


            new BikeTollCollection().Show();
            this.Hide(); 
        }

        private void textcarnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcarname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            VehicleInfo back = new VehicleInfo();
            back.Show();
        }
    }
}
