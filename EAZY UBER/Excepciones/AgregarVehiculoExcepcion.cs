using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarVehiculoExcepcion : Exception
    {


        public AgregarVehiculoExcepcion()
        {
        }

        public AgregarVehiculoExcepcion(string message)
        : base(message)
    {
        }

        public AgregarVehiculoExcepcion(string message, Exception inner)
        : base(message, inner)
    {
        }



    }
}
