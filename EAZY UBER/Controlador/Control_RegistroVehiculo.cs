using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;
using mundo;
using Excepciones;
using System.Windows.Forms;

namespace Controlador
{
    class Control_RegistroVehiculo
    {
        // evento registrar vehiculo
        public event delegado1 eventoAgregarVehiuclo;
        //usuario
        private Usuario usuario;
        //panel registro vehiculo
        private RegistroVehiculo registroVehiculo;

        public Control_RegistroVehiculo(RegistroVehiculo registroVehiculo, Usuario usuario)
        {
            this.usuario = usuario;
            this.registroVehiculo = registroVehiculo;
            this.registroVehiculo.eventoRegistrarVehiculo += registrarVehiculo;
            this.registroVehiculo.Show();
        }

        internal void cerrar()
        {
            registroVehiculo.Close();
        }

        public void registrarVehiculo(Object sender) {
            string placa = registroVehiculo.txbPlaca.Text;
            string marca = registroVehiculo.txbMarca.Text;
            string color = registroVehiculo.txbColor.Text;
            string linea = registroVehiculo.txbLinea.Text;

            try
            {
                usuario.registrarVehiculo(placa, color, marca, linea);
                if (eventoAgregarVehiuclo != null)
                {
                    eventoAgregarVehiuclo.Invoke(this);

                }
            }
            catch(AgregarVehiculoExcepcion e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
