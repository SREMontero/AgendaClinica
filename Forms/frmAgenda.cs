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

        public Agenda AgendaSeleccionada { get; set; }
        
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaClinicaDataSet1.Agenda' table. You can move, or remove it, as needed.
            //this.agendaTableAdapter.Fill(this.agendaClinicaDataSet1.Agenda);
            // TODO: This line of code loads data into the 'agendaClinicaDataSet.Agenda' table. You can move, or remove it, as needed.
            //this.agendaTableAdapter.Fill(this.agendaClinicaDataSet.Agenda);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerDetalle(Int64 idAgenda)
        {
            if (idAgenda == -1)
            { 
                (new frmDetalleAgenda(idAgenda,0)).Show();
            } else
            {
                (new frmDetalleAgenda(idAgenda, 1)).Show();
            }
            if (idAgenda == -2)
            {
                (new frmDetalleAgenda(idAgenda, 2)).Show();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 idAgenda = (Int64)dgvAgenda.Rows[e.RowIndex].Cells[0].Value;
            VerDetalle(idAgenda);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = AgendaDAL.BuscarAgenda(dtpFecha.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VerDetalle(-1);
        }

        private void frmAgenda_Shown(object sender, EventArgs e)
        {
            dgvAgenda.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.SelectedRows.Count == 1) 
            {
                Int64 Id = Convert.ToInt64(dgvAgenda.CurrentRow.Cells[0].Value);
                
            }
        }
    }
}
