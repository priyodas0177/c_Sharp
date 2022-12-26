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
    public partial class TruckInfo : Form
    {
        public TruckInfo()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string TruckNumber = txtTnum.Text;
            string TruckDate = txtTDat.Text;
            string TruckTime = txtTtim.Text;
            double TruckMoneyReceived = Convert.ToDouble(txtTmonRec.Text);
            double TruckMoneyBack = Convert.ToDouble(txtTMonBac.Text);

            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = "Insert into Details(MoneyReceived,MoneyBack,CarNum,Date,Time) values('" + TruckNumber + "','" + TruckDate + "','" + TruckTime + "', '" + TruckMoneyReceived + "', '" + TruckMoneyBack + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlCon_obj.Sqlcon);
            cmd.ExecuteNonQuery();
            sqlCon_obj.Sqlcon.Close();
            new TruckTollCollection().Show();
            this.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            VehicleInfo back = new VehicleInfo();
            back.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
