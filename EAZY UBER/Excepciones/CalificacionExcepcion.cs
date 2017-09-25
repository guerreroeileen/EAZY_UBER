using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CalificacionExcepcion: Exception
    {
        public CalificacionExcepcion()
        {
        }

        public CalificacionExcepcion(string message)
        : base(message)
        {
        }

        public CalificacionExcepcion(string message, Exception inner)
        : base(message, inner){
        }



    }
}
