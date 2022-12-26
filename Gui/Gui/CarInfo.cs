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
    public partial class CarInfo : Form
    {
        public CarInfo()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string carNumber = textCarNum.Text;
            string carDate = dateTimePicker.Text;
            string carTime = Time.Text;
            double carMoney = Convert.ToDouble(textMoneyRec.Text);
            double carMoneyBack = Convert.ToDouble(textMoneyBack.Text);
            string carVehicleType = "Car";
         


            SqlConnector sqlCon_obj = new SqlConnector();
            string sql = "Insert into Details(MoneyReceived,MoneyBack,CarNum,Date,Time,VehicleType) " +
                "values('" + carMoney+"','"+carMoneyBack+"','"+carNumber+"', '"+carDate+"', '"+carTime+"','"+carVehicleType+"')";
            
            SqlCommand cmd = new SqlCommand(sql, sqlCon_obj.Sqlcon);
            cmd.ExecuteNonQuery();
            sqlCon_obj.Sqlcon.Close();

            Vehicle_Print vh = new Vehicle_Print();
            vh.label7.Text = carVehicleType;
            vh.label8.Text=carNumber;
            vh.label9.Text = carDate;
            vh.label10.Text = carTime;
            vh.label11.Text = Convert.ToString(carMoney);
            vh.label12.Text = Convert.ToString(carMoneyBack);
            vh.Show();
            this.Hide();


            //Print print_form = new Print();
            //print_form.nameOfControlVisible = true;

            /* SqlConnector sqlCon_a = new SqlConnector();
             string sql_1 = "select * from Details where ";
             SqlCommand cmd_1 = new SqlCommand(sql_1, sqlCon_a.Sqlcon);


             SqlDataAdapter sda = new SqlDataAdapter(cmd_1);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             //dt = print_form.dgv;
             print_form.dgv.DataSource = dt;
             print_form.Show();
             this.Hide();*/



            //new CarTollCollection().Show();
            //this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            VehicleInfo back = new VehicleInfo();
            back.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }
        private void textMoneyRec_TextChanged(object sender, EventArgs e)
        {
           /* double toll = 500;
            double moneyReceived = Convert.ToDouble(textMoneyRec.Text);
            double moneyBack = moneyReceived - toll;
            this.textMoneyBack.Text = Convert.ToString(moneyBack);*/


        }

        private void textMoneyBack_TextChanged(object sender, EventArgs e)
        {
            /*double toll = 500;
            double moneyReceived = Convert.ToDouble(textMoneyRec.Text);
            double moneyBack = moneyReceived - toll;
            textMoneyBack.Text = Convert.ToString(moneyBack);*/
            //textMoneyRec_TextChanged(sender,e);
        }

        private void btn_moneyBack_Click(object sender, EventArgs e)
        {
            double toll = 500;
            double moneyReceived = Convert.ToDouble(textMoneyRec.Text);
            double moneyBack = moneyReceived - toll;
            textMoneyBack.Text = Convert.ToString(moneyBack);

        }
    }
}
