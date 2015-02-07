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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // agendaClinicaDataSet
            // 
            this.agendaClinicaDataSet.DataSetName = "AgendaClinicaDataSet";
            this.agendaClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 392);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 392);
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
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
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
            this.dgvAgenda.Location = new System.Drawing.Point(12, 98);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.Size = new System.Drawing.Size(944, 269);
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
            this.iDAGENDADataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAHORADataGridViewTextBoxColumn
            // 
            this.fECHAHORADataGridViewTextBoxColumn.DataPropertyName = "FECHAHORA";
            this.fECHAHORADataGridViewTextBoxColumn.HeaderText = "FECHAHORA";
            this.fECHAHORADataGridViewTextBoxColumn.Name = "fECHAHORADataGridViewTextBoxColumn";
            this.fECHAHORADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pACIENTEDataGridViewTextBoxColumn
            // 
            this.pACIENTEDataGridViewTextBoxColumn.DataPropertyName = "PACIENTE";
            this.pACIENTEDataGridViewTextBoxColumn.HeaderText = "PACIENTE";
            this.pACIENTEDataGridViewTextBoxColumn.Name = "pACIENTEDataGridViewTextBoxColumn";
            this.pACIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oBSERVACIONESDataGridViewTextBoxColumn
            // 
            this.oBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES";
            this.oBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES";
            this.oBSERVACIONESDataGridViewTextBoxColumn.Name = "oBSERVACIONESDataGridViewTextBoxColumn";
            this.oBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAORIGDataGridViewTextBoxColumn
            // 
            this.fECHAORIGDataGridViewTextBoxColumn.DataPropertyName = "FECHAORIG";
            this.fECHAORIGDataGridViewTextBoxColumn.HeaderText = "FECHAORIG";
            this.fECHAORIGDataGridViewTextBoxColumn.Name = "fECHAORIGDataGridViewTextBoxColumn";
            this.fECHAORIGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            this.mOTIVODataGridViewTextBoxColumn.ReadOnly = true;
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
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 72);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(221, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 49);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(19, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "Agenda de Citas";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.Shown += new System.EventHandler(this.frmAgenda_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaClinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAGENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAHORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pACIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAORIGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

