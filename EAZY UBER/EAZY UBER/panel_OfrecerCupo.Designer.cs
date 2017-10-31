namespace EAZY_UBER
{
    partial class panel_OfrecerCupo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTarifa = new System.Windows.Forms.TextBox();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.errorHora = new System.Windows.Forms.Label();
            this.errorTarifa = new System.Windows.Forms.Label();
            this.errorFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCupos = new System.Windows.Forms.TextBox();
            this.errorCupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "\"hh:mm\"";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarifa";
            // 
            // txbTarifa
            // 
            this.txbTarifa.Location = new System.Drawing.Point(73, 120);
            this.txbTarifa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTarifa.Name = "txbTarifa";
            this.txbTarifa.Size = new System.Drawing.Size(131, 22);
            this.txbTarifa.TabIndex = 3;
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(138, 163);
            this.botonConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(121, 28);
            this.botonConfirmar.TabIndex = 5;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ofrecer Cupos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(73, 32);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Selecciona el vehiculo y la ruta desde tu perfil";
            // 
            // errorHora
            // 
            this.errorHora.AutoSize = true;
            this.errorHora.ForeColor = System.Drawing.Color.Red;
            this.errorHora.Location = new System.Drawing.Point(210, 68);
            this.errorHora.Name = "errorHora";
            this.errorHora.Size = new System.Drawing.Size(17, 17);
            this.errorHora.TabIndex = 11;
            this.errorHora.Text = "X";
            // 
            // errorTarifa
            // 
            this.errorTarifa.AutoSize = true;
            this.errorTarifa.ForeColor = System.Drawing.Color.Red;
            this.errorTarifa.Location = new System.Drawing.Point(210, 120);
            this.errorTarifa.Name = "errorTarifa";
            this.errorTarifa.Size = new System.Drawing.Size(17, 17);
            this.errorTarifa.TabIndex = 12;
            this.errorTarifa.Text = "X";
            // 
            // errorFecha
            // 
            this.errorFecha.AutoSize = true;
            this.errorFecha.ForeColor = System.Drawing.Color.Red;
            this.errorFecha.Location = new System.Drawing.Point(345, 37);
            this.errorFecha.Name = "errorFecha";
            this.errorFecha.Size = new System.Drawing.Size(17, 17);
            this.errorFecha.TabIndex = 13;
            this.errorFecha.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cupos";
            // 
            // txbCupos
            // 
            this.txbCupos.Location = new System.Drawing.Point(73, 93);
            this.txbCupos.Name = "txbCupos";
            this.txbCupos.Size = new System.Drawing.Size(131, 22);
            this.txbCupos.TabIndex = 15;
            // 
            // errorCupo
            // 
            this.errorCupo.AutoSize = true;
            this.errorCupo.ForeColor = System.Drawing.Color.Red;
            this.errorCupo.Location = new System.Drawing.Point(210, 98);
            this.errorCupo.Name = "errorCupo";
            this.errorCupo.Size = new System.Drawing.Size(17, 17);
            this.errorCupo.TabIndex = 16;
            this.errorCupo.Text = "X";
            // 
            // panel_OfrecerCupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorCupo);
            this.Controls.Add(this.txbCupos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorFecha);
            this.Controls.Add(this.errorTarifa);
            this.Controls.Add(this.errorHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.txbTarifa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "panel_OfrecerCupo";
            this.Size = new System.Drawing.Size(421, 201);
            this.Load += new System.EventHandler(this.panel_OfrecerCupo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbCupos;
        public System.Windows.Forms.Label errorCupo;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txbTarifa;
        public System.Windows.Forms.Button botonConfirmar;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label errorHora;
        public System.Windows.Forms.Label errorTarifa;
        public System.Windows.Forms.Label errorFecha;
    }
}
