using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsility
{
    public class EmployeeCrud
    {
        public int EmployeeAdd(EmployeeDef p)
        {
            SqlCommand commandadd = new SqlCommand("insert into PerTable (PerAd, PerSoyad, PerYas) values (@p1,@p2,@p3)", EmployeeConnection.connect);
            if (commandadd.Connection.State != ConnectionState.Open)
            {
                commandadd.Connection.Open();
            }
            commandadd.Parameters.AddWithValue("@p1", p.PerAd);
            commandadd.Parameters.AddWithValue("@p2", p.PerSoyad);
            commandadd.Parameters.AddWithValue("@p3", p.PerYas);

            return commandadd.ExecuteNonQuery();
        }

        public void EmployeeList()
            {

            SqlCommand command1 = new SqlCommand("Select * From PerTable", EmployeeConnection.connect);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[6]); 
            }
            dr.Close();
        }
    }
}
