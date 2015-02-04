namespace AgendaClinica
{
    partial class frmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.agendaClinicaDataSet = new AgendaClinica.AgendaClinicaDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.agendaTableAdapter = new AgendaClinica.AgendaClinicaDataSetTableAdapters.AgendaTableAdapter();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.iDAGENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAHORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACIONESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAORIGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaClinicaDataSet1 = new AgendaClinica.AgendaClinicaDataSet();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agendaClinicaDataSet
            // 
            this.agendaClinicaDataSet.DataSetName = "AgendaClinicaDataSet";
            this.agendaClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 306);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AutoGenerateColumns = false;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAGENDADataGridViewTextBoxColumn,
            this.fECHAHORADataGridViewTextBoxColumn,
            this.pACIENTEDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.oBSERVACIONESDataGridViewTextBoxColumn,
            this.fECHAORIGDataGridViewTextBoxColumn,
            this.mOTIVODataGridViewTextBoxColumn});
            this.dgvAgenda.DataSource = this.agendaBindingSource1;
            this.dgvAgenda.Location = new System.Drawing.Point(32, 41);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(862, 246);
            this.dgvAgenda.TabIndex = 4;
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDAGENDADataGridViewTextBoxColumn
            // 
            this.iDAGENDADataGridViewTextBoxColumn.DataPropertyName = "IDAGENDA";
            this.iDAGENDADataGridViewTextBoxColumn.HeaderText = "IDAGENDA";
            this.iDAGENDADataGridViewTextBoxColumn.Name = "iDAGENDADataGridViewTextBoxColumn";
            this.iDAGENDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAHORADataGridViewTextBoxColumn
            // 
            this.fECHAHORADataGridViewTextBoxColumn.DataPropertyName = "FECHAHORA";
            this.fECHAHORADataGridViewTextBoxColumn.HeaderText = "FECHAHORA";
            this.fECHAHORADataGridViewTextBoxColumn.Name = "fECHAHORADataGridViewTextBoxColumn";
            // 
            // pACIENTEDataGridViewTextBoxColumn
            // 
            this.pACIENTEDataGridViewTextBoxColumn.DataPropertyName = "PACIENTE";
            this.pACIENTEDataGridViewTextBoxColumn.HeaderText = "PACIENTE";
            this.pACIENTEDataGridViewTextBoxColumn.Name = "pACIENTEDataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // oBSERVACIONESDataGridViewTextBoxColumn
            // 
            this.oBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES";
            this.oBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES";
            this.oBSERVACIONESDataGridViewTextBoxColumn.Name = "oBSERVACIONESDataGridViewTextBoxColumn";
            // 
            // fECHAORIGDataGridViewTextBoxColumn
            // 
            this.fECHAORIGDataGridViewTextBoxColumn.DataPropertyName = "FECHAORIG";
            this.fECHAORIGDataGridViewTextBoxColumn.HeaderText = "FECHAORIG";
            this.fECHAORIGDataGridViewTextBoxColumn.Name = "fECHAORIGDataGridViewTextBoxColumn";
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            // 
            // agendaBindingSource1
            // 
            this.agendaBindingSource1.DataMember = "Agenda";
            this.agendaBindingSource1.DataSource = this.agendaClinicaDataSet1;
            // 
            // agendaClinicaDataSet1
            // 
            this.agendaClinicaDataSet1.DataSetName = "AgendaClinicaDataSet";
            this.agendaClinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 367);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AgendaClinicaDataSet agendaClinicaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private AgendaClinicaDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private AgendaClinicaDataSet agendaClinicaDataSet1;
        private System.Windows.Forms.BindingSource agendaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAGENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAHORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pACIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAORIGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
    }
}

