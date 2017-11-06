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
            this.btnAceptar.Location = new System.Drawing.Point(406, 309);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnDeclinar
            // 
            this.btnDeclinar.Location = new System.Drawing.Point(315, 309);
            this.btnDeclinar.Name = "btnDeclinar";
            this.btnDeclinar.Size = new System.Drawing.Size(75, 23);
            this.btnDeclinar.TabIndex = 1;
            this.btnDeclinar.Text = "Declinar";
            this.btnDeclinar.UseVisualStyleBackColor = true;
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(38, 46);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(135, 212);
            this.listBoxNotificaciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notificaciones";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(194, 46);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(287, 212);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(223, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tipo1
            // 
            this.tipo1.AutoSize = true;
            this.tipo1.Location = new System.Drawing.Point(38, 264);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(80, 17);
            this.tipo1.TabIndex = 6;
            this.tipo1.Text = "checkBox1";
            this.tipo1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(38, 287);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(38, 310);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 344);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNotificaciones);
            this.Controls.Add(this.btnDeclinar);
            this.Controls.Add(this.btnAceptar);
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