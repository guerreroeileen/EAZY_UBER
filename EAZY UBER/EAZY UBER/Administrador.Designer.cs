﻿namespace EAZY_UBER
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.listUsuariosRegistrados = new System.Windows.Forms.ListBox();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuariosRegistrados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAutosRegistrados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRecorridosRegistrados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsuariosAuto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUsuariosSinAuto = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.generarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUsuariosRegistrados
            // 
            this.listUsuariosRegistrados.FormattingEnabled = true;
            this.listUsuariosRegistrados.Location = new System.Drawing.Point(12, 83);
            this.listUsuariosRegistrados.Name = "listUsuariosRegistrados";
            this.listUsuariosRegistrados.Size = new System.Drawing.Size(145, 251);
            this.listUsuariosRegistrados.TabIndex = 0;
            this.listUsuariosRegistrados.SelectedIndexChanged += new System.EventHandler(this.listUsuariosRegistrados_SelectedIndexChanged);
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(12, 58);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(107, 13);
            this.labelUsuarios.TabIndex = 1;
            this.labelUsuarios.Text = "Usuarios Registrados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuarios Registrados";
            // 
            // labelUsuariosRegistrados
            // 
            this.labelUsuariosRegistrados.AutoSize = true;
            this.labelUsuariosRegistrados.Location = new System.Drawing.Point(577, 83);
            this.labelUsuariosRegistrados.Name = "labelUsuariosRegistrados";
            this.labelUsuariosRegistrados.Size = new System.Drawing.Size(13, 13);
            this.labelUsuariosRegistrados.TabIndex = 5;
            this.labelUsuariosRegistrados.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autos Registrados";
            // 
            // labelAutosRegistrados
            // 
            this.labelAutosRegistrados.AutoSize = true;
            this.labelAutosRegistrados.Location = new System.Drawing.Point(577, 106);
            this.labelAutosRegistrados.Name = "labelAutosRegistrados";
            this.labelAutosRegistrados.Size = new System.Drawing.Size(13, 13);
            this.labelAutosRegistrados.TabIndex = 7;
            this.labelAutosRegistrados.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recorridos Registrados";
            // 
            // labelRecorridosRegistrados
            // 
            this.labelRecorridosRegistrados.AutoSize = true;
            this.labelRecorridosRegistrados.Location = new System.Drawing.Point(578, 131);
            this.labelRecorridosRegistrados.Name = "labelRecorridosRegistrados";
            this.labelRecorridosRegistrados.Size = new System.Drawing.Size(13, 13);
            this.labelRecorridosRegistrados.TabIndex = 9;
            this.labelRecorridosRegistrados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuarios con Auto";
            // 
            // labelUsuariosAuto
            // 
            this.labelUsuariosAuto.AutoSize = true;
            this.labelUsuariosAuto.Location = new System.Drawing.Point(578, 154);
            this.labelUsuariosAuto.Name = "labelUsuariosAuto";
            this.labelUsuariosAuto.Size = new System.Drawing.Size(13, 13);
            this.labelUsuariosAuto.TabIndex = 11;
            this.labelUsuariosAuto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuarios sin Auto";
            // 
            // labelUsuariosSinAuto
            // 
            this.labelUsuariosSinAuto.AutoSize = true;
            this.labelUsuariosSinAuto.Location = new System.Drawing.Point(579, 180);
            this.labelUsuariosSinAuto.Name = "labelUsuariosSinAuto";
            this.labelUsuariosSinAuto.Size = new System.Drawing.Size(13, 13);
            this.labelUsuariosSinAuto.TabIndex = 13;
            this.labelUsuariosSinAuto.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(662, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarUsuariosToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // generarUsuariosToolStripMenuItem
            // 
            this.generarUsuariosToolStripMenuItem.Name = "generarUsuariosToolStripMenuItem";
            this.generarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.generarUsuariosToolStripMenuItem.Text = "Generar Usuarios";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Volver a Inicio";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 339);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelUsuariosSinAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelUsuariosAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRecorridosRegistrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAutosRegistrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsuariosRegistrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUsuarios);
            this.Controls.Add(this.listUsuariosRegistrados);
            this.Name = "Administrador";
            this.Text = "Panel de Administrador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listUsuariosRegistrados;
        public System.Windows.Forms.Label labelUsuariosRegistrados;
        public System.Windows.Forms.Label labelAutosRegistrados;
        public System.Windows.Forms.Label labelRecorridosRegistrados;
        public System.Windows.Forms.Label labelUsuariosAuto;
        public System.Windows.Forms.Label labelUsuariosSinAuto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem generarUsuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}