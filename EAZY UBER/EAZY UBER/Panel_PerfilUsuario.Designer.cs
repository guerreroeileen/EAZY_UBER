﻿namespace EAZY_UBER
{
    partial class Panel_PerfilUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxRutas = new System.Windows.Forms.ComboBox();
            this.comboBoxVehiculos = new System.Windows.Forms.ComboBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.botonAgregarRuta = new System.Windows.Forms.Button();
            this.botonAgregarVehiculo = new System.Windows.Forms.Button();
            this.botonBuscarRuta = new System.Windows.Forms.Button();
            this.botonOfrecerCupo = new System.Windows.Forms.Button();
            this.lbInicio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSelInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rutas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vehiculo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(223, 15);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 17);
            this.lbNombre.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxRutas
            // 
            this.comboBoxRutas.FormattingEnabled = true;
            this.comboBoxRutas.Location = new System.Drawing.Point(151, 133);
            this.comboBoxRutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRutas.Name = "comboBoxRutas";
            this.comboBoxRutas.Size = new System.Drawing.Size(192, 24);
            this.comboBoxRutas.TabIndex = 7;
            this.comboBoxRutas.SelectedIndexChanged += new System.EventHandler(this.comboBoxRutas_SelectedIndexChanged);
            // 
            // comboBoxVehiculos
            // 
            this.comboBoxVehiculos.FormattingEnabled = true;
            this.comboBoxVehiculos.Location = new System.Drawing.Point(151, 164);
            this.comboBoxVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxVehiculos.Name = "comboBoxVehiculos";
            this.comboBoxVehiculos.Size = new System.Drawing.Size(192, 24);
            this.comboBoxVehiculos.TabIndex = 8;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(223, 47);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(0, 17);
            this.lbApellido.TabIndex = 9;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(223, 76);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(0, 17);
            this.lbCelular.TabIndex = 10;
            // 
            // botonAgregarRuta
            // 
            this.botonAgregarRuta.Location = new System.Drawing.Point(348, 133);
            this.botonAgregarRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAgregarRuta.Name = "botonAgregarRuta";
            this.botonAgregarRuta.Size = new System.Drawing.Size(24, 25);
            this.botonAgregarRuta.TabIndex = 11;
            this.botonAgregarRuta.Text = "+";
            this.botonAgregarRuta.UseVisualStyleBackColor = true;
            this.botonAgregarRuta.Click += new System.EventHandler(this.botonAgregarRuta_Click);
            // 
            // botonAgregarVehiculo
            // 
            this.botonAgregarVehiculo.Location = new System.Drawing.Point(347, 164);
            this.botonAgregarVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAgregarVehiculo.Name = "botonAgregarVehiculo";
            this.botonAgregarVehiculo.Size = new System.Drawing.Size(25, 25);
            this.botonAgregarVehiculo.TabIndex = 12;
            this.botonAgregarVehiculo.Text = "+";
            this.botonAgregarVehiculo.UseVisualStyleBackColor = true;
            this.botonAgregarVehiculo.Click += new System.EventHandler(this.botonAgregarVehiculo_Click);
            // 
            // botonBuscarRuta
            // 
            this.botonBuscarRuta.Location = new System.Drawing.Point(79, 206);
            this.botonBuscarRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonBuscarRuta.Name = "botonBuscarRuta";
            this.botonBuscarRuta.Size = new System.Drawing.Size(116, 28);
            this.botonBuscarRuta.TabIndex = 13;
            this.botonBuscarRuta.Text = "Buscar Ruta";
            this.botonBuscarRuta.UseVisualStyleBackColor = true;
            this.botonBuscarRuta.Click += new System.EventHandler(this.botonBuscarRuta_Click);
            // 
            // botonOfrecerCupo
            // 
            this.botonOfrecerCupo.Location = new System.Drawing.Point(227, 206);
            this.botonOfrecerCupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonOfrecerCupo.Name = "botonOfrecerCupo";
            this.botonOfrecerCupo.Size = new System.Drawing.Size(117, 28);
            this.botonOfrecerCupo.TabIndex = 14;
            this.botonOfrecerCupo.Text = "Ofrecer Cupo";
            this.botonOfrecerCupo.UseVisualStyleBackColor = true;
            this.botonOfrecerCupo.Click += new System.EventHandler(this.botonOfrecerCupo_Click);
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Location = new System.Drawing.Point(223, 102);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(0, 17);
            this.lbInicio.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inicio:";
            // 
            // buttonSelInicio
            // 
            this.buttonSelInicio.Location = new System.Drawing.Point(348, 97);
            this.buttonSelInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelInicio.Name = "buttonSelInicio";
            this.buttonSelInicio.Size = new System.Drawing.Size(24, 25);
            this.buttonSelInicio.TabIndex = 17;
            this.buttonSelInicio.Text = "+";
            this.buttonSelInicio.UseVisualStyleBackColor = true;
            this.buttonSelInicio.Click += new System.EventHandler(this.buttonSelInicio_Click);
            // 
            // Panel_PerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSelInicio);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.botonOfrecerCupo);
            this.Controls.Add(this.botonBuscarRuta);
            this.Controls.Add(this.botonAgregarVehiculo);
            this.Controls.Add(this.botonAgregarRuta);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.comboBoxVehiculos);
            this.Controls.Add(this.comboBoxRutas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Panel_PerfilUsuario";
            this.Size = new System.Drawing.Size(427, 249);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonAgregarRuta;
        private System.Windows.Forms.Button botonAgregarVehiculo;
        private System.Windows.Forms.Button botonBuscarRuta;
        private System.Windows.Forms.Button botonOfrecerCupo;
        public System.Windows.Forms.Label lbNombre;
        public System.Windows.Forms.Label lbApellido;
        public System.Windows.Forms.Label lbCelular;
        public System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button buttonSelInicio;
        public System.Windows.Forms.ComboBox comboBoxRutas;
        public System.Windows.Forms.ComboBox comboBoxVehiculos;
    }
}
