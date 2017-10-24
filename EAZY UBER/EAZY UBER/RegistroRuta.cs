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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EAZY_UBER
{
    public partial class RegistroRuta : Form
    {
        //markers
        public GMarkerGoogle markerInicio;
        public GMarkerGoogle markerFinal;
        public List<GMarkerGoogle> markerPuntos;
        public GMapOverlay markerOverlay;

        //events
        public event delegado1 eventoAgregar;
        public event delegado1 eventoAgregarIncio;
        public event delegado1 eventoAgregarFin;
        public event delegado1 eventoAgregarPuntos;
        public event delegado2 eventogmapControl;
        public event delegado1 eventoEliminarPunto;

        public RegistroRuta()
        {
            markerPuntos = new List<GMarkerGoogle>();
            InitializeComponent();
        }

        private void RegistroRuta_Load(object sender, EventArgs e)
        {
            //set map
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");
            gMapControl1.CanDragMap = true;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 42;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            //Agregamos el map y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);

            //pone todos los errores ocultos
            error0.Visible = false;
            error2.Visible = false;
            error1.Visible= false;

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        { 
        }

        /*Evento double click en el mapa
         *Se agregan los puntos de acuerdo al flag que esté eactivo
         */
        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (eventogmapControl != null)
                eventogmapControl.Invoke(this, e);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (eventoAgregarIncio != null)
                eventoAgregarIncio.Invoke(this);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (eventoAgregarFin != null)
                eventoAgregarFin.Invoke(this);
        }

        private void btnAgregarPuntos_Click(object sender, EventArgs e)
        {
            if (eventoAgregarPuntos != null)
                eventoAgregarPuntos.Invoke(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (eventoEliminarPunto != null)
                eventoEliminarPunto.Invoke(this);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (eventoAgregar != null)
                eventoAgregar.Invoke(this);
        }
    }
}
