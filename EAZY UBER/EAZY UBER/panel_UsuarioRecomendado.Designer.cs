namespace EAZY_UBER
{
    partial class panel_UsuarioRecomendado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbxUsuario = new System.Windows.Forms.PictureBox();
            this.btnOfrecerCupo = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.lbxUsuarios = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbApellido);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picbxUsuario);
            this.groupBox1.Location = new System.Drawing.Point(13, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(191, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(127, 30);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(0, 13);
            this.lbApellido.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(127, 14);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 13);
            this.lbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // picbxUsuario
            // 
            this.picbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxUsuario.Location = new System.Drawing.Point(5, 17);
            this.picbxUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbxUsuario.Name = "picbxUsuario";
            this.picbxUsuario.Size = new System.Drawing.Size(67, 95);
            this.picbxUsuario.TabIndex = 0;
            this.picbxUsuario.TabStop = false;
            // 
            // btnOfrecerCupo
            // 
            this.btnOfrecerCupo.Location = new System.Drawing.Point(209, 133);
            this.btnOfrecerCupo.Name = "btnOfrecerCupo";
            this.btnOfrecerCupo.Size = new System.Drawing.Size(131, 23);
            this.btnOfrecerCupo.TabIndex = 13;
            this.btnOfrecerCupo.Text = "Ofrecer Cupo";
            this.btnOfrecerCupo.UseVisualStyleBackColor = true;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(209, 162);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(131, 23);
            this.btnDescartar.TabIndex = 12;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            // 
            // lbxUsuarios
            // 
            this.lbxUsuarios.FormattingEnabled = true;
            this.lbxUsuarios.Location = new System.Drawing.Point(209, 19);
            this.lbxUsuarios.Name = "lbxUsuarios";
            this.lbxUsuarios.Size = new System.Drawing.Size(131, 108);
            this.lbxUsuarios.TabIndex = 11;
            // 
            // panel_UsuarioRecomendado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOfrecerCupo);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.lbxUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "panel_UsuarioRecomendado";
            this.Size = new System.Drawing.Size(357, 265);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbxUsuario;
        public System.Windows.Forms.Button btnOfrecerCupo;
        public System.Windows.Forms.Button btnDescartar;
        public System.Windows.Forms.ListBox lbxUsuarios;
        public System.Windows.Forms.Label lbApellido;
        public System.Windows.Forms.Label lbNombre;
    }
}
