using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    public class Ruta
    {
        private string nombre;
        private Tuple <Double,Double> inicio;
        private Tuple<Double, Double> fin;
        private List <Tuple<Double, Double>> puntos;
        private string descripcion;

        public Ruta(string nombre, Tuple<double, double> inicio, Tuple<double, double> fin, List<Tuple<double, double>> puntos, string descripcion)
        {
            this.nombre = nombre;
            this.inicio = inicio;
            this.fin = fin;
            this.puntos = puntos;
            this.descripcion = descripcion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public Tuple<double, double> Inicio { get => inicio; set => inicio = value; }
        public Tuple<double, double> Fin { get => fin; set => fin = value; }
        public List<Tuple<double, double>> Puntos { get => puntos; set => puntos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
