using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarRecorridoExcepcion : Exception
    {
        public AgregarRecorridoExcepcion()
        {
        }

        public AgregarRecorridoExcepcion(string message)
        : base(message)
    {
        }

        public AgregarRecorridoExcepcion(string message, Exception inner)
        : base(message, inner)
    {
        }




    }
}
