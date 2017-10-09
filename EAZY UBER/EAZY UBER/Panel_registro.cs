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
    public partial class Panel_registro : UserControl
    {
        public event delegado1 eventoRegistro;
        public event delegado1 eventoCancelar;

        public Panel_registro()
        {
            InitializeComponent();
        }

        public void addHandlerregistro(delegado1 delegado)
        {
            eventoRegistro += delegado;
        }
        public void addHandlerCancelar(delegado1 delegado)
        {
            eventoCancelar += delegado;
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            if (eventoRegistro != null)
                eventoRegistro.Invoke(this);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (eventoCancelar != null)
                eventoCancelar.Invoke(this);
        }

        private void Panel_registro_Load(object sender, EventArgs e)
        {

        }
    }
}
