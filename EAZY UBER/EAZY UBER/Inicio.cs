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

namespace EAZY_UBER
{
    public partial class Inicio : Form
    {
        //VENTANAS
        private RegistroRuta registroRuta;
        private RegistroVehiculo registroVehiculo;
        private Notificaciones notificaciones;

        private Panel_registro panel_registro1;
        private GMap.NET.WindowsForms.GMapControl mapa;
        private Panel_PerfilUsuario panel_PerfilUsuario1;
        private panel_OfrecerCupo panel_OfrecerCupo1;
        private panel_BuscarRuta panel_BuscarRuta1;
        private panel_UsuarioRecomendado panel_UsuarioRecomendado1;
        private panel_RecorridoRecomendado panel_RecorridoRecomendado1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem notificacionesToolStripMenuItem;
        private Panel_LogIn panel_LogIn1;

        public Inicio()
        {
           
            InitializeComponent();
            panel_LogIn1.addHandlerregistro(iniciarRegistro);
            panel_LogIn1.addHandlerIngreso(ingresar);
            panel_registro1.addHandlerregistro(registrarse);
            panel_registro1.addHandlerCancelar(cancelarRegistro);
            panel_PerfilUsuario1.addHandlerAgregarRuta(agregarRuta);
            panel_PerfilUsuario1.addHandlerAgregarVehiculo(agregarVehiculo);
            panel_PerfilUsuario1.addHandlerBuscarRuta(buscarRuta);
            panel_PerfilUsuario1.addHandlerOfrecerCupo(ofrecerCupo);
            panel_OfrecerCupo1.addHandlerConfirmarOfrecerCupoo(confirmarOfrecerCupo);
            panel_BuscarRuta1.addHandlerConfirmarOfrecerCupoo(confirmarBuscarRecorrido);
            panel_registro1.Visible = false;
            mapa.Visible = false;
            panel_PerfilUsuario1.Visible = false;
            panel_OfrecerCupo1.Visible = false;
            panel_BuscarRuta1.Visible = false;
            panel_UsuarioRecomendado1.Visible = false;
            panel_RecorridoRecomendado1.Visible = false;
            panel_LogIn1.Visible = true;
            opcionesToolStripMenuItem.Visible = false;

    }

