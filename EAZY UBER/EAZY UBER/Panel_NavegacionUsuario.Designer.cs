namespace EAZY_UBER
{
    partial class Panel_NavegacionUsuario
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
            this.panel_RecorridoRecomendado1 = new EAZY_UBER.panel_RecorridoRecomendado();
            this.lbTituloRecomendaciones = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.ListBox();
            this.panel_BuscarRuta1 = new EAZY_UBER.panel_BuscarRuta();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_PerfilUsuario1 = new EAZY_UBER.Panel_PerfilUsuario();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloguearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_RecorridoRecomendado1
            // 
            this.panel_RecorridoRecomendado1.Location = new System.Drawing.Point(667, 346);
            this.panel_RecorridoRecomendado1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_RecorridoRecomendado1.Name = "panel_RecorridoRecomendado1";
            this.panel_RecorridoRecomendado1.Size = new System.Drawing.Size(226, 263);
            this.panel_RecorridoRecomendado1.TabIndex = 19;
            // 
            // lbTituloRecomendaciones
            // 
            this.lbTituloRecomendaciones.AutoSize = true;
            this.lbTituloRecomendaciones.Location = new System.Drawing.Point(548, 330);
            this.lbTituloRecomendaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloRecomendaciones.Name = "lbTituloRecomendaciones";
            this.lbTituloRecomendaciones.Size = new System.Drawing.Size(99, 13);
            this.lbTituloRecomendaciones.TabIndex = 18;
            this.lbTituloRecomendaciones.Text = "Recomendaciones:";
            // 
            // l
            // 
            this.l.FormattingEnabled = true;
            this.l.Location = new System.Drawing.Point(551, 364);
            this.l.Margin = new System.Windows.Forms.Padding(2);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(117, 238);
            this.l.TabIndex = 17;
            // 
            // panel_BuscarRuta1
            // 
            this.panel_BuscarRuta1.Location = new System.Drawing.Point(537, 222);
            this.panel_BuscarRuta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_BuscarRuta1.Name = "panel_BuscarRuta1";
            this.panel_BuscarRuta1.Size = new System.Drawing.Size(290, 106);
            this.panel_BuscarRuta1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 19);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ofrecer Cupo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 19);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar Ruta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_PerfilUsuario1
            // 
            this.panel_PerfilUsuario1.Location = new System.Drawing.Point(583, 26);
            this.panel_PerfilUsuario1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_PerfilUsuario1.Name = "panel_PerfilUsuario1";
            this.panel_PerfilUsuario1.Size = new System.Drawing.Size(266, 147);
            this.panel_PerfilUsuario1.TabIndex = 13;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(10, 26);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(523, 576);
            this.gMapControl1.TabIndex = 11;
            this.gMapControl1.Zoom = 0D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloguearToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // reloguearToolStripMenuItem
            // 
            this.reloguearToolStripMenuItem.Name = "reloguearToolStripMenuItem";
            this.reloguearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.reloguearToolStripMenuItem.Text = "Reloguear";
            // 
            // Panel_NavegacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_RecorridoRecomendado1);
            this.Controls.Add(this.lbTituloRecomendaciones);
            this.Controls.Add(this.l);
            this.Controls.Add(this.panel_BuscarRuta1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_PerfilUsuario1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Panel_NavegacionUsuario";
            this.Size = new System.Drawing.Size(903, 628);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private panel_RecorridoRecomendado panel_RecorridoRecomendado1;
        private System.Windows.Forms.Label lbTituloRecomendaciones;
        private System.Windows.Forms.ListBox l;
        private panel_BuscarRuta panel_BuscarRuta1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Panel_PerfilUsuario panel_PerfilUsuario1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloguearToolStripMenuItem;
    }
}
