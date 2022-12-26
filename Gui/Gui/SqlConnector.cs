using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gui
{
    public class SqlConnector
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom {
            get { return this.Sqlcom; }
            set { this.sqlcom = value; }
        }
        public SqlConnector() {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-82CRDF5;Initial Catalog=A;Integrated Security=True");
            Sqlcon.Open();
          
        }

        

    }
}
