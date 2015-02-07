using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaClinica
{
    public partial class frmDetalleAgenda : Form
    {
        public int Modo { get; set; } //Edicion 1 //Eliminación 2 //Alta 0
        public Agenda AgendaSeleccionada { get; set; }

        public frmDetalleAgenda(long idAgenda, int pModo)
        {
            InitializeComponent();

            Modo = pModo; 

            if (idAgenda !=-1)
            {               
                AgendaSeleccionada = AgendaDAL.ObtenerAgenda(idAgenda);
                //Carcagmos los valores seleccionados
                tbNombre.Text = AgendaSeleccionada.Nombre;
                tbObserva.Text = AgendaSeleccionada.Observa;
                dtpFechaHora.Value = AgendaSeleccionada.FechaHora;
                cbHora.Text = AgendaSeleccionada.FechaHora.Hour.ToString;

            } 
            else        
            {
                //Inicializamos los valores por defecto
                cbHora.SelectedIndex = 0;
                cbReserva.SelectedIndex = 0;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Agenda Agenda = new Agenda();
            Agenda.FechaHora = Convert.ToDateTime(dtpFechaHora.Text + ' ' + cbHora.Text);
            Agenda.FechaFin = Agenda.FechaHora.AddHours(cbReserva.SelectedIndex + 1);
            Agenda.Nombre = tbNombre.Text;
            Agenda.Observa = tbObserva.Text;
            Agenda.FechaOrig = DateTime.Now;

            int resultado = AgendaDAL.Agregar(Agenda);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }
    }
}
