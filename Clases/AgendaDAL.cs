using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaClinica
{
    public class AgendaDAL
    {
        public static int Agregar(Agenda pAgenda)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                /* string timeStamp = DateTextBox.Text + " " + TimeTextBox.Text;
                    var requestTimeStamp = Convert.ToDateTime(timeStamp).ToString("yyyy-MM-dd H:mm:ss"); */

                
                SqlCommand Comando = new SqlCommand(string.Format("Insert into Agenda "+
                                        "(FECHAHORA, PACIENTE, NOMBRE, OBSERVACIONES, FECHAORIG, MOTIVO) values " +
                                        "('{0}',{1},'{2}','{3}','{4}','{5}')",
                                        pAgenda.FechaHora.ToString("yyyy-MM-dd H:mm:ss"),
                                        pAgenda.Paciente.ToString(),
                                        pAgenda.Nombre,
                                        pAgenda.Observa,
                                        pAgenda.FechaOrig.ToString("yyyy-MM-dd H:mm:ss"),
                                        pAgenda.Motivo),Conn); 

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
