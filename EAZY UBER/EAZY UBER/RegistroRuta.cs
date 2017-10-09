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
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        public RegistroRuta()
        {
            InitializeComponent();
        }

        private void RegistroRuta_Load(object sender, EventArgs e)
        {
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
            marker = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);// Agregamos al map
            //Agregar texto alos marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            // marker.ToolTipText = string.Format("Nombre: \n Latitud: {0} \n Longitud: {1}", LatInicial, lngInicial);

            //Agregamos el map y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;

            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;





            marker.Position = new PointLatLng(lat, lng);

            marker.ToolTipText = string.Format("Latitud: {0} \n Longitud: {1}", lat, lng);

            Tuple<double, double> ubicacion = new Tuple<double, double>(lat, lng);//Para registrar inicio fin y puntos
        }
    }
}
