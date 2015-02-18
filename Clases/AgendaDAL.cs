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
                string Consulta = string.Format("Insert into Agenda " +
                                        "(FECHAHORA, FECHAFIN, PACIENTE, NOMBRE, OBSERVACIONES, FECHAORIG, MOTIVO) values " +
                                        "('{0}','{1}',{2},'{3}','{4}','{5}','{6}')",
                                        pAgenda.FechaHora.ToString("yyyy-dd-MM H:mm:ss"),
                                        pAgenda.FechaFin.ToString("yyyy-dd-MM H:mm:ss"),
                                        pAgenda.Paciente.ToString(),
                                        pAgenda.Nombre,
                                        pAgenda.Observa,
                                        pAgenda.FechaOrig.ToString("yyyy-MM-dd H:mm:ss"),
                                        pAgenda.Motivo);
                
                SqlCommand Comando = new SqlCommand(Consulta,Conn); 

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Editar(Agenda pAgenda)
        {
            int retorno = 0;


            return retorno;
        }

        public static List<Agenda> BuscarAgenda(DateTime pFecha) 
        {
            List<Agenda> Lista = new List<Agenda>();

            DateTime lcFechaInicio = pFecha.Date;
            DateTime lcFechaFin = pFecha.Date;
            lcFechaInicio = lcFechaInicio.AddHours(7);
            lcFechaFin = lcFechaFin.AddHours(22);


            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "SELECT IDAGENDA, FECHAHORA, FECHAFIN, PACIENTE, NOMBRE, OBSERVACIONES,FECHAORIG, MOTIVO FROM " +
                    "AGENDA WHERE FECHAHORA BETWEEN '{0}' AND '{1}'",
                    lcFechaInicio.ToString("yyyy-dd-MM H:mm:ss"),
                    lcFechaFin.ToString("yyyy-dd-MM H:mm:ss")),conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) 
                {
                    Agenda pAgenda = new Agenda();

                    pAgenda.IdAgenda = reader.GetInt64(0);
                    pAgenda.FechaHora = reader.GetDateTime(1);
                    pAgenda.FechaFin = reader.GetDateTime(2);
                    pAgenda.Paciente = reader.GetInt32(3);
                    pAgenda.Nombre = reader.GetString(4);
                    pAgenda.Observa = reader.GetString(5);
                    pAgenda.FechaOrig = reader.GetDateTime(2);
                    pAgenda.Motivo = reader.GetString(7);

                    Lista.Add(pAgenda);                   
                }

                conexion.Close();
                return Lista;
            }
        }

        public static Agenda ObtenerAgenda(Int64 pIDAgenda)
        {
            Agenda pAgenda = new Agenda();
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "SELECT IDAGENDA, FECHAHORA, FECHAFIN, PACIENTE, NOMBRE, OBSERVACIONES,FECHAORIG, MOTIVO FROM " +
                    "AGENDA WHERE IDAGENDA ={0}",
                    pIDAgenda.ToString()), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pAgenda.IdAgenda = reader.GetInt64(0);
                    pAgenda.FechaHora = reader.GetDateTime(1);
                    pAgenda.FechaFin = reader.GetDateTime(2);
                    pAgenda.Paciente = reader.GetInt32(3);
                    pAgenda.Nombre = reader.GetString(4);
                    pAgenda.Observa = reader.GetString(5);
                    pAgenda.FechaOrig = reader.GetDateTime(2);
                    pAgenda.Motivo = reader.GetString(7);
                }

                conexion.Close();
                return pAgenda;
            }
        }

    }
}
