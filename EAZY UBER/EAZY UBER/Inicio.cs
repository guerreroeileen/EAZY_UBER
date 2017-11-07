using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
using mundo;

namespace EAZY_UBER
{
    public delegate void delegado2(Object sender, MouseEventArgs e);

    public partial class Inicio : Form
    {

        //modelo
        SistemaRecomendaciones sistema;

        //paneles agregados al form Inicio
        public Panel_registro panel_registro1;
        public Panel_PerfilUsuario panel_PerfilUsuario1;
        public panel_OfrecerCupo panel_OfrecerCupo1;
        public panel_BuscarRuta panel_BuscarRuta1;
        public panel_UsuarioRecomendado panel_UsuarioRecomendado1;
        public panel_RecorridoRecomendado panel_RecorridoRecomendado1;
        public Panel_LogIn panel_LogIn1;
       

        //menu strip
        public MenuStrip menuStrip1;
        public ToolStripMenuItem opcionesToolStripMenuItem;
        public ToolStripMenuItem cerrarSesionToolStripMenuItem;
        public ToolStripMenuItem notificacionesToolStripMenuItem;


        //MAPA
        public GMap.NET.WindowsForms.GMapControl mapa;
        public GMarkerGoogle markerUbicacion;
        public GMapOverlay markerOverlay;
        //evento click en el mapa
        public event delegado2 mapClick;


        public Inicio(SistemaRecomendaciones sistema)
        {
            this.sistema = sistema;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_RecorridoRecomendado1 = new EAZY_UBER.panel_RecorridoRecomendado();
            this.panel_UsuarioRecomendado1 = new EAZY_UBER.panel_UsuarioRecomendado();
            this.panel_BuscarRuta1 = new EAZY_UBER.panel_BuscarRuta();
            this.panel_OfrecerCupo1 = new EAZY_UBER.panel_OfrecerCupo();
            this.panel_PerfilUsuario1 = new EAZY_UBER.Panel_PerfilUsuario();
            this.panel_registro1 = new EAZY_UBER.Panel_registro();
            this.panel_LogIn1 = new EAZY_UBER.Panel_LogIn();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(12, 50);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(150, 150);
            this.mapa.TabIndex = 18;
            this.mapa.Zoom = 0D;
            this.mapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapa_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // panel_RecorridoRecomendado1
            // 
            this.panel_RecorridoRecomendado1.Location = new System.Drawing.Point(555, 384);
            this.panel_RecorridoRecomendado1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_RecorridoRecomendado1.Name = "panel_RecorridoRecomendado1";
            this.panel_RecorridoRecomendado1.Size = new System.Drawing.Size(346, 257);
            this.panel_RecorridoRecomendado1.TabIndex = 17;
            // 
            // panel_UsuarioRecomendado1
            // 
            this.panel_UsuarioRecomendado1.Location = new System.Drawing.Point(555, 384);
            this.panel_UsuarioRecomendado1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_UsuarioRecomendado1.Name = "panel_UsuarioRecomendado1";
            this.panel_UsuarioRecomendado1.Size = new System.Drawing.Size(346, 257);
            this.panel_UsuarioRecomendado1.TabIndex = 16;
            // 
            // panel_BuscarRuta1
            // 
            this.panel_BuscarRuta1.Location = new System.Drawing.Point(555, 264);
            this.panel_BuscarRuta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_BuscarRuta1.Name = "panel_BuscarRuta1";
            this.panel_BuscarRuta1.Size = new System.Drawing.Size(346, 105);
            this.panel_BuscarRuta1.TabIndex = 15;
            // 
            // panel_OfrecerCupo1
            // 
            this.panel_OfrecerCupo1.Location = new System.Drawing.Point(555, 264);
            this.panel_OfrecerCupo1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_OfrecerCupo1.Name = "panel_OfrecerCupo1";
            this.panel_OfrecerCupo1.Size = new System.Drawing.Size(346, 105);
            this.panel_OfrecerCupo1.TabIndex = 14;
            // 
            // panel_PerfilUsuario1
            // 
            this.panel_PerfilUsuario1.Location = new System.Drawing.Point(555, 50);
            this.panel_PerfilUsuario1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_PerfilUsuario1.Name = "panel_PerfilUsuario1";
            this.panel_PerfilUsuario1.Size = new System.Drawing.Size(346, 222);
            this.panel_PerfilUsuario1.TabIndex = 13;
            // 
            // panel_registro1
            // 
            this.panel_registro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_registro1.Location = new System.Drawing.Point(298, 97);
            this.panel_registro1.Margin = new System.Windows.Forms.Padding(4);
            this.panel_registro1.Name = "panel_registro1";
            this.panel_registro1.Size = new System.Drawing.Size(304, 342);
            this.panel_registro1.TabIndex = 1;
            // 
            // panel_LogIn1
            // 
            this.panel_LogIn1.Location = new System.Drawing.Point(335, 130);
            this.panel_LogIn1.Margin = new System.Windows.Forms.Padding(4);
            this.panel_LogIn1.Name = "panel_LogIn1";
            this.panel_LogIn1.Size = new System.Drawing.Size(253, 289);
            this.panel_LogIn1.TabIndex = 0;
            // 
            // Inicio
            // 
            this.BackgroundImage = global::EAZY_UBER.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(912, 652);
            this.Controls.Add(this.panel_RecorridoRecomendado1);
            this.Controls.Add(this.panel_UsuarioRecomendado1);
            this.Controls.Add(this.panel_BuscarRuta1);
            this.Controls.Add(this.panel_OfrecerCupo1);
            this.Controls.Add(this.panel_PerfilUsuario1);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.panel_registro1);
            this.Controls.Add(this.panel_LogIn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.SetPositionByKeywords("Cali,Colombia");

           
            mapa.MinZoom = 0;
            mapa.MaxZoom = 42;
            mapa.Zoom = 12;
            mapa.AutoScroll = true;

            this.mapa.MarkersEnabled = true;         
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.Name = "mapa";
            this.mapa.PolygonsEnabled = true;
            this.mapa.RoutesEnabled = true;
            this.mapa.Size = new System.Drawing.Size(523, 590);


            markerOverlay = new GMapOverlay("Marcador");
            markerUbicacion = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.orange);
            markerOverlay.Markers.Add(markerUbicacion);// Agregamos al map
            //Agregar texto alos marcadores
            markerUbicacion.ToolTipMode = MarkerTooltipMode.Always; 
            //Agregamos el map y el marcador al map control
            mapa.Overlays.Add(markerOverlay);

        }

        private void mapa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mapClick != null)
                mapClick.Invoke(this,e);          
        }




    }
}
