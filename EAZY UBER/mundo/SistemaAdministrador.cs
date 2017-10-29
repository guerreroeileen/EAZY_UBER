using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    class SistemaAdministrador
    {
        public static readonly string[] COLOR = { "Azul", "Morado", "Verde" };
        public static readonly string[] MARCA = { "Renoult", "Ferrari", "Mazda", "Citroen", "Kia", "Hyundai", "Toyota", "Porsche" };
        private SistemaRecomendaciones sistRecomendaciones;

        public SistemaAdministrador(SistemaRecomendaciones sistemaRecomendaciones) {
            this.sistRecomendaciones = sistRecomendaciones;
        }

        /*
         * Metodo que genera aleatoriamente valores para el usuario y sus atributos
         * 
         * se debe debuguear el metodo por que puede que falle criticamente
         */
        public List<Usuario> generarBaseDatos(int numUsuario) {
            List<Usuario> nuevaBD = new List<Usuario>();
            int vc = 'A', vd = 'A', vu = 'A', vNum=100;
            for (int i = 0; i < numUsuario; i++) {
                Usuario aux = new Usuario("Usuario" + i, "Apellido" + i, "generado" + i, 3022500000 + i+"", "", "Usuario" + i, new Random().Next(0, 1)==0?false:true);

                //Genera vehiculos para el usuario
                int numVehiculos = new Random().Next(0, 4);
                for (int v = 0; i < numVehiculos; v++) {
                    aux.registrarVehiculo((char)vc+(char)vd+(char)vu+vNum+"", COLOR[new Random().Next(0,COLOR.Length-1)], MARCA[new Random().Next(0, MARCA.Length-1)], "");
                    vu++;
                    vNum++;
                    if (vNum > 999) { v = 100; }
                    if (vu > 'Z') { vd++; vu = 'A'; }
                    if (vd > 'Z') { vc++; vd = 'A'; }
                }

                //Genera rutas para el usuario
                int numRutas = new Random().Next(0, 3);
                for (int r = 0; r < numRutas; r++) {
                    int haciaIcesi = new Random().Next(0, 1);
                    List<Tuple<double, double>> puntos = new List<Tuple<double, double>>();
                    int numPuntos = new Random().Next(5, 30);
                    int avance = 0;
                    //Genera los puntos intermedios de la ruta.
                    for (int p = 0; p < numPuntos; p++) {
                        puntos.Add(new Tuple<double, double>((((double)(new Random().Next(504511+avance, 524511+avance)))/1000000)+3.0, (((double)(new Random().Next(460037, 558263)))/1000000)-76));
                        avance += 20000;
                    }
                    //Registra la ruta si se dirige a Icesi 
                    if (haciaIcesi == 1)
                    {
                        aux.registrarRuta("ruta" + r, new Tuple<double, double>((((double)(new Random().Next(504511 - 20000, 524511- 20000)) / 1000000) + 3.0), (((double)(new Random().Next(460037, 558263))) / 1000000) - 76),
                            new Tuple<double, double>(3.34120,-76.53093),puntos,"La descripcion de la ruta");
                    }
                    else { //Registra la ruta desde icesi
                        
                        puntos.Reverse();
                        aux.registrarRuta("ruta" + r, new Tuple<double, double>(3.34120, -76.53093),
                            new Tuple<double, double>((((double)(new Random().Next(504511 - 20000, 524511 - 20000)) / 1000000) + 3.0), (((double)(new Random().Next(460037, 558263))) / 1000000) - 76),
                            puntos, "La descripcion de la ruta");
                    }

                }

                //Genera los recorridos
                int avDia = 0;
                if (aux.Rutas.Count > 0 && aux.Vehiculos.Count > 0) {
                    int numReco = new Random().Next(0, 2);
                    for (int r = 0; r < numReco; r++)
                    {
                        aux.registrarRecorrido(new Random().Next(0, 5) * 1000, new Random().Next(0, 4),
                            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + avDia, DateTime.Now.Hour + new Random().Next(-5, 5), DateTime.Now.Minute + new Random().Next(-20, 20), DateTime.Now.Second),
                            aux.Vehiculos[new Random().Next(0, aux.Vehiculos.Count - 1)],
                            aux.Rutas[new Random().Next(0, aux.Rutas.Count - 1)]);
                        avDia++;
                    }
                }

            }

            return nuevaBD;
        }
    }
}
