using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;
using GMap;
using GMap.NET;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Diagnostics;
using System.Drawing;
using mundo;
using Excepciones;

namespace Controlador
{
    class Control_RegistroRuta
    {
        //evento registrar
        public event delegado1 eventoResgitroRuta;

        //usuario
        private Usuario usuario;

        //panel registroRuta
        private RegistroRuta registroRuta;

        //puntos
        public Tuple<double, double> inicio;
        public Tuple<double, double> fin;
        public List<Tuple<double, double>> puntos;


        //flags
        public bool agregarInicio;
        public bool agregarFin;
        public bool agregarPuntos;

        public Control_RegistroRuta(RegistroRuta registroRuta, Usuario usuario)
        {
            this.usuario = usuario;
            puntos = new List<Tuple< double, double>>();
            this.registroRuta = registroRuta;
            this.registroRuta.eventogmapControl += doubleClickMap;
            this.registroRuta.eventoAgregarIncio += seleccionarInicio;
            this.registroRuta.eventoAgregarFin += seleccionarFin;
            this.registroRuta.eventoAgregarPuntos += seleccionarPuntos;
            this.registroRuta.eventoEliminarPunto += eliminarPunto;
            this.registroRuta.eventoAgregar += registrarRuta;
            this.registroRuta.Show();
        }

        public void cerrar()
        {
            registroRuta.Close();
        }

        /*Agregar los puntos de la ruta dependiendo de la flag
         * 
         */
        public void doubleClickMap(Object sender, MouseEventArgs e)
        {
            if (agregarInicio)
            {
                //agregar markers
                double lat = registroRuta.gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = registroRuta.gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                registroRuta.markerOverlay.Markers.Remove(registroRuta.markerInicio);
                registroRuta.markerInicio = new GMarkerGoogle( new PointLatLng(lat, lng), GMarkerGoogleType.green_big_go);
                registroRuta.markerInicio.ToolTipMode = MarkerTooltipMode.Always;
                registroRuta.markerInicio.ToolTipText = string.Format("Latitud: {0} \n Longitud: {1}", lat, lng);
                registroRuta.markerOverlay.Markers.Add(registroRuta.markerInicio);
                //agregar punto
                inicio = new Tuple<double, double>(lat, lng);//Para registrar inicio fin y puntos
                
            }
            else if (agregarFin)
            {
                //agregar markers
                double lat = registroRuta.gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = registroRuta.gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                registroRuta.markerOverlay.Markers.Remove(registroRuta.markerFinal);
                registroRuta.markerFinal = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_big_stop);
                registroRuta.markerFinal.ToolTipMode = MarkerTooltipMode.Always;
                registroRuta.markerFinal.ToolTipText = string.Format("Latitud: {0} \n Longitud: {1}", lat, lng);
                registroRuta.markerOverlay.Markers.Add(registroRuta.markerFinal);
                //agregar punto
                fin = new Tuple<double, double>(lat, lng);//Para registrar inicio fin y puntos
            }
            else if (agregarPuntos)
            {
                //agregar markers
                double lat = registroRuta.gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = registroRuta.gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat,lng), GMarkerGoogleType.blue_dot);
                registroRuta.markerPuntos.Add(marker);
                registroRuta.markerOverlay.Markers.Add(marker);
                //agregar puntos
                Tuple<double, double> punto = new Tuple<double, double>(lat, lng);
                puntos.Add(punto);
                registroRuta.listBox1.Items.Add("punto " + puntos.Count);
            }
        }

        public void seleccionarInicio(Object sender)
        {
            //acomodar botones
            registroRuta.btnInicio.BackColor = System.Drawing.Color.Blue;
            registroRuta.btnFin.BackColor = System.Drawing.Color.LightGray;
            registroRuta.btnAgregarPuntos.BackColor = System.Drawing.Color.LightGray;

            //acomodar flags
            agregarInicio = (agregarInicio) ? false : true;
            agregarPuntos = false;
            agregarFin = false;
        }
        public void seleccionarFin(Object sender)
        {

            //acomodar botones
            registroRuta.btnInicio.BackColor = System.Drawing.Color.LightGray;
            registroRuta.btnFin.BackColor = System.Drawing.Color.Blue;
            registroRuta.btnAgregarPuntos.BackColor = System.Drawing.Color.LightGray;

            //acomodar flags
            agregarFin = (agregarFin) ? false : true;
            agregarInicio = false;
            agregarPuntos = false;

        }
        public void seleccionarPuntos(Object sender)
        {

            //acomodar botones
            registroRuta.btnInicio.BackColor = System.Drawing.Color.LightGray;
            registroRuta.btnFin.BackColor = System.Drawing.Color.LightGray;
            registroRuta.btnAgregarPuntos.BackColor = System.Drawing.Color.Blue;

            //acomodar flags
            agregarPuntos = (agregarPuntos) ? false : true;
            agregarInicio = false;
            agregarFin = false;
        }

        public void eliminarPunto(Object sender)
        {
            //elimanr marker
            int index = registroRuta.listBox1.SelectedIndex;
            if (index != -1)
            { 
                GMarkerGoogle marker = registroRuta.markerPuntos.ToList()[index];
                registroRuta.markerPuntos.Remove(marker);
                registroRuta.markerOverlay.Markers.Remove(marker);
                puntos.RemoveAt(index);
                registroRuta.listBox1.Items.RemoveAt(index);
            }
        }

        /*
         * realiza el trazado entre los puntos
         */
        public void trazado()
        {
            GMapOverlay rutas = new GMapOverlay("rutas");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(inicio.Item1, inicio.Item2));
            foreach (Tuple<double, double> t in puntos)
                points.Add(new PointLatLng(t.Item1, t.Item2));
            points.Add(new PointLatLng(fin.Item1, fin.Item2));
            GMapRoute route = new GMapRoute(points, "Cali la mejor");
            route.Stroke = new Pen(Color.Red, 3);
            rutas.Routes.Add(route);
            registroRuta.gMapControl1.Overlays.Add(rutas);
        }

        /*Evento ligado al boton registrar
         * se debe verificar toda la info antes de agregar
         *              puede ser con manejo de excepciones desde el mundo
         * 
         */
        public void registrarRuta(Object sender)
        {
            string nombre = registroRuta.textBoxNombreRuta.Text;
            string descripcion = registroRuta.textBoxDescripcionRuta.Text;
            try{
                usuario.registrarRuta(nombre, inicio, fin, puntos, descripcion);
                if(eventoResgitroRuta != null)
                {
                    eventoResgitroRuta.Invoke(this);
                    
                }
            } catch(AgregarRutaExcepcion e){
                MessageBox.Show(e.Message);

                

                if (registroRuta.textBoxNombreRuta.Text.Length == 0) { registroRuta.error0.Visible = true; };
                if (inicio == null && fin ==null) { registroRuta.error1.Visible = true; };
                if (registroRuta.listBox1.Items.Count == 0) { registroRuta.error2.Visible = true; };
                if (registroRuta.textBoxDescripcionRuta.Text.Length < 5) { registroRuta.error3.Visible = true; };


            }

        }


    }
}
