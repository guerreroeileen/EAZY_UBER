using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;
using mundo;

namespace Controlador
{
    class Runner
    {
        [STAThread]
        static void Main(string[] args)
        {
            SistemaRecomendaciones sistema = new SistemaRecomendaciones();
            Inicio inicio = new Inicio(sistema);
            Control_Inicio control = new Control_Inicio(inicio, sistema);
        }
    }
}
