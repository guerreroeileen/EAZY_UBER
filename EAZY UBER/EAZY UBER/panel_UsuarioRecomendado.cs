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
    public partial class panel_UsuarioRecomendado : UserControl
    {
        public panel_UsuarioRecomendado()
        {
            InitializeComponent();
        }

        public void clear() {
            lbNombre.Text = "";
            lbApellido.Text = "";

            //falta limpiar la imagen
        }
    }
}
