using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAZY_UBER
{
    public partial class panel_RecorridoRecomendado : UserControl
    {
        public panel_RecorridoRecomendado()
        {
            InitializeComponent();
        }

        private void panel_RecorridoRecomendado_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void clear() {
            lbNombre.Text = "";
            lbApellido.Text = "";
            lbCalificacion.Text = "";

            lbTarifa.Text = "";
            lbHora.Text = "";

            lbPlaca.Text = "";
            lbColor.Text = "";
            lbLinea.Text = "";
            lbMarca.Text = "";
        }
    }
}
