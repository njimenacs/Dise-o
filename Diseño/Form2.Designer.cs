namespace Diseño
{
    partial class Form2
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
            this.grpDatospersona = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dtgDatosParqueadero = new System.Windows.Forms.DataGridView();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDirecciones = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.txtCoordenadas = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.btnDisponible = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDatospersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosParqueadero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatospersona
            // 
            this.grpDatospersona.Controls.Add(this.btnDisponible);
            this.grpDatospersona.Controls.Add(this.txtcapacidad);
            this.grpDatospersona.Controls.Add(this.lblCapacidad);
            this.grpDatospersona.Controls.Add(this.txtCoordenadas);
            this.grpDatospersona.Controls.Add(this.lblCoordenadas);
            this.grpDatospersona.Controls.Add(this.btnSalir);
            this.grpDatospersona.Controls.Add(this.btnEjecutar);
            this.grpDatospersona.Controls.Add(this.dtgDatosParqueadero);
            this.grpDatospersona.Controls.Add(this.txtciudad);
            this.grpDatospersona.Controls.Add(this.txtDireccion);
            this.grpDatospersona.Controls.Add(this.txtTipo);
            this.grpDatospersona.Controls.Add(this.txtnom);
            this.grpDatospersona.Controls.Add(this.lblCiudad);
            this.grpDatospersona.Controls.Add(this.lblTipo);
            this.grpDatospersona.Controls.Add(this.lblDirecciones);
            this.grpDatospersona.Controls.Add(this.lblNombre);
            this.grpDatospersona.Location = new System.Drawing.Point(46, 128);
            this.grpDatospersona.Name = "grpDatospersona";
            this.grpDatospersona.Size = new System.Drawing.Size(585, 293);
            this.grpDatospersona.TabIndex = 1;
            this.grpDatospersona.TabStop = false;
            this.grpDatospersona.Text = "Datos Parqueadero";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(439, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 45);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(16, 231);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(109, 45);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // dtgDatosParqueadero
            // 
            this.dtgDatosParqueadero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosParqueadero.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatosParqueadero.Location = new System.Drawing.Point(302, 20);
            this.dtgDatosParqueadero.Name = "dtgDatosParqueadero";
            this.dtgDatosParqueadero.Size = new System.Drawing.Size(240, 150);
            this.dtgDatosParqueadero.TabIndex = 2;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(97, 106);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(149, 20);
            this.txtciudad.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(97, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(149, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(97, 50);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(149, 20);
            this.txtTipo.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(97, 20);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(149, 20);
            this.txtnom.TabIndex = 1;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(21, 106);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 50);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDirecciones
            // 
            this.lblDirecciones.AutoSize = true;
            this.lblDirecciones.Location = new System.Drawing.Point(21, 80);
            this.lblDirecciones.Name = "lblDirecciones";
            this.lblDirecciones.Size = new System.Drawing.Size(63, 13);
            this.lblDirecciones.TabIndex = 1;
            this.lblDirecciones.Text = "Direcciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(222, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(261, 48);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Parking Lot";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(21, 134);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(70, 13);
            this.lblCoordenadas.TabIndex = 11;
            this.lblCoordenadas.Text = "Coordenadas";
            // 
            // txtCoordenadas
            // 
            this.txtCoordenadas.Location = new System.Drawing.Point(97, 132);
            this.txtCoordenadas.Name = "txtCoordenadas";
            this.txtCoordenadas.Size = new System.Drawing.Size(149, 20);
            this.txtCoordenadas.TabIndex = 12;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(21, 166);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(97, 163);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(149, 20);
            this.txtcapacidad.TabIndex = 14;
            // 
            // btnDisponible
            // 
            this.btnDisponible.Location = new System.Drawing.Point(245, 231);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(109, 45);
            this.btnDisponible.TabIndex = 15;
            this.btnDisponible.Text = "¿Disponible?";
            this.btnDisponible.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(643, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 93);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.grpDatospersona);
            this.Name = "Form2";
            this.Text = "Fromulario Parqueadero";
            this.grpDatospersona.ResumeLayout(false);
            this.grpDatospersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosParqueadero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatospersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dtgDatosParqueadero;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDirecciones;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCoordenadas;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Button btnDisponible;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}