using EAZY_UBER;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using mundo;
using Excepciones;
using System.Drawing;
using GMap.NET.WindowsForms;

namespace Controlador
{
    public class Control_Inicio
    {
        //modelo
        SistemaRecomendaciones sistema;

        //ventana de incio
        private Inicio formInicio;

        //subcontroladores
        private Control_Notificaciones controlNotificaciones;
        private Control_RegistroRuta controlRegistroRuta;
        private Control_RegistroVehiculo controlRegistroVehiculo;
        private Control_OfrecerCupo controlOfrecerCupos;
        private Control_BuscarRuta controlBuscarRuta;
        private Control_RecoRecomend controlRecorridoRecom;
        private Control_UsuarioRecom controlUsuarioRecom;

        private Control_Administrador controlAdmin;

        //flags
        private bool seleccionarInicio;

        public Control_Inicio(Inicio formInicio, SistemaRecomendaciones sistema)
        {            
            this.sistema = sistema;

            controlUsuarioRecom = new Control_UsuarioRecom(formInicio.panel_UsuarioRecomendado1, sistema);
            controlRecorridoRecom = new Control_RecoRecomend(formInicio.panel_RecorridoRecomendado1, sistema, this);
            controlOfrecerCupos = new Control_OfrecerCupo(formInicio, sistema, controlUsuarioRecom );
            controlBuscarRuta = new Control_BuscarRuta(formInicio, sistema, controlRecorridoRecom);

          
            //eventos listos            

            this.formInicio = formInicio;
            this.formInicio.panel_LogIn1.eventoRegistro += iniciarRegistro;
            this.formInicio.panel_LogIn1.eventoIngresar += ingresar;
            this.formInicio.panel_registro1.eventoRegistro += registrarse;
            this.formInicio.panel_registro1.eventoCancelar += cancelarRegistro;
            this.formInicio.panel_registro1.eventoSeleccionarRutaImagen += seleccionarRutaFoto;
            this.formInicio.mapClick += map_Click;
            this.formInicio.panel_PerfilUsuario1.eventoSeleccionarInicio += seleccionInicio;
            this.formInicio.panel_PerfilUsuario1.eventoCambiarIndiceCBox += mostrarRutas;
            this.formInicio.FormClosing += Form1_FormClosing; 


            formInicio.panel_PerfilUsuario1.addHandlerAgregarRuta(agregarRuta);
            formInicio.panel_PerfilUsuario1.addHandlerAgregarVehiculo(agregarVehiculo);
            formInicio.panel_PerfilUsuario1.addHandlerBuscarRuta(buscarRuta);
            formInicio.panel_PerfilUsuario1.addHandlerOfrecerCupo(ofrecerCupo);
            formInicio.panel_PerfilUsuario1.addHandlerCambiarIndice(mostrarRutas);            
            
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
            Application.Run(this.formInicio);
        }


       //---------------------------------------INICIO REGISTRO Y LOGIN-----------------------------------------
        
