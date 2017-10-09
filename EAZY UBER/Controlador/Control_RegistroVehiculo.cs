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
            this.registroVehiculo.Show();
        }

        internal void cerrar()
        {
            registroVehiculo.Close();
        }
    }
}
