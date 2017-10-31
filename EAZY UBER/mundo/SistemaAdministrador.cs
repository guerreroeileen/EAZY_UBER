using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Diagnostics;

namespace mundo
{
     public  class SistemaAdministrador
    {
        public static readonly string[] COLOR = { "Azul", "Morado", "Verde" };
        public static readonly string[] MARCA = { "Renoult", "Ferrari", "Mazda", "Citroen", "Kia", "Hyundai", "Toyota", "Porsche" };

        private SistemaRecomendaciones sistemaRecomendaciones;

        public SistemaAdministrador(SistemaRecomendaciones sistemaRecomendaciones) {
            this.sistemaRecomendaciones = sistemaRecomendaciones;
        }

        public SistemaRecomendaciones SistRecomendaciones { get => sistemaRecomendaciones; set => sistemaRecomendaciones = value; }

        /*
         * Metodo que genera aleatoriamente valores para el usuario y sus atributos
         * 
         * se debe debuguear el metodo por que puede que falle criticamente
         */
        public List<Usuario> generarBaseDatos(int numUsuario) {
            List<Usuario> nuevaBD = new List<Usuario>();
            int vc = 'A', vd = 'A', vu = 'A', vNum=100;
            String[] nombres = { "Luis Castro", "Daniel", "Desireé", "Nicolás", "María", "Estela", "Javier", "Alfredo", "José", "Salvador", "César", "Alonso", "Alicia", "Eva", "Josefina", "María del Rocío", "Chaim", "Yolanda", "Cecilia", "Orona", "Ydolina", "Rafael", "Alberto", "Chi", "Esteban", "Daniel", "Chong", "Jorge", "Santiago", "Nájar", "Paulina", "Cervantes", "Ricardo", "Favila", "Darío", "Carlos", "María de los Ángeles", "Gabriel", "Ángel", "Julio", "Rogelio", "Claudia", "Anuar", "Sigfrido", "Aristeo", "Óscar", "Saúl", "José", "Eduardo", "Natalia", "Baltazar", "José", "Luis", "Sergio", "Ignacio", "José", "Luis", "Héctor", "Alejandro", "Luis", "Abel", "Patricia", "Jesús", "Arturo", "Gilberto", "Nolasco", "José", "Luis", "Claudia", "Valeria", "Roberto De la Medina", "Mario" , "Marco", "Andrea", "Giuseppe", "Antonio", "Luca", "Alessandro", "Anna", "Giovanni", "Roberto", "Stefano", "Maria", "Sara", "Paolo", "Laura", "Michele", "Fabio", "Davide", "Valentina", "Matteo", "Salvatore", "Massimo", "Daniele.Giulia", "Simone", "Antonella", "Chiara", "Luigi", "Silvia", "Mario", "Daniela", "Vincenzo", "Federica", "Alessandra", "Elena", "Paola", "Stefania", "Angela", "Nicola", "Roberta" };
            String[] apellidos = { "Rossi", "Esposito", "Russo", "Romano", "Bianchi", "Ferrari", "Marino", "Greco", "Giordano", "De Luca, Bruno", "Rizzo", "Gallo", "Ricci", "Caruso", "Costa", "Mancini", "Ferrara", "Leone", "Colombo", "Santoro", "Conti", "Coppola", "Amato", "Bianco", "Vitale", "Lombardi", "Fiore", "Conte", "Messina", "Parisi", "De Rosa", "D’angelo", "Rinaldi", "De Santis", "Lombardo", "Martini", "Longo", "Serra", "Gentile", "Giuseppe", "Sorrentino", "Moretti", "De Angelis", "Palumbo", "Fontana", "Napoli", "Ferri", "Caputo", "Grasso", "Ferraro", "Barone", "Sanna", "Marini", "Romeo", "Franco", "Basile", "Roma", "Pellegrino", "Salvatore", "Mariani", "Pagano", "Martino", "Carbone", "Martinelli", "De Simone", "D’amico", "Ruggiero", "Morelli", "Testa", "Orlando", "Monti", "Bella", "Piras", "Grimaldi", "Fusco", "Francesco", "Barbieri", "Milano", "Marco", "Neri", "Antonio", "Rosa", "Silvestri", "Galli", "Palmieri", "Napolitano", "Marchetti", "Catalano", "Calabrese", "Salerno","Cirillo", "Mauro", "Villa", "Carta", "Farina", "D’agostino", "Simone", "Luca", "Pace"};

            Random aleatorio = new Random();

            for (int i = 0; i < numUsuario; i++) {
                Usuario aux = new Usuario(nombres[aleatorio.Next(0, (nombres.Length-1))], apellidos[aleatorio.Next(0, (apellidos.Length-1))], "generado@" + i, 3022500000 + i+"", "", "usuario" + i, new Random().Next(0, 1)==0?false:true);

                //Genera vehiculos para el usuario
                int numVehiculos = new Random().Next(1, 4);
                for (int v = 0; v < numVehiculos; v++) {
                    aux.registrarVehiculo((char)vc+(char)vd+(char)vu+vNum+"", COLOR[new Random().Next(0,COLOR.Length-1)], MARCA[new Random().Next(0, MARCA.Length-1)], "GeneradoPorComputadora");
                    vu++;
                    vNum++;
                    if (vNum > 999) { v = 100; }
                    if (vu > 'Z') { vd++; vu = 'A'; }
                    if (vd > 'Z') { vc++; vd = 'A'; }
                }

                //Genera rutas para el usuario
                int numRutas = new Random().Next(1, 10);
                for (int r = 0; r < numRutas; r++) {
                    int haciaIcesi = new Random().Next(0, 1);
                    List<Tuple<double, double>> puntos = new List<Tuple<double, double>>();
                    int numPuntos = new Random().Next(5, 13);
                    
                    int avance = 0;
                    //Genera los puntos intermedios de la ruta.
                    for (int p = 0; p < numPuntos; p++) {
                        double lat = (((double)(new Random((int)DateTime.Now.Ticks).Next(502511 - avance, 504511 - avance))) / 1000000.0) + 3.0;
                        double lng = -1*((((double)(new Random((int)DateTime.Now.Ticks).Next(460037, 558263))) / 1000000.0) + 76.0);
                        Debug.WriteLine("lat: {0} lng: {1}", lat, lng);
                        puntos.Add(new Tuple<double, double>(lat, lng));
                        avance += (int)((3.514511-3.344655)/((double)numPuntos)*1000000);
                    }
                    Debug.WriteLine("");
                    //Registra la ruta si se dirige a Icesi 
                    if (haciaIcesi == 1)
                    {
                        aux.registrarRuta("ruta" + r, new Tuple<double, double>((((double)(new Random().Next(504511 + 2000, 524511+ 2000)) / 1000000.0) + 3.0),
                            (((double)(-1*new Random().Next(460037, 558263))) / 10000000.0) - 76.0),
                            new Tuple<double, double>(3.34120,-76.53093),
                            puntos,"La descripcion de la ruta");
                    }
                    else { //Registra la ruta desde icesi
                        
                        puntos.Reverse();
                        aux.registrarRuta("ruta" + r, new Tuple<double, double>(3.34120, -76.53093),
                            new Tuple<double, double>(((((double)(new Random().Next(504511 - 20000, 524511 - 20000))) / 1000000.0) + 3.0),
                            (((double)(-1*new Random().Next(460037, 558263))) / 1000000.0) - 76),
                            puntos, "La descripcion de la ruta");
                    }

                }

                //Genera los recorridos
                int avDia = 0;
                if (aux.Rutas.Count > 0 && aux.Vehiculos.Count > 0) {
                    int numReco = new Random().Next(0, 5);
                    for (int r = 0; r < numReco; r++)
                    {

                        try
                        {
                            aux.registrarRecorrido(new Random().Next(1, 5) * 1000, new Random().Next(1, 4),
                                new DateTime(DateTime.Now.Year, DateTime.Now.Month+1, new Random().Next(1,30), new Random().Next(6, 14), new Random().Next(1, 59), DateTime.Now.Second),
                                aux.Vehiculos[new Random().Next(0, aux.Vehiculos.Count - 1)],
                                aux.Rutas[new Random().Next(0, aux.Rutas.Count - 1)]);
                        }
                        catch(AgregarRecorridoExcepcion e) {
                            foreach (bool b in e.CamposF) { Debug.WriteLine(b); }
                        }
                        avDia++;
                    }
                }

                nuevaBD.Add(aux);
            }

            return nuevaBD;
        }
    }
}
