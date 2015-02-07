using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica
{
    public class Agenda
    {
        /*Propiedades para cada campo */
        public Int64    IdAgenda    { get; set; }
        public DateTime FechaHora   { get; set; }
        public DateTime FechaFin    { get; set; }
        public int      Paciente    { get; set; }
        public string   Nombre      { get; set; }
        public string   Observa     { get; set; }
        public DateTime FechaOrig   { get; set; }
        public string   Motivo      { get; set; }

        public Agenda()
        {

        }

        public Agenda(  Int64 pIdAgenda, 
                        DateTime pFechaHora,            
                        DateTime pFechaFin,
                        int pPaciente,
                        string pNombre,
                        string pObserva,
                        DateTime pFechaOrig,
                        string pMotivo)
        {
            this.IdAgenda = pIdAgenda;
            this.FechaHora = pFechaHora;
            this.FechaFin = pFechaFin;
            this.Paciente = pPaciente;
            this.Nombre = pNombre;
            this.Observa = pObserva;
            this.FechaOrig = pFechaOrig;
            this.Motivo = pMotivo;
        }
    }
}
