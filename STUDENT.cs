using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class STUDENT
    {
        MY_DB mydb = new MY_DB();

        // function to insert new student
        
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture) 
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" 
                + "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("pic", SqlDbType.Image).Value = picture.ToArray();


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
