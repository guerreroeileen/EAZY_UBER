namespace EAZY_UBER
{
    partial class RegistroVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbLinea = new System.Windows.Forms.TextBox();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.lbXplaca = new System.Windows.Forms.Label();
            this.lbXMarca = new System.Windows.Forms.Label();
            this.lbXLinea = new System.Windows.Forms.Label();
            this.lbXColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa los datos del vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa del vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Linea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(128, 75);
            this.txbPlaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(98, 20);
            this.txbPlaca.TabIndex = 5;
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(128, 105);
            this.txbMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(98, 20);
            this.txbMarca.TabIndex = 6;
            // 
            // txbLinea
            // 
            this.txbLinea.Location = new System.Drawing.Point(128, 133);
            this.txbLinea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbLinea.Name = "txbLinea";
            this.txbLinea.Size = new System.Drawing.Size(98, 20);
            this.txbLinea.TabIndex = 7;
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(128, 161);
            this.txbColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(98, 20);
            this.txbColor.TabIndex = 8;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(74, 198);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(122, 24);
            this.btn_Registrar.TabIndex = 9;
            this.btn_Registrar.Text = "Registrar Vehiculo";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // lbXplaca
            // 
            this.lbXplaca.AutoSize = true;
            this.lbXplaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbXplaca.Location = new System.Drawing.Point(230, 84);
            this.lbXplaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXplaca.Name = "lbXplaca";
            this.lbXplaca.Size = new System.Drawing.Size(0, 13);
            this.lbXplaca.TabIndex = 10;
            // 
            // lbXMarca
            // 
            this.lbXMarca.AutoSize = true;
            this.lbXMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbXMarca.Location = new System.Drawing.Point(230, 107);
            this.lbXMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXMarca.Name = "lbXMarca";
            this.lbXMarca.Size = new System.Drawing.Size(0, 13);
            this.lbXMarca.TabIndex = 11;
            // 
            // lbXLinea
            // 
            this.lbXLinea.AutoSize = true;
            this.lbXLinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbXLinea.Location = new System.Drawing.Point(230, 133);
            this.lbXLinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXLinea.Name = "lbXLinea";
            this.lbXLinea.Size = new System.Drawing.Size(0, 13);
            this.lbXLinea.TabIndex = 12;
            // 
            // lbXColor
            // 
            this.lbXColor.AutoSize = true;
            this.lbXColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbXColor.Location = new System.Drawing.Point(230, 161);
            this.lbXColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXColor.Name = "lbXColor";
            this.lbXColor.Size = new System.Drawing.Size(0, 13);
            this.lbXColor.TabIndex = 13;
            // 
            // RegistroVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 252);
            this.Controls.Add(this.lbXColor);
            this.Controls.Add(this.lbXLinea);
            this.Controls.Add(this.lbXMarca);
            this.Controls.Add(this.lbXplaca);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txbColor);
            this.Controls.Add(this.txbLinea);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroVehiculo";
            this.Text = "RegistroVehiculo";
            this.Load += new System.EventHandler(this.RegistroVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbXplaca;
        private System.Windows.Forms.Label lbXMarca;
        private System.Windows.Forms.Label lbXLinea;
        private System.Windows.Forms.Label lbXColor;
        public System.Windows.Forms.Button btn_Registrar;
        public System.Windows.Forms.TextBox txbPlaca;
        public System.Windows.Forms.TextBox txbMarca;
        public System.Windows.Forms.TextBox txbLinea;
        public System.Windows.Forms.TextBox txbColor;
    }
}