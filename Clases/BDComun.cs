using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaClinica
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data source=MONTERO-I7\\SAVAGETV; Initial Catalog=AgendaClinica; User Id =sa; Password=masterkey");
            Conn.Open();

            return Conn;
        }

    }
}
