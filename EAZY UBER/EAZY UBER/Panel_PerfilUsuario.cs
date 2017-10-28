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
    public partial class Panel_PerfilUsuario : UserControl
    {

        public event delegado1 eventoCambiarIndiceCBox;
        private event delegado1 eventoAgregarRuta;
        private event delegado1 eventoAgregarVehiculo;
        private event delegado1 eventoOfrecerCupo;
        private event delegado1 eventoBuscarRuta;
        public event delegado1 eventoSeleccionarInicio;

        public Panel_PerfilUsuario()
        {
            InitializeComponent();
            errorInicio.Visible = false;
            errorRuta.Visible = false;
            errorVehiculo.Visible = false;
        }

        public void addHandlerCambiarIndice(delegado1 delegado)
        {
            eventoCambiarIndiceCBox += delegado;
        }

        public void addHandlerAgregarRuta(delegado1 delegado)
        {
            eventoAgregarRuta += delegado;
        }
        public void addHandlerAgregarVehiculo(delegado1 delegado)
        {
            eventoAgregarVehiculo += delegado;
        }
        public void addHandlerOfrecerCupo(delegado1 delegado)
        {
            eventoOfrecerCupo += delegado;
        }
        public void addHandlerBuscarRuta(delegado1 delegado)
        {
            eventoBuscarRuta += delegado;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void botonAgregarRuta_Click(object sender, EventArgs e)
        {
            if (eventoAgregarRuta != null)
                eventoAgregarRuta.Invoke(this);
        }

        private void botonAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (eventoAgregarVehiculo != null)
                eventoAgregarVehiculo.Invoke(this);
        }

        private void botonOfrecerCupo_Click(object sender, EventArgs e)
        {
            if (eventoOfrecerCupo != null)
                eventoOfrecerCupo.Invoke(this);
        }

        private void botonBuscarRuta_Click(object sender, EventArgs e)
        {
            if (eventoBuscarRuta != null)
                eventoBuscarRuta.Invoke(this);
        }

        private void buttonSelInicio_Click(object sender, EventArgs e)
        {
            if (eventoSeleccionarInicio != null)
                eventoSeleccionarInicio.Invoke(this);
        }

        private void comboBoxRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventoCambiarIndiceCBox != null)
                eventoCambiarIndiceCBox.Invoke(this);
        }

    }
}
