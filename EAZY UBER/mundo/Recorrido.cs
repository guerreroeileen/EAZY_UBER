using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    [Serializable]
    public class Recorrido
    {
        private Double tarifa;
        private Double dineroGenerado;
        private int cupo;
        private DateTime fecha;        
        private Ruta ruta;
        private Vehiculo vehiculo;

        public Recorrido(double tarifa, int cupo, DateTime fecha, Vehiculo vehiculo, Ruta ruta)
        {
            this.tarifa = tarifa;
            this.cupo = cupo;
            this.fecha = fecha;           
            this.ruta = ruta;
            this.vehiculo = vehiculo;
            dineroGenerado = 0.0;
        }

        public double Tarifa { get => tarifa; set => tarifa = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        
        public Ruta Ruta { get => ruta; set => ruta = value; }        
        public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public Double DineroGenerado { get => dineroGenerado; set => dineroGenerado = value; }
    }
}
