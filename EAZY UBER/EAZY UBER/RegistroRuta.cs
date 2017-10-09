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

namespace EAZY_UBER
{
    public partial class RegistroRuta : Form
    {
        public RegistroRuta()
        {
            InitializeComponent();
        }

        private void RegistroRuta_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
           gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");
            gMapControl1.CanDragMap = true;


            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 42;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
