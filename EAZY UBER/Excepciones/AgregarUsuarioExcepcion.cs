using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarUsuarioExcepcion : Exception
    {
        private int[] errores;
        public AgregarUsuarioExcepcion(int[] errores)
        {
            this.errores = errores;
        }
        public AgregarUsuarioExcepcion(string message): base(message) { }
        public AgregarUsuarioExcepcion(string message, Exception inner): base(message, inner){ }
        public int[] darErrores() { return errores; }



    }
}
