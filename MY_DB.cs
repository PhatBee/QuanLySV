using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLSV
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        // get the connection
        public SqlConnection getConnection
        {
            get { return con; }
        }

        // open the connection
        public void openConection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }

        // close the connection
        public void closeConection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