        //Control navegacion
        public void iniciarRegistro(Object sender)
        {
            panel_registro1.Visible = true;
        }
        public void ingresar(Object sender)
        {
            //TODO
            panel_registro1.Visible = false;
            mapa.Visible = true;
            panel_PerfilUsuario1.Visible = true;
            panel_OfrecerCupo1.Visible = true;
            panel_BuscarRuta1.Visible = false;
            panel_UsuarioRecomendado1.Visible = false;
            panel_RecorridoRecomendado1.Visible = false;
            panel_LogIn1.Visible = false;
            opcionesToolStripMenuItem.Visible = true;
        }
        public void cancelarRegistro(Object sender)
        {
            //TODO limpiar campos
            panel_registro1.Visible = false;
        }
        public void registrarse(Object sender)
        {
            //TODO
        }
        public void agregarRuta(Object sender)
        {
            if (registroRuta != null)
                registroRuta.Close();
            registroRuta = new RegistroRuta();
            registroRuta.Owner = this;
            registroRuta.Show();
        }
        public void agregarVehiculo(Object sender)
        {
            if (registroVehiculo != null)
                registroVehiculo.Close();
            registroVehiculo = new RegistroVehiculo();
            registroVehiculo.Owner = this;
            registroVehiculo.Show();
        }
        public void buscarRuta(Object sender)
        {
            panel_BuscarRuta1.Visible = true;
            panel_OfrecerCupo1.Visible = false;
            panel_RecorridoRecomendado1.Visible = false;
            panel_UsuarioRecomendado1.Visible = false;
        }
        public void ofrecerCupo(Object sender)
        {
            panel_OfrecerCupo1.Visible = true;
            panel_BuscarRuta1.Visible = false;
            panel_RecorridoRecomendado1.Visible = false;
            panel_UsuarioRecomendado1.Visible = false;
        }
        public void confirmarOfrecerCupo(Object sender)
        {
            panel_UsuarioRecomendado1.Visible = true;
            panel_RecorridoRecomendado1.Visible = false;
        }
        public void confirmarBuscarRecorrido(Object sender)
        {
            panel_RecorridoRecomendado1.Visible = true;
            panel_UsuarioRecomendado1.Visible = false;
        }
        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notificaciones != null)
                notificaciones.Close();
            notificaciones = new Notificaciones();
            notificaciones.Owner = this;
            notificaciones.Show();
        }


        private void InitializeComponent()
        {
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.panel_registro1 = new EAZY_UBER.Panel_registro();
            this.panel_LogIn1 = new EAZY_UBER.Panel_LogIn();
            this.panel_PerfilUsuario1 = new EAZY_UBER.Panel_PerfilUsuario();
            this.panel_OfrecerCupo1 = new EAZY_UBER.panel_OfrecerCupo();
            this.panel_BuscarRuta1 = new EAZY_UBER.panel_BuscarRuta();
            this.panel_UsuarioRecomendado1 = new EAZY_UBER.panel_UsuarioRecomendado();
            this.panel_RecorridoRecomendado1 = new EAZY_UBER.panel_RecorridoRecomendado();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mapa.Location = new System.Drawing.Point(11, 50);
            this.mapa.Margin = new System.Windows.Forms.Padding(2);
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
            this.mapa.Size = new System.Drawing.Size(523, 591);
            this.mapa.TabIndex = 12;
            this.mapa.Zoom = 0D;
            // 
            // panel_registro1
            // 
            this.panel_registro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_registro1.Location = new System.Drawing.Point(298, 97);
            this.panel_registro1.Name = "panel_registro1";
            this.panel_registro1.Size = new System.Drawing.Size(304, 342);
            this.panel_registro1.TabIndex = 1;
            // 
            // panel_LogIn1
            // 
            this.panel_LogIn1.Location = new System.Drawing.Point(335, 130);
            this.panel_LogIn1.Name = "panel_LogIn1";
            this.panel_LogIn1.Size = new System.Drawing.Size(253, 289);
            this.panel_LogIn1.TabIndex = 0;
            // 
            // panel_PerfilUsuario1
            // 
            this.panel_PerfilUsuario1.Location = new System.Drawing.Point(555, 50);
            this.panel_PerfilUsuario1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_PerfilUsuario1.Name = "panel_PerfilUsuario1";
            this.panel_PerfilUsuario1.Size = new System.Drawing.Size(346, 199);
            this.panel_PerfilUsuario1.TabIndex = 13;
            // 
            // panel_OfrecerCupo1
            // 
            this.panel_OfrecerCupo1.Location = new System.Drawing.Point(555, 264);
            this.panel_OfrecerCupo1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_OfrecerCupo1.Name = "panel_OfrecerCupo1";
            this.panel_OfrecerCupo1.Size = new System.Drawing.Size(346, 116);
            this.panel_OfrecerCupo1.TabIndex = 14;
            // 
            // panel_BuscarRuta1
            // 
            this.panel_BuscarRuta1.Location = new System.Drawing.Point(555, 264);
            this.panel_BuscarRuta1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_BuscarRuta1.Name = "panel_BuscarRuta1";
            this.panel_BuscarRuta1.Size = new System.Drawing.Size(346, 116);
            this.panel_BuscarRuta1.TabIndex = 15;
            // 
            // panel_UsuarioRecomendado1
            // 
            this.panel_UsuarioRecomendado1.Location = new System.Drawing.Point(555, 396);
            this.panel_UsuarioRecomendado1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_UsuarioRecomendado1.Name = "panel_UsuarioRecomendado1";
            this.panel_UsuarioRecomendado1.Size = new System.Drawing.Size(346, 245);
            this.panel_UsuarioRecomendado1.TabIndex = 16;
            // 
            // panel_RecorridoRecomendado1
            // 
            this.panel_RecorridoRecomendado1.Location = new System.Drawing.Point(555, 396);
            this.panel_RecorridoRecomendado1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_RecorridoRecomendado1.Name = "panel_RecorridoRecomendado1";
            this.panel_RecorridoRecomendado1.Size = new System.Drawing.Size(346, 245);
            this.panel_RecorridoRecomendado1.TabIndex = 17;
            // 
            // menuStrip1
            // 
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
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            this.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
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

            mapa.MapProvider = GMapProviders.GoogleMap;

        }

    }
}
