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
    public partial class BusInfo : Form
    {
        public BusInfo()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string busNumber =busNum.Text;
            string busDate =Busd.Text;
            string busTime =BusT.Text;
            double busMoneyReceived = Convert.ToDouble(busMonRec.Text);
            double busMoneyBack = Convert.ToDouble(busMonBac.Text);

            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = "Insert into Details(MoneyReceived,MoneyBack,CarNum,Date,Time) values('" + busNumber + "','" + busDate + "','" + busTime + "', '" + busMoneyReceived + "', '" + busMoneyBack + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlCon_obj.Sqlcon);
            cmd.ExecuteNonQuery();
            sqlCon_obj.Sqlcon.Close();

            new BusTollCollection().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            VehicleInfo back = new VehicleInfo();
            back.Show();
        }

        private void textcarnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
