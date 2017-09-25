using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarRutaExcepcion: Exception
    {

        public AgregarRutaExcepcion()
        {
        }

        public AgregarRutaExcepcion(string message)
        : base(message)
    {
        }

        public AgregarRutaExcepcion(string message, Exception inner)
        : base(message, inner)
    {
        }




    }
}