        /* metodo para ingresar al sistema
         * se activa al dar click en el boton de ingreso en el Panel_login
         */
        public void ingresar(Object sender)
        {
            //datos log in
            string celular = formInicio.panel_LogIn1.textUsuario.Text;
            string contasena = formInicio.panel_LogIn1.textContrasena.Text;


            //consulta usuario
            bool ingresar = sistema.loguearUsuario(celular, contasena);

            if (ingresar)
            {

                if (celular.SequenceEqual("0000000000") && contasena.SequenceEqual("password"))
                {
                    Administrador admin = new Administrador();
                    SistemaAdministrador sistAdmon = new SistemaAdministrador(sistema);
                    admin.Owner = formInicio;
                    controlAdmin= new Control_Administrador(admin, sistAdmon);
                    formInicio.Visible = false;     
                }
                else
                {
                    //acomodar datos de perfil usuario
                    formInicio.panel_PerfilUsuario1.lbNombre.Text = sistema.Estado_usuarioLogged.Nombre;
                    formInicio.panel_PerfilUsuario1.lbApellido.Text = sistema.Estado_usuarioLogged.Apellido;
                    formInicio.panel_PerfilUsuario1.lbCelular.Text = sistema.Estado_usuarioLogged.Celular;
                    formInicio.panel_PerfilUsuario1.lbInicio.Text = (sistema.Estado_usuarioLogged.Ubicacion != null) ? "Asignado" : "Sin asignar";

                    //limpiar campos panel login
                    formInicio.panel_LogIn1.limpiarTextos();

                    //log in
                    formInicio.panel_registro1.Visible = false;
                    formInicio.mapa.Visible = true;
                    formInicio.panel_PerfilUsuario1.Visible = true;
                    formInicio.panel_OfrecerCupo1.Visible = true;
                    formInicio.panel_BuscarRuta1.Visible = false;
                    formInicio.panel_UsuarioRecomendado1.Visible = false;
                    formInicio.panel_RecorridoRecomendado1.Visible = false;
                    formInicio.panel_LogIn1.Visible = false;
                    formInicio.opcionesToolStripMenuItem.Visible = true;
                    pintarRutas(this);
                    pintarvehiculos(this);
                    if (sistema.Estado_usuarioLogged.Ubicacion != null)
                    {
                        Tuple<double, double> ubicacion = sistema.Estado_usuarioLogged.Ubicacion;
                        formInicio.markerUbicacion.Position = new PointLatLng(ubicacion.Item1, ubicacion.Item2);
                        
                    }
                }


               
            }
            else
            {
                //mensaje error
                formInicio.panel_LogIn1.error.Visible = true;
            }
        }

        /* Metodo para inciar registro
         * Se activa al undir el boton de registro en el Panel_logIn
         */
        public void iniciarRegistro(Object sender)
        {
            //Limpiar campos de login
            formInicio.panel_LogIn1.limpiarTextos();

            //habilitar panel registro e inhabilitar panel login
            formInicio.panel_registro1.Visible = true;
            formInicio.panel_LogIn1.Visible = false;
        }

