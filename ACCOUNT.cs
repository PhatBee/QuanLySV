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

        public bool insertAccount(string username, string password, string fname, string lname, string email, string phone)
        {
            SqlCommand command = new SqlCommand("INSERT INTO request (username, password, fname, lname, gmail, phone)"
                + "VALUES (@user, @pass, @fname, @lname, @email, @phone)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;

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
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool submitAccount(string username, string password, string fname, string lname, string email, string phone)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username, password, fname, lname, gmail, phone)"
                + "VALUES (@user, @pass, @fname, @lname, @email, @phone)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;

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

        public bool deleteRequestAccount(string username)
        {
            
            SqlCommand command = new SqlCommand("DELETE FROM request WHERE username = @username", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
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

        public bool deleteAccount(string username)
        {

            SqlCommand command = new SqlCommand("DELETE FROM login WHERE username = @username", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
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

        public bool updateAccount(string username, string password, string fname, string lname, string email, string phone)
        {
            SqlCommand command = new SqlCommand("UPDATE login SET password = @pass, fname = @fname, lname = @lname, gmail = @email, phone = @phone WHERE username = @user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;

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

    }
}
