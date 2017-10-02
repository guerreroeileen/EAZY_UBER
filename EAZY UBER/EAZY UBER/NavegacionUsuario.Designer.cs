namespace EAZY_UBER
{
    partial class NavegacionUsuario
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloguearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_PerfilUsuario1 = new EAZY_UBER.Panel_PerfilUsuario();
            this.panel_BuscarRuta1 = new EAZY_UBER.panel_BuscarRuta();
            this.l = new System.Windows.Forms.ListBox();
            this.lbTituloRecomendaciones = new System.Windows.Forms.Label();
            this.panel_RecorridoRecomendado1 = new EAZY_UBER.panel_RecorridoRecomendado();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 38);
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
            this.gMapControl1.Size = new System.Drawing.Size(697, 709);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloguearToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // reloguearToolStripMenuItem
            // 
            this.reloguearToolStripMenuItem.Name = "reloguearToolStripMenuItem";
            this.reloguearToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.reloguearToolStripMenuItem.Text = "Reloguear";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar Ruta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(965, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ofrecer Cupo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_PerfilUsuario1
            // 
            this.panel_PerfilUsuario1.Location = new System.Drawing.Point(787, 38);
            this.panel_PerfilUsuario1.Name = "panel_PerfilUsuario1";
            this.panel_PerfilUsuario1.Size = new System.Drawing.Size(354, 181);
            this.panel_PerfilUsuario1.TabIndex = 4;
            // 
            // panel_BuscarRuta1
            // 
            this.panel_BuscarRuta1.Location = new System.Drawing.Point(726, 279);
            this.panel_BuscarRuta1.Name = "panel_BuscarRuta1";
            this.panel_BuscarRuta1.Size = new System.Drawing.Size(387, 130);
            this.panel_BuscarRuta1.TabIndex = 7;
            // 
            // l
            // 
            this.l.FormattingEnabled = true;
            this.l.ItemHeight = 16;
            this.l.Location = new System.Drawing.Point(726, 452);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(155, 292);
            this.l.TabIndex = 8;
            // 
            // lbTituloRecomendaciones
            // 
            this.lbTituloRecomendaciones.AutoSize = true;
            this.lbTituloRecomendaciones.Location = new System.Drawing.Point(740, 412);
            this.lbTituloRecomendaciones.Name = "lbTituloRecomendaciones";
            this.lbTituloRecomendaciones.Size = new System.Drawing.Size(129, 17);
            this.lbTituloRecomendaciones.TabIndex = 9;
            this.lbTituloRecomendaciones.Text = "Recomendaciones:";
            // 
            // panel_RecorridoRecomendado1
            // 
            this.panel_RecorridoRecomendado1.Location = new System.Drawing.Point(899, 432);
            this.panel_RecorridoRecomendado1.Name = "panel_RecorridoRecomendado1";
            this.panel_RecorridoRecomendado1.Size = new System.Drawing.Size(302, 324);
            this.panel_RecorridoRecomendado1.TabIndex = 10;
            // 
            // NavegacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 774);
            this.Controls.Add(this.panel_RecorridoRecomendado1);
            this.Controls.Add(this.lbTituloRecomendaciones);
            this.Controls.Add(this.l);
            this.Controls.Add(this.panel_BuscarRuta1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_PerfilUsuario1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NavegacionUsuario";
            this.Text = "NavegacionUsuario";
            this.Load += new System.EventHandler(this.NavegacionUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloguearToolStripMenuItem;
        private Panel_PerfilUsuario panel_PerfilUsuario1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private panel_BuscarRuta panel_BuscarRuta1;
        private System.Windows.Forms.ListBox l;
        private System.Windows.Forms.Label lbTituloRecomendaciones;
        private panel_RecorridoRecomendado panel_RecorridoRecomendado1;
    }
}