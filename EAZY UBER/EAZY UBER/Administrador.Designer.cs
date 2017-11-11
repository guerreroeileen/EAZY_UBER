namespace EAZY_UBER
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listUsuariosRegistrados = new System.Windows.Forms.ListBox();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.generarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.comboBoxVehiculos = new System.Windows.Forms.ComboBox();
            this.comboBoxRutas = new System.Windows.Forms.ComboBox();
            this.comboBoxRecorridos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPageChartRegUser = new System.Windows.Forms.TabPage();
            this.chartRegUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelUsuariosSinAuto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUsuariosAuto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRecorridosRegistrados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAutosRegistrados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsuariosRegistrados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageChartRegUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRegUser)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUsuariosRegistrados
            // 
            this.listUsuariosRegistrados.FormattingEnabled = true;
            this.listUsuariosRegistrados.ItemHeight = 16;
            this.listUsuariosRegistrados.Location = new System.Drawing.Point(16, 86);
            this.listUsuariosRegistrados.Margin = new System.Windows.Forms.Padding(4);
            this.listUsuariosRegistrados.Name = "listUsuariosRegistrados";
            this.listUsuariosRegistrados.Size = new System.Drawing.Size(192, 324);
            this.listUsuariosRegistrados.TabIndex = 0;
            this.listUsuariosRegistrados.SelectedIndexChanged += new System.EventHandler(this.listUsuariosRegistrados_SelectedIndexChanged);
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(16, 53);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(144, 17);
            this.labelUsuarios.TabIndex = 1;
            this.labelUsuarios.Text = "Usuarios Registrados";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(343, 374);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(148, 28);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar Usuario";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 27);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // generarUsuariosToolStripMenuItem
            // 
            this.generarUsuariosToolStripMenuItem.Name = "generarUsuariosToolStripMenuItem";
            this.generarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.generarUsuariosToolStripMenuItem.Text = "Generar Usuarios";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.toolStripMenuItem1.Text = "Volver a Inicio";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rutas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vehiculos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 207);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Recorridos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Usuario";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(127, 57);
            this.LabelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(0, 17);
            this.LabelNombre.TabIndex = 22;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(127, 85);
            this.labelCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(0, 17);
            this.labelCelular.TabIndex = 23;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(127, 117);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(0, 17);
            this.labelCorreo.TabIndex = 24;
            // 
            // comboBoxVehiculos
            // 
            this.comboBoxVehiculos.FormattingEnabled = true;
            this.comboBoxVehiculos.Location = new System.Drawing.Point(108, 174);
            this.comboBoxVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVehiculos.Name = "comboBoxVehiculos";
            this.comboBoxVehiculos.Size = new System.Drawing.Size(160, 24);
            this.comboBoxVehiculos.TabIndex = 25;
            // 
            // comboBoxRutas
            // 
            this.comboBoxRutas.FormattingEnabled = true;
            this.comboBoxRutas.Location = new System.Drawing.Point(108, 140);
            this.comboBoxRutas.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRutas.Name = "comboBoxRutas";
            this.comboBoxRutas.Size = new System.Drawing.Size(160, 24);
            this.comboBoxRutas.TabIndex = 26;
            // 
            // comboBoxRecorridos
            // 
            this.comboBoxRecorridos.FormattingEnabled = true;
            this.comboBoxRecorridos.Location = new System.Drawing.Point(108, 207);
            this.comboBoxRecorridos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRecorridos.Name = "comboBoxRecorridos";
            this.comboBoxRecorridos.Size = new System.Drawing.Size(160, 24);
            this.comboBoxRecorridos.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxRecorridos);
            this.panel2.Controls.Add(this.comboBoxRutas);
            this.panel2.Controls.Add(this.comboBoxVehiculos);
            this.panel2.Controls.Add(this.labelCorreo);
            this.panel2.Controls.Add(this.labelCelular);
            this.panel2.Controls.Add(this.LabelNombre);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(224, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 263);
            this.panel2.TabIndex = 30;
            // 
            // tabPageChartRegUser
            // 
            this.tabPageChartRegUser.Controls.Add(this.chartRegUser);
            this.tabPageChartRegUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageChartRegUser.Name = "tabPageChartRegUser";
            this.tabPageChartRegUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChartRegUser.Size = new System.Drawing.Size(332, 279);
            this.tabPageChartRegUser.TabIndex = 1;
            this.tabPageChartRegUser.Text = "Registro Usuarios";
            this.tabPageChartRegUser.UseVisualStyleBackColor = true;
            // 
            // chartRegUser
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRegUser.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRegUser.Legends.Add(legend1);
            this.chartRegUser.Location = new System.Drawing.Point(6, 24);
            this.chartRegUser.Name = "chartRegUser";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRegUser.Series.Add(series1);
            this.chartRegUser.Size = new System.Drawing.Size(320, 247);
            this.chartRegUser.TabIndex = 0;
            this.chartRegUser.Text = "Usuarios Registrados";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelUsuariosSinAuto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelUsuariosAuto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelRecorridosRegistrados);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelAutosRegistrados);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelUsuariosRegistrados);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 263);
            this.panel1.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "General";
            // 
            // labelUsuariosSinAuto
            // 
            this.labelUsuariosSinAuto.AutoSize = true;
            this.labelUsuariosSinAuto.Location = new System.Drawing.Point(180, 176);
            this.labelUsuariosSinAuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuariosSinAuto.Name = "labelUsuariosSinAuto";
            this.labelUsuariosSinAuto.Size = new System.Drawing.Size(16, 17);
            this.labelUsuariosSinAuto.TabIndex = 13;
            this.labelUsuariosSinAuto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuarios sin Auto";
            // 
            // labelUsuariosAuto
            // 
            this.labelUsuariosAuto.AutoSize = true;
            this.labelUsuariosAuto.Location = new System.Drawing.Point(179, 144);
            this.labelUsuariosAuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuariosAuto.Name = "labelUsuariosAuto";
            this.labelUsuariosAuto.Size = new System.Drawing.Size(16, 17);
            this.labelUsuariosAuto.TabIndex = 11;
            this.labelUsuariosAuto.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuarios con Auto";
            // 
            // labelRecorridosRegistrados
            // 
            this.labelRecorridosRegistrados.AutoSize = true;
            this.labelRecorridosRegistrados.Location = new System.Drawing.Point(179, 116);
            this.labelRecorridosRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecorridosRegistrados.Name = "labelRecorridosRegistrados";
            this.labelRecorridosRegistrados.Size = new System.Drawing.Size(16, 17);
            this.labelRecorridosRegistrados.TabIndex = 9;
            this.labelRecorridosRegistrados.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recorridos Registrados";
            // 
            // labelAutosRegistrados
            // 
            this.labelAutosRegistrados.AutoSize = true;
            this.labelAutosRegistrados.Location = new System.Drawing.Point(177, 85);
            this.labelAutosRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutosRegistrados.Name = "labelAutosRegistrados";
            this.labelAutosRegistrados.Size = new System.Drawing.Size(16, 17);
            this.labelAutosRegistrados.TabIndex = 7;
            this.labelAutosRegistrados.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autos Registrados";
            // 
            // labelUsuariosRegistrados
            // 
            this.labelUsuariosRegistrados.AutoSize = true;
            this.labelUsuariosRegistrados.Location = new System.Drawing.Point(177, 57);
            this.labelUsuariosRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuariosRegistrados.Name = "labelUsuariosRegistrados";
            this.labelUsuariosRegistrados.Size = new System.Drawing.Size(16, 17);
            this.labelUsuariosRegistrados.TabIndex = 5;
            this.labelUsuariosRegistrados.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuarios Registrados";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageChartRegUser);
            this.tabControl1.Location = new System.Drawing.Point(531, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 308);
            this.tabControl1.TabIndex = 31;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 417);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelUsuarios);
            this.Controls.Add(this.listUsuariosRegistrados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrador";
            this.Text = "Panel de Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageChartRegUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRegUser)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsuarios;
        public System.Windows.Forms.ListBox listUsuariosRegistrados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem generarUsuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label LabelNombre;
        public System.Windows.Forms.Label labelCelular;
        public System.Windows.Forms.Label labelCorreo;
        public System.Windows.Forms.ComboBox comboBoxVehiculos;
        public System.Windows.Forms.ComboBox comboBoxRutas;
        public System.Windows.Forms.ComboBox comboBoxRecorridos;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TabPage tabPageChartRegUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label labelUsuariosSinAuto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelUsuariosAuto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelRecorridosRegistrados;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelAutosRegistrados;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelUsuariosRegistrados;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRegUser;
    }
}