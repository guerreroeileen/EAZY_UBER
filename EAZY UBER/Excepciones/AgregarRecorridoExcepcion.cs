using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarRecorridoExcepcion : Exception
    {
        bool[] camposF;
        public AgregarRecorridoExcepcion(bool[] camposF)
        {
            this.camposF = camposF;
        }

        public AgregarRecorridoExcepcion(string message)
        : base(message)
    {
        }

        public AgregarRecorridoExcepcion(string message, Exception inner)
        : base(message, inner)
    {
        }

        public bool[] CamposF { get => camposF; }
    }
}
