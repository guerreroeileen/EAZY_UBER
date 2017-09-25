using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarUsuarioExcepcion : Exception
    {

        public AgregarUsuarioExcepcion()
        {
        }

        public AgregarUsuarioExcepcion(string message)
        : base(message)
    {
        }

        public AgregarUsuarioExcepcion(string message, Exception inner)
        : base(message, inner)
    {
        }




    }
}
