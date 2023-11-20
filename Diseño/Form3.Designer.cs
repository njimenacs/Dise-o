namespace Diseño
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(152, 119);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Ingrese su Usuario ";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(128, 157);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(164, 26);
            this.txtusuario.TabIndex = 1;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(139, 215);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(147, 20);
            this.lblcontraseña.TabIndex = 2;
            this.lblcontraseña.Text = "Ingrese su Contraseña ";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(128, 255);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(164, 26);
            this.txtcontraseña.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(139, 315);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(155, 20);
            this.lblConfirmar.TabIndex = 4;
            this.lblConfirmar.Text = "Confirme su Contraseña ";
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Location = new System.Drawing.Point(128, 358);
            this.txtconfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(164, 26);
            this.txtconfirmar.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.Location = new System.Drawing.Point(388, 215);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(104, 49);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(653, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Formulario Ingreso";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}