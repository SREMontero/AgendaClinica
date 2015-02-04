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
        long idAgenda;

        public frmDetalleAgenda(long idAgenda)
        {
            InitializeComponent();
            this.idAgenda = idAgenda;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda Agenda = new Agenda();
            Agenda.FechaHora = dtpFechaHora.Value;
            Agenda.Nombre = tbNombre.Text;
            Agenda.Observa = tbObserva.Text;
            Agenda.FechaOrig = DateTime.Now;
           
            int resultado = AgendaDAL.Agregar(Agenda);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos guardados",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
