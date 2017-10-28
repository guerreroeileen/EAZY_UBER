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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbxUsuario = new System.Windows.Forms.PictureBox();
            this.btnSolicitarCupo = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.lbxUsuarios = new System.Windows.Forms.ListBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(17, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(255, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // picbxUsuario
            // 
            this.picbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxUsuario.Location = new System.Drawing.Point(7, 21);
            this.picbxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxUsuario.Name = "picbxUsuario";
            this.picbxUsuario.Size = new System.Drawing.Size(89, 116);
            this.picbxUsuario.TabIndex = 0;
            this.picbxUsuario.TabStop = false;
            // 
            // btnSolicitarCupo
            // 
            this.btnSolicitarCupo.Location = new System.Drawing.Point(279, 164);
            this.btnSolicitarCupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolicitarCupo.Name = "btnSolicitarCupo";
            this.btnSolicitarCupo.Size = new System.Drawing.Size(175, 28);
            this.btnSolicitarCupo.TabIndex = 13;
            this.btnSolicitarCupo.Text = "Solicitar Cupo";
            this.btnSolicitarCupo.UseVisualStyleBackColor = true;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(279, 199);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(175, 28);
            this.btnDescartar.TabIndex = 12;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            // 
            // lbxUsuarios
            // 
            this.lbxUsuarios.FormattingEnabled = true;
            this.lbxUsuarios.ItemHeight = 16;
            this.lbxUsuarios.Location = new System.Drawing.Point(279, 23);
            this.lbxUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxUsuarios.Name = "lbxUsuarios";
            this.lbxUsuarios.Size = new System.Drawing.Size(173, 132);
            this.lbxUsuarios.TabIndex = 11;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(169, 17);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 17);
            this.lbNombre.TabIndex = 3;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(169, 37);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(0, 17);
            this.lbApellido.TabIndex = 4;
            // 
            // panel_UsuarioRecomendado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSolicitarCupo);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.lbxUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "panel_UsuarioRecomendado";
            this.Size = new System.Drawing.Size(476, 326);
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
        public System.Windows.Forms.Button btnSolicitarCupo;
        public System.Windows.Forms.Button btnDescartar;
        public System.Windows.Forms.ListBox lbxUsuarios;
        public System.Windows.Forms.Label lbApellido;
        public System.Windows.Forms.Label lbNombre;
    }
}
