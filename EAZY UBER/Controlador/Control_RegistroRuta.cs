using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;

namespace Controlador
{
    class Control_RegistroRuta
    {
        private RegistroRuta registroRuta;

        public Control_RegistroRuta(RegistroRuta registroRuta)
        {
            this.registroRuta = registroRuta;
            this.registroRuta.Show();
        }

        public void cerrar()
        {
            registroRuta.Close();
        }
    }
}
