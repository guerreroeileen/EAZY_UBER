using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    class Vehiculo
    {
        private string placa;
        private string color;
        private string marca;
        private string linea;

        public Vehiculo(string placa, string color, string marca, string linea)
        {
            this.placa = placa;
            this.color = color;
            this.marca = marca;
            this.linea = linea;
        }

        public string Placa { get => placa; set => placa = value; }
        public string Color { get => color; set => color = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Linea { get => linea; set => linea = value; }
    }
}
