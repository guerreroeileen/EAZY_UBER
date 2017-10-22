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
        private DateTime fecha;        
        private Ruta ruta;
        //en el diagrama habiamos puesto 0..N pero creo que en un recorrido solo puedes usar un vehiculo
        private Vehiculo vehiculo;

        public Recorrido(double tarifa, DateTime fecha, Vehiculo vehiculo, Ruta ruta)
        {
            this.tarifa = tarifa;
            this.fecha = fecha;
            
            this.ruta = ruta;
            this.vehiculo = vehiculo;
        }

        public double Tarifa { get => tarifa; set => tarifa = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        
        public Ruta Ruta { get => ruta; set => ruta = value; }
    }
}
