using EAZY_UBER;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class Control_Inicio
    {
        //ventana de incio
        private Inicio formInicio;

        //subcontroladores
        private Control_Notificaciones controlNotificaciones;
        private Control_RegistroRuta controlRegistroRuta;
        private Control_RegistroVehiculo controlRegistroVehiculo;

        public Control_Inicio(Inicio formInicio)
        {
            this.formInicio = formInicio;
            formInicio.panel_LogIn1.addHandlerregistro(iniciarRegistro);
            formInicio.panel_LogIn1.addHandlerIngreso(ingresar);
            formInicio.panel_registro1.addHandlerregistro(registrarse);
            formInicio.panel_registro1.addHandlerCancelar(cancelarRegistro);
            formInicio.panel_PerfilUsuario1.addHandlerAgregarRuta(agregarRuta);
            formInicio.panel_PerfilUsuario1.addHandlerAgregarVehiculo(agregarVehiculo);
            formInicio.panel_PerfilUsuario1.addHandlerBuscarRuta(buscarRuta);
            formInicio.panel_PerfilUsuario1.addHandlerOfrecerCupo(ofrecerCupo);
            formInicio.panel_OfrecerCupo1.addHandlerConfirmarOfrecerCupoo(confirmarOfrecerCupo);
            formInicio.panel_BuscarRuta1.addHandlerConfirmarOfrecerCupoo(confirmarBuscarRecorrido);
            formInicio.panel_registro1.Visible = false;
            formInicio.mapa.Visible = false;
            formInicio.panel_PerfilUsuario1.Visible = false;
            formInicio.panel_OfrecerCupo1.Visible = false;
            formInicio.panel_BuscarRuta1.Visible = false;
            formInicio.panel_UsuarioRecomendado1.Visible = false;
            formInicio.panel_RecorridoRecomendado1.Visible = false;
            formInicio.panel_LogIn1.Visible = true;
            formInicio.opcionesToolStripMenuItem.Visible = false;
            formInicio.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
            formInicio.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            formInicio.mapClick += map_Click;
            Application.Run(this.formInicio);
        }

        /* Metodo para inciar registro
         * Se activa al undir el boton de registro en el Panel_logIn
         */
        public void iniciarRegistro(Object sender)
        {
            formInicio.panel_registro1.Visible = true;
        }

        /* metodo para ingresar al sistema
         * se activa al dar click en el boton de ingreso en el Panel_login
         */
        public void ingresar(Object sender)
        {
            //TODO
            formInicio.panel_registro1.Visible = false;
            formInicio.mapa.Visible = true;
            formInicio.panel_PerfilUsuario1.Visible = true;
            formInicio.panel_OfrecerCupo1.Visible = true;
            formInicio.panel_BuscarRuta1.Visible = false;
            formInicio.panel_UsuarioRecomendado1.Visible = false;
            formInicio.panel_RecorridoRecomendado1.Visible = false;
            formInicio.panel_LogIn1.Visible = false;
            formInicio.opcionesToolStripMenuItem.Visible = true;
        }

        /* Cancelar registro y volver al panel_login
         * Se llama al undir en el label cancelar en el pane_registro
         */
        public void cancelarRegistro(Object sender)
        {
            //TODO limpiar campos
            formInicio.panel_registro1.Visible = false;
        }

        /* metodo para confirmar el registro
         * Se llama cuando se unde el boton resgitrarse en el panel_registro
         */
        public void registrarse(Object sender)
        {
            //TODO
        }
        /* metodo para abrir la ventana de agregar ruta
         * se activa undiendo en el boton "+" en la linea Rutas en el panel perfil_Usuario
         *La ventana queda ligada a Control_AgregarRuta
         */
        public void agregarRuta(Object sender)
        {
            if (controlRegistroRuta != null)
                controlRegistroRuta.cerrar();
            RegistroRuta registroRuta = new RegistroRuta();
            registroRuta.Owner = formInicio;
            controlRegistroRuta = new Control_RegistroRuta(registroRuta);
        }

        /* metodo para abrir la ventana de agregar vehiculo
         * se activa undiendo en el boton "+" en la linea vehiculo en el panel perfil_Usuario
         * La ventana queda ligada a Control_AgregarVehiculo
         */
        public void agregarVehiculo(Object sender)
        {
            if (controlRegistroVehiculo != null)
                controlRegistroVehiculo.cerrar();
            RegistroVehiculo registroVehiculo = new RegistroVehiculo();
            registroVehiculo.Owner = formInicio;
            controlRegistroVehiculo = new Control_RegistroVehiculo(registroVehiculo);


        }

        public void buscarRuta(Object sender)
        {
            formInicio.panel_BuscarRuta1.Visible = true;
            formInicio.panel_OfrecerCupo1.Visible = false;
            formInicio.panel_RecorridoRecomendado1.Visible = false;
            formInicio.panel_UsuarioRecomendado1.Visible = false;
        }

        public void ofrecerCupo(Object sender)
        {
            formInicio.panel_OfrecerCupo1.Visible = true;
            formInicio.panel_BuscarRuta1.Visible = false;
            formInicio.panel_RecorridoRecomendado1.Visible = false;
            formInicio.panel_UsuarioRecomendado1.Visible = false;
        }

        public void confirmarOfrecerCupo(Object sender)
        {
            formInicio.panel_UsuarioRecomendado1.Visible = true;
            formInicio.panel_RecorridoRecomendado1.Visible = false;
        }


        public void confirmarBuscarRecorrido(Object sender)
        {
            formInicio.panel_RecorridoRecomendado1.Visible = true;
            formInicio.panel_UsuarioRecomendado1.Visible = false;
        }

        /* metodo para abrir la ventana de notificaciones
        * se activa undiendo notificaciones en la barra de opciones
        * La ventana queda ligada a Control_Notificaciones
        */
        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlNotificaciones != null)
                controlNotificaciones.cerrar();
            Notificaciones notificaciones = new Notificaciones();
            notificaciones.Owner = formInicio;
            controlNotificaciones = new Control_Notificaciones(notificaciones);
        }
    
        /*metodo para cerrar sesion
         * se activa desde la barra de opciones en "Cerrar Sesion"
         */
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /* Metodo que se llama cuando se da doble click en el mapa
         * Pone el marcador en el mapa y recupera las coordenadas 
         */
        public void map_Click(Object sender, MouseEventArgs e)
        {
            //Debug.WriteLine("Entro 3");
            double lat = formInicio.mapa.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = formInicio.mapa.FromLocalToLatLng(e.X, e.Y).Lng;
            formInicio.marker.Position = new PointLatLng(lat, lng);
            formInicio.marker.ToolTipText = string.Format("Latitud: {0} \n Longitud: {1}", lat, lng);

            //coordenadas
            Tuple<double, double> ubicacion = new Tuple<double, double>(lat, lng);//este se la pasas al atribut ubicación usuario dependiendo del controlador

        }


    }
}
