using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;

namespace Controlador
{
    class Control_Notificaciones
    {
        private Notificaciones notificaciones;

        public Control_Notificaciones(Notificaciones notificaciones)
        {
            this.notificaciones = notificaciones;
            this.notificaciones.Show();
        }

        internal void cerrar()
        {
            notificaciones.Close();
        }
    }
}
