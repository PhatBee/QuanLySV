using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class ACCOUNT
    {
        MY_DB mydb = new MY_DB();

        // function to insert new account

        public bool insertAccount(string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username, password)"
                + "VALUES (@user, @pass)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

            mydb.openConection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConection();
                return true;
            }
            else
            {
                mydb.closeConection();
                return false;
            }
        }

        public DataTable getAccounts(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

    }
}
