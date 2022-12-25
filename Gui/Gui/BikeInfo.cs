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
    public partial class BikeInfo : Form
    {
        public BikeInfo()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {

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