        /*Permite seleccionar la ruta de la imagen
         * se activa desde el panel de registro
         * salida: debe poner la ruta de la foto en el textRutafoto del panel de registro
         */
        public void seleccionarRutaFoto(Object sender)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            Debug.WriteLine("hola");
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                formInicio.panel_registro1.textFoto.Text = sFileName;
            }

        }

        /* metodo para confirmar el registro
         * Se llama cuando se unde el boton resgitrarse en el panel_registro
         */
        public void registrarse(Object sender)
        {
            //ocultar mensajes de error
            formInicio.panel_registro1.mError1.Visible = false;
            formInicio.panel_registro1.mError2.Visible = false;
            formInicio.panel_registro1.nError0.Visible = false;
            formInicio.panel_registro1.nError1.Visible = false;
            formInicio.panel_registro1.nError2.Visible = false;
            formInicio.panel_registro1.nError3.Visible = false;
            formInicio.panel_registro1.nError4.Visible = false;
            formInicio.panel_registro1.nError5.Visible = false;

            //recuperar textos
            string nombre = formInicio.panel_registro1.textNombre.Text;
            string apellido = formInicio.panel_registro1.textApellido.Text;
            string correo = formInicio.panel_registro1.textCorreo.Text;
            string celular = formInicio.panel_registro1.textCelular.Text;
            string rutafoto = formInicio.panel_registro1.textFoto.Text;
            string contrasena = formInicio.panel_registro1.textContrasena.Text;
            string confirmarContrasena = formInicio.panel_registro1.textConfContrasena.Text;
            bool recibirrecomendaciones = formInicio.panel_registro1.checkBoxRecomendaciones.Checked;

            //agregar al modelo, recibir errores, poner campos en rojo
            try
            {
                sistema.registrarUsuario(nombre, apellido, correo, celular, rutafoto, contrasena, confirmarContrasena, recibirrecomendaciones);
                formInicio.panel_LogIn1.Visible = true;
                formInicio.panel_registro1.Visible = false;
            } catch (AgregarUsuarioExcepcion e)
            {

                //mostrar panel adecuado
                formInicio.panel_registro1.mError1.Visible = true;
                formInicio.panel_registro1.mError2.Visible = true;
                             
                //mostrar mensajes de error
                int[] controlAgregar = e.darErrores();
                if (controlAgregar[0] == 1) { formInicio.panel_registro1.nError0.Visible = true; }
                if (controlAgregar[1] == 1) { formInicio.panel_registro1.nError1.Visible = true; }
                if (controlAgregar[2] == 1) { formInicio.panel_registro1.nError2.Visible = true; }
                if (controlAgregar[3] == 1) { formInicio.panel_registro1.nError3.Visible = true; }
                if (controlAgregar[4] == 1) {  }
                if (controlAgregar[5] == 1) { formInicio.panel_registro1.nError4.Visible = true; formInicio.panel_registro1.nError5.Visible = true;}

            }



        }

        /* Cancelar registro y volver al panel_login
         * Se llama al undir en el label cancelar en el pane_registro
         */
        public void cancelarRegistro(Object sender)
        {
            //muestra log in
            formInicio.panel_LogIn1.Visible = true;

            //limpiar campos
            formInicio.panel_registro1.textNombre.Clear();
            formInicio.panel_registro1.textApellido.Clear();
            formInicio.panel_registro1.textCorreo.Clear();
            formInicio.panel_registro1.textCelular.Clear();
            formInicio.panel_registro1.textFoto.Clear();
            formInicio.panel_registro1.textContrasena.Clear();
            formInicio.panel_registro1.textConfContrasena.Clear();
            formInicio.panel_registro1.checkBoxRecomendaciones.Checked = false;
            
            //ocultar registro
            formInicio.panel_registro1.Visible = false;
        }

        //----------------------------------FIN REGISTRO Y LOG IN---------------------------------------------


            

            

       
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
            controlRegistroRuta = new Control_RegistroRuta(registroRuta,sistema.Estado_usuarioLogged);
            controlRegistroRuta.eventoResgitroRuta += pintarRutas;
        }

        /**método para visualizar la ruta en el mapa prinicipal
             * 
             */

        public void mostrarRutas(Object sender)
        {
            //Error cuando se oprime boton ofrecerCupo por indice en la siguiente linea TODO:
            Ruta selec = sistema.Estado_usuarioLogged.Rutas.Where(x => x.Nombre.Equals(formInicio.panel_PerfilUsuario1.comboBoxRutas.SelectedItem.ToString())).ToList() [0];
            pintarRutaMapa(selec);

        }

        /*
         * El metodo pinta en el mapa de la ventana principal la ruta.
         *  -Input: Ruta selec: Ruta que se va a pintar
         * */
        public void pintarRutaMapa(Ruta selec) {
            formInicio.mapa.Overlays.Clear();
            GMapOverlay rutas = new GMapOverlay("rutas");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(selec.Inicio.Item1, selec.Inicio.Item2));
            foreach (Tuple<double, double> t in selec.Puntos)
                points.Add(new PointLatLng(t.Item1, t.Item2));
            points.Add(new PointLatLng(selec.Fin.Item1, selec.Fin.Item2));
            GMapRoute route = new GMapRoute(points, "Cali");
            route.Stroke = new Pen(Color.Red, 3);
            rutas.Routes.Add(route);

            formInicio.mapa.Overlays.Add(rutas);
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
            controlRegistroVehiculo = new Control_RegistroVehiculo(registroVehiculo, sistema.Estado_usuarioLogged);
            controlRegistroVehiculo.eventoAgregarVehiuclo += pintarvehiculos;
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
            Debug.WriteLine("ENTRO");
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
            sistema.Estado_usuarioLogged = null;
            formInicio.markerUbicacion.Position = new PointLatLng();
            sistema.guardarDB();

            //Acomodar paneles de nuevo
            formInicio.panel_registro1.Visible = false;
            formInicio.mapa.Visible = false;
            formInicio.panel_PerfilUsuario1.Visible = false;
            formInicio.panel_OfrecerCupo1.Visible = false;
            formInicio.panel_BuscarRuta1.Visible = false;
            formInicio.panel_UsuarioRecomendado1.Visible = false;
            formInicio.panel_RecorridoRecomendado1.Visible = false;
            formInicio.panel_LogIn1.Visible = true;
            formInicio.opcionesToolStripMenuItem.Visible = false;


        }

        /* Metodo que se llama cuando se da doble click en el mapa
         * Pone el marcador en el mapa y recupera las coordenadas 
         */
        public void map_Click(Object sender, MouseEventArgs e)
        {


            //asiganr inicio
            if (seleccionarInicio)
            {
                //Debug.WriteLine("Entro 3");
                double lat = formInicio.mapa.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = formInicio.mapa.FromLocalToLatLng(e.X, e.Y).Lng;
                //asignar marcador
                formInicio.markerUbicacion.Position = new PointLatLng(lat, lng);
                formInicio.markerUbicacion.ToolTipText = string.Format("Latitud: {0} \n Longitud: {1}", lat, lng);
                //coordenadas
                Tuple<double, double> ubicacion = new Tuple<double, double>(lat, lng);//este se la pasas al atribut ubicación usuario dependiendo del controlador
                sistema.Estado_usuarioLogged.Ubicacion = ubicacion;
                formInicio.panel_PerfilUsuario1.lbInicio.Text = "asignado";
                formInicio.panel_PerfilUsuario1.buttonSelInicio.Enabled = true;
                seleccionarInicio = false;
            }

        }

        /*Activa la flag oara seleccionar el inicio del usuario
         */
        public void seleccionInicio(Object sender)
        {
            formInicio.panel_PerfilUsuario1.buttonSelInicio.Enabled = false;
            seleccionarInicio = true;
        }

        /*Pinta las rutas que tiene agregado el usuario en el panel de perfil de usuario
         * Se llama:
         *       cuando se hace log in
         *       cuando se agrega una ruta
         */ 
        public void pintarRutas(Object sender)
        {
           formInicio.panel_PerfilUsuario1.comboBoxRutas.Items.Clear();
           List<Ruta> rutas = sistema.Estado_usuarioLogged.Rutas;
            foreach (var r in rutas)
            {
                formInicio.panel_PerfilUsuario1.comboBoxRutas.Items.Add(r.Nombre);
            }
            if (rutas.Count > 0)
               // formInicio.panel_PerfilUsuario1.comboBoxRutas.SelectedIndex = 0 ;
            if(sender.GetType() == typeof(Control_RegistroRuta))
            {
                controlRegistroRuta.cerrar();
                controlRegistroRuta = null;
            }
        }

        /*Pinta las rutas que tiene agregado el usuario en el panel de perfil de usuario
         * Se llama:
         *       cuando se hace log in
         *       cuando se agrega una ruta
         */
        public void pintarvehiculos(Object sender)
        {
            formInicio.panel_PerfilUsuario1.comboBoxVehiculos.Items.Clear();
            List<Vehiculo> vehis = sistema.Estado_usuarioLogged.Vehiculos;
            foreach (var r in vehis)
            {
                formInicio.panel_PerfilUsuario1.comboBoxVehiculos.Items.Add(r.Placa);
            }
            if (vehis.Count > 0)
                formInicio.panel_PerfilUsuario1.comboBoxVehiculos.SelectedIndex = 0;
            if (sender.GetType() == typeof(Control_RegistroVehiculo))
            {
                controlRegistroVehiculo.cerrar();
                controlRegistroVehiculo = null;
            }
        }


        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
           // messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
           // messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            //messageBoxCS.AppendLine();
            //MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
            sistema.guardarDB();

        }



    }
}
