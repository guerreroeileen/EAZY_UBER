using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarRutaExcepcion: Exception
    {

        private int[] errores;
        public AgregarRutaExcepcion(int[] errores)
        {
            this.errores = errores;
        }
        public AgregarRutaExcepcion(string message): base(message) { }
        public AgregarRutaExcepcion(string message, Exception inner): base(message, inner){ }
        public int[] darErrores() { return errores; }




    }
}
