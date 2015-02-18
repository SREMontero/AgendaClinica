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
        public int Modo { get; set; } //Alta 0 //Edicion 1 //Eliminación 2 
        public Agenda AgendaSeleccionada { get; set; }

        public frmDetalleAgenda(long idAgenda, int pModo)
        {
            InitializeComponent();

            int indiceHora;

            Modo = pModo; 

            if (idAgenda !=-1)
            {               
                AgendaSeleccionada = AgendaDAL.ObtenerAgenda(idAgenda);
                //Carcagmos los valores seleccionados
                tbNombre.Text = AgendaSeleccionada.Nombre;
                tbObserva.Text = AgendaSeleccionada.Observa;
                dtpFechaHora.Value = AgendaSeleccionada.FechaHora;

                indiceHora = 0;

                //cbHora.SelectedText = AgendaSeleccionada.FechaHora.ToString("HH:mm");

                //Cargamos la hora en el combo.
                for (indiceHora = 0; indiceHora <= (cbHora.Items.Count - 1); indiceHora++)
                {
                    cbHora.SelectedIndex = indiceHora;
                    if (AgendaSeleccionada.FechaHora.ToString("HH:mm")== cbHora.Text) 
                    {
                        break;
                    }
                    cbHora.SelectedIndex = 0;
                }

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
