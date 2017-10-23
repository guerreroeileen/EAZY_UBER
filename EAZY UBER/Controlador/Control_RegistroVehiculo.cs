using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;

namespace Controlador
{
    class Control_RegistroVehiculo
    {
        private RegistroVehiculo registroVehiculo;

        public Control_RegistroVehiculo(RegistroVehiculo registroVehiculo)
        {
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
            string linea = registroVehiculo.txbLinea.Text;
            string color = registroVehiculo.txbColor.Text;


        }
    }
}
