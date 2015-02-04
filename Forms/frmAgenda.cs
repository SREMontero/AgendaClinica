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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaClinicaDataSet1.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.agendaClinicaDataSet1.Agenda);
            // TODO: This line of code loads data into the 'agendaClinicaDataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.agendaClinicaDataSet.Agenda);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerDetalle(Int64 idAgenda)
        {
            (new frmDetalleAgenda(idAgenda)).Show();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 idAgenda = (Int64)dgvAgenda.Rows[e.RowIndex].Cells[0].Value;
            VerDetalle(idAgenda);
        }
    }
}
