using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class VehicleInfo : Form
    {
        public VehicleInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TruckInfo().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new CarInfo().Show();
            this.Hide();
        }

        private void bike_Click(object sender, EventArgs e)
        {
            new BikeInfo().Show();
            this.Hide();
        }

        private void bus_Click(object sender, EventArgs e)
        {
            new BusInfo().Show();
            this.Hide();
        }
    }
}
