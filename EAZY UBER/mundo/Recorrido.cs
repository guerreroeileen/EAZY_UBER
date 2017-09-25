using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    class Recorrido
    {
        private Double tarifa;
        private string fecha;
        private string hora;
        private Ruta ruta;
        //en el diagrama habiamos puesto 0..N pero creo que en un recorrido solo puedes usar un vehiculo
        private Vehiculo vehiculo;

        public Recorrido(double tarifa, string fecha, string hora, Vehiculo vehiculo, Ruta ruta)
        {
            this.tarifa = tarifa;
            this.fecha = fecha;
            this.hora = hora;
            this.ruta = ruta;
            this.vehiculo = vehiculo;
        }

        public double Tarifa { get => tarifa; set => tarifa = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
