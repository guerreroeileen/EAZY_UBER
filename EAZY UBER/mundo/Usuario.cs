using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    public class Usuario
    {


        //atributos
        private string nombre;
        private string apellido;
        private string celular;
        private string contrasenia;
        private string correo;
        private string rutaFoto;
        private List<Usuario> usuariosAceptados;
        private List<Usuario> usuariosPorAceptar;
        private Dictionary<String, int> calificadores;
        private Tuple<double, double> ubicacion;


        //relaciones
        private List<Ruta> rutas;
        private List<Vehiculo> vehiculos;
        private List<Recorrido> recorridos;




        public Usuario(string nombre, string apellido, string celular, string contrasenia, string correo, string rutaFoto, Tuple <double,double> ubicacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.contrasenia = contrasenia;
            this.correo = correo;
            this.rutaFoto = rutaFoto;
            usuariosAceptados = new List<Usuario> ();
            usuariosPorAceptar = new List<Usuario>();
            calificadores = new Dictionary<string, int> ();
            this.ubicacion = ubicacion;


            //inicializacion de las relaciones
            rutas = new List<Ruta>();
            vehiculos = new List<Vehiculo>();
            recorridos = new List<Recorrido>();
        }

        public Boolean registrarVehiculo(string placa, string color, string modelo, string rutaFoto)
        {
            bool registrado= false;
            if (placa.Length<1 || color.Length<1 || modelo.Length<1 || rutaFoto.Length<1)
            {
                throw new AgregarVehiculoExcepcion("Debe llenar todos los campos");
            }
            else
            {
                vehiculos.Add(new Vehiculo(placa,color,modelo,rutaFoto) );
                registrado = true;
            }

            return registrado;
        }



        public Boolean registrarRuta(String nombre, Tuple<double, double> inicio, Tuple<double, double> fin, List<Tuple<double, double>> puntos, string descripcion) 
        {
            bool registrado = true;

            if (nombre != null) { throw new AgregarRutaExcepcion("Debe agregar el nombre de la ruta"); }
            if ((rutas.Find(x => x.Nombre.Equals(nombre))==null)){ throw new AgregarRutaExcepcion("El nombre de la ruta ya existe! Debe elegir otro nombre"); }
            if (inicio != null) { throw new AgregarRutaExcepcion("Debe agregar el nombre de la ruta"); }
            if (fin != null) { throw new AgregarRutaExcepcion("Debe agregar el nombre de la ruta"); }
            if (puntos != null) { throw new AgregarRutaExcepcion("Debe agregar el nombre de la ruta"); }
            if (descripcion == null) { descripcion=""; } //Descripcion puede ser opcional.. creo que siempre se retorna "" pero por si las moscas

            rutas.Add(new Ruta(nombre, inicio, fin, puntos, descripcion));  
            
            return registrado;
        }

        public Boolean registrarRecorrido(Double tarifa, DateTime fecha, DateTime hora, Vehiculo vehiculo, Ruta ruta)
        {
            bool registrado = false;
            if (hora==null)
            {
                throw new AgregarRecorridoExcepcion("Debe agregar la hora de salida");
            }
            else if (fecha==null)
            {
                throw new AgregarRecorridoExcepcion("Debe agregar una fecha de salida");
            }
            else if (vehiculo==null)
            {
                throw new AgregarRecorridoExcepcion("Debe agregar un vehiculo al recorrido");
            }
            else if (ruta ==null)
            {
                throw new AgregarRecorridoExcepcion("Debe agregar una ruta al recorrido");
            }
            else
            {
                recorridos.Add(new Recorrido(tarifa,fecha,hora,vehiculo, ruta));
                registrado = true;
            }
            
            return registrado;
        }
         
        
        public Boolean eliminarRuta(Ruta ruta)
        {
            Ruta rut = rutas.Find(x => x.Nombre.Equals(ruta.Nombre));
            if (rut == null) { return false; }
            return rutas.Remove(rut);           
        }

        public Boolean eliminarRecorrido(int index)
        {
            Recorrido removed = recorridos[index];
            return recorridos.Remove(removed);
            
        }

        //En el UML los parametros de que tipo son?
        public Boolean agregarCalificacion(Usuario calificador, int calificacion) {

            if (usuariosAceptados.Contains(calificador))
            {
                calificadores.Add(calificador.nombre, calificacion);
            }
            else
            {
                throw new CalificacionExcepcion("No se ha podido realizar la calificacion");
            }

            return calificadores.ContainsKey(calificador.Nombre);
        }

        public Boolean aceptarUsuario(Usuario user) {
            if (usuariosPorAceptar.Contains(user))
            {
                usuariosPorAceptar.Remove(user);
                usuariosAceptados.Add(user);
            }
            else {
                return false;
            }
            return true;
        }

        public double darCalificacion()
        {
            Double califica = 0;
            if (calificadores.Count() == 0)
            {
                califica = 5.0;
            }
            else
            {
                califica = calificadores.Values.Average();
            }
            return califica;
        }



        public Boolean eliminarVehiculo (string placa)
        {
            bool eliminado = false;
            if (vehiculos.Where(z=> z.Placa.Equals(placa)).First() != null)
            {
                vehiculos.Remove(vehiculos.Where(z => z.Placa.Equals(placa)).First());
                eliminado = vehiculos.Contains(vehiculos.Where(z => z.Placa.Equals(placa)).First());
            }
            else
            {
                throw new AgregarVehiculoExcepcion("El vehiculo que esta intentando eliminar no existe"); //por que esa exception?
            }
            
            return eliminado;
        }

        




        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Correo { get => correo; set => correo = value; }
        public string RutaFoto { get => rutaFoto; set => rutaFoto = value; }
        public Dictionary<string, int> Calificadores { get => calificadores; set => calificadores = value; }
        internal List<Usuario> UsuariosAceptados { get => usuariosAceptados; set => usuariosAceptados = value; }
        internal List<Usuario> UsuariosPorAceptar { get => usuariosPorAceptar; set => usuariosPorAceptar = value; }
        public List<Recorrido> Recorridos { get => recorridos; set => recorridos = value; }
        public Tuple<double, double> Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
