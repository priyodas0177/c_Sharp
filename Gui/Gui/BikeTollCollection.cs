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
    public partial class BikeTollCollection : Form
    {
        public BikeTollCollection()
        {
            InitializeComponent();
        }

        private void BikeTollCollection_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            BikeInfo back = new BikeInfo();
            back.Show();
        }
    }
}
