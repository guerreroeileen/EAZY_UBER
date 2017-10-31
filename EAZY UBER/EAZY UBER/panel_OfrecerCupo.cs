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
    public partial class panel_OfrecerCupo : UserControl
    {
        private event delegado1 eventoConfirmarOfrecerCupo;

        public panel_OfrecerCupo()
        {
            InitializeComponent();
            errorFecha.Visible = false;
            errorHora.Visible = false;
            errorCupo.Visible = false;
            errorTarifa.Visible = false;
        }
        public void addHandlerConfirmarOfrecerCupoo(delegado1 delegado)
        {
            eventoConfirmarOfrecerCupo += delegado;
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_OfrecerCupo_Load(object sender, EventArgs e)
        {

        }
    }
}
