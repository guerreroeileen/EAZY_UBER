using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;

namespace Controlador
{
    class Runner
    {
        static void Main(string[] args)
        {
            //crear modelo pasar a vista u control
            Inicio inicio = new Inicio();
            Control_Inicio control = new Control_Inicio(inicio);
        }
    }
}
