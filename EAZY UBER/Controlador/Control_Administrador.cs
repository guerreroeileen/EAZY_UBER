using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mundo;
using EAZY_UBER;

namespace Controlador
{
    class Control_Administrador
    {
      
        public event delegado1 eventoQueSeNecesite;
    
        private SistemaRecomendaciones sistema;
        
        private Administrador admon;

        public Control_Administrador(Administrador admen)
        {
            
            admon = admen;

            admon.Show();
        }

        internal void cerrar()
        {
            admon.Close();
            
        }


    }
}
