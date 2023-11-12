namespace Diseño
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatospersona = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtIdentificacio = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.grpDatosTipopersona = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textAdministrador = new System.Windows.Forms.TextBox();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.dtgDatospersona = new System.Windows.Forms.DataGridView();
            this.dtgDatoTipopersona = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatospersona.SuspendLayout();
            this.grpDatosTipopersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatospersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatoTipopersona)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatospersona
            // 
            this.grpDatospersona.Controls.Add(this.btnSalir);
            this.grpDatospersona.Controls.Add(this.btnEjecutar);
            this.grpDatospersona.Controls.Add(this.dtgDatospersona);
            this.grpDatospersona.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatospersona.Controls.Add(this.txtEmail);
            this.grpDatospersona.Controls.Add(this.txtNombre);
            this.grpDatospersona.Controls.Add(this.txtTelefono);
            this.grpDatospersona.Controls.Add(this.txtIdentificacio);
            this.grpDatospersona.Controls.Add(this.lblFechaNacimiento);
            this.grpDatospersona.Controls.Add(this.lblEmail);
            this.grpDatospersona.Controls.Add(this.lblTelefono);
            this.grpDatospersona.Controls.Add(this.lblNombre);
            this.grpDatospersona.Controls.Add(this.lblIdentificacion);
            this.grpDatospersona.Location = new System.Drawing.Point(23, 19);
            this.grpDatospersona.Name = "grpDatospersona";
            this.grpDatospersona.Size = new System.Drawing.Size(585, 218);
            this.grpDatospersona.TabIndex = 0;
            this.grpDatospersona.TabStop = false;
            this.grpDatospersona.Text = "Datos de persona";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(126, 135);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 50);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtIdentificacio
            // 
            this.txtIdentificacio.Location = new System.Drawing.Point(97, 20);
            this.txtIdentificacio.Name = "txtIdentificacio";
            this.txtIdentificacio.Size = new System.Drawing.Size(149, 20);
            this.txtIdentificacio.TabIndex = 1;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 135);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(90, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "FechaNacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 50);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(21, 20);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificacion";
            this.lblIdentificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpDatosTipopersona
            // 
            this.grpDatosTipopersona.Controls.Add(this.dtgDatoTipopersona);
            this.grpDatosTipopersona.Controls.Add(this.btnIniciar);
            this.grpDatosTipopersona.Controls.Add(this.txtCliente);
            this.grpDatosTipopersona.Controls.Add(this.txtColaborador);
            this.grpDatosTipopersona.Controls.Add(this.textAdministrador);
            this.grpDatosTipopersona.Controls.Add(this.lblCliente);
            this.grpDatosTipopersona.Controls.Add(this.lblColaborador);
            this.grpDatosTipopersona.Controls.Add(this.lblAdministrador);
            this.grpDatosTipopersona.Controls.Add(this.lblClave);
            this.grpDatosTipopersona.Controls.Add(this.txtClave);
            this.grpDatosTipopersona.Location = new System.Drawing.Point(23, 257);
            this.grpDatosTipopersona.Name = "grpDatosTipopersona";
            this.grpDatosTipopersona.Size = new System.Drawing.Size(602, 203);
            this.grpDatosTipopersona.TabIndex = 1;
            this.grpDatosTipopersona.TabStop = false;
            this.grpDatosTipopersona.Text = "Tipo de persona";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(103, 123);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(140, 20);
            this.txtClave.TabIndex = 11;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(58, 130);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 12;
            this.lblClave.Text = "Clave";
            this.lblClave.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Location = new System.Drawing.Point(58, 29);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lblAdministrador.TabIndex = 9;
            this.lblAdministrador.Text = "Administrador";
            this.lblAdministrador.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Location = new System.Drawing.Point(58, 55);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(64, 13);
            this.lblColaborador.TabIndex = 13;
            this.lblColaborador.Text = "Colaborador";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(58, 83);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label11_Click);
            // 
            // textAdministrador
            // 
            this.textAdministrador.Location = new System.Drawing.Point(134, 26);
            this.textAdministrador.Name = "textAdministrador";
            this.textAdministrador.Size = new System.Drawing.Size(100, 20);
            this.textAdministrador.TabIndex = 15;
            this.textAdministrador.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(134, 53);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(100, 20);
            this.txtColaborador.TabIndex = 16;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(134, 83);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 17;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(21, 187);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(45, 160);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // dtgDatospersona
            // 
            this.dtgDatospersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatospersona.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatospersona.Location = new System.Drawing.Point(302, 20);
            this.dtgDatospersona.Name = "dtgDatospersona";
            this.dtgDatospersona.Size = new System.Drawing.Size(240, 150);
            this.dtgDatospersona.TabIndex = 2;
            this.dtgDatospersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtgDatoTipopersona
            // 
            this.dtgDatoTipopersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatoTipopersona.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatoTipopersona.Location = new System.Drawing.Point(302, 9);
            this.dtgDatoTipopersona.Name = "dtgDatoTipopersona";
            this.dtgDatoTipopersona.Size = new System.Drawing.Size(240, 150);
            this.dtgDatoTipopersona.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(467, 187);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.grpDatosTipopersona);
            this.Controls.Add(this.grpDatospersona);
            this.Name = "Form1";
            this.Text = "FormularioPersona";
            this.grpDatospersona.ResumeLayout(false);
            this.grpDatospersona.PerformLayout();
            this.grpDatosTipopersona.ResumeLayout(false);
            this.grpDatosTipopersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatospersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatoTipopersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatospersona;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdentificacio;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox grpDatosTipopersona;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.TextBox textAdministrador;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView dtgDatospersona;
        private System.Windows.Forms.DataGridView dtgDatoTipopersona;
        private System.Windows.Forms.Button btnSalir;
    }
}

