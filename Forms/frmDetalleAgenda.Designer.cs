namespace AgendaClinica
{
    partial class frmDetalleAgenda
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
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbObserva = new System.Windows.Forms.TextBox();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReserva = new System.Windows.Forms.ComboBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHora.Location = new System.Drawing.Point(120, 87);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.ShowUpDown = true;
            this.dtpFechaHora.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaHora.TabIndex = 0;
            this.dtpFechaHora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha y Hora:";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(20, 246);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(425, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre y apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Observaciones";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(120, 118);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(362, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbObserva
            // 
            this.tbObserva.Location = new System.Drawing.Point(120, 151);
            this.tbObserva.Multiline = true;
            this.tbObserva.Name = "tbObserva";
            this.tbObserva.Size = new System.Drawing.Size(380, 89);
            this.tbObserva.TabIndex = 7;
            // 
            // cbHora
            // 
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.cbHora.Location = new System.Drawing.Point(219, 86);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(83, 21);
            this.cbHora.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reserva:";
            // 
            // cbReserva
            // 
            this.cbReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReserva.FormattingEnabled = true;
            this.cbReserva.Items.AddRange(new object[] {
            "1 hora",
            "2 horas",
            "3 horas"});
            this.cbReserva.Location = new System.Drawing.Point(378, 86);
            this.cbReserva.Name = "cbReserva";
            this.cbReserva.Size = new System.Drawing.Size(122, 21);
            this.cbReserva.TabIndex = 10;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.Location = new System.Drawing.Point(473, 116);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(27, 23);
            this.btBuscaCliente.TabIndex = 11;
            this.btBuscaCliente.Text = "...";
            this.btBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 67);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(57, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reservar Cita";
            // 
            // frmDetalleAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBuscaCliente);
            this.Controls.Add(this.cbReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.tbObserva);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetalleAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar Cita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbObserva;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReserva;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}