using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SingleResponsility
{
   public class EmployeeConnection
    {

        public static SqlConnection connect = new SqlConnection("Data Source=LAPTOP-1KQ0BKEU;Initial Catalog=Personel;Integrated Security=True");
    }
}
