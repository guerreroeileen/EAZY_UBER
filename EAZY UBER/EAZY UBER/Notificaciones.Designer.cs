namespace EAZY_UBER
{
    partial class Notificaciones
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDeclinar = new System.Windows.Forms.Button();
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tipo1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(541, 380);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnDeclinar
            // 
            this.btnDeclinar.Location = new System.Drawing.Point(420, 380);
            this.btnDeclinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeclinar.Name = "btnDeclinar";
            this.btnDeclinar.Size = new System.Drawing.Size(100, 28);
            this.btnDeclinar.TabIndex = 1;
            this.btnDeclinar.Text = "Declinar";
            this.btnDeclinar.UseVisualStyleBackColor = true;
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.ItemHeight = 16;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(51, 57);
            this.listBoxNotificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(179, 260);
            this.listBoxNotificaciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notificaciones";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(259, 57);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(61, 17);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(297, 380);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tipo1
            // 
            this.tipo1.AutoSize = true;
            this.tipo1.Location = new System.Drawing.Point(51, 325);
            this.tipo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(98, 21);
            this.tipo1.TabIndex = 6;
            this.tipo1.Text = "checkBox1";
            this.tipo1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(51, 353);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(51, 382);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 423);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNotificaciones);
            this.Controls.Add(this.btnDeclinar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox tipo1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.ListBox listBoxNotificaciones;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnDeclinar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Label lblMensaje;
    }
}