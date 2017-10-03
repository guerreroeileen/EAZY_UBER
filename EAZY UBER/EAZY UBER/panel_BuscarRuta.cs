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
    public partial class panel_BuscarRuta : UserControl
    {
        private event delegado1 eventoConfirmarBuscarRuta;

        public panel_BuscarRuta()
        {
            InitializeComponent();
        }

        public void addHandlerConfirmarOfrecerCupoo(delegado1 delegado)
        {
            eventoConfirmarBuscarRuta += delegado;
        }
        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (eventoConfirmarBuscarRuta != null)
                eventoConfirmarBuscarRuta.Invoke(this);
        }
    }
}
