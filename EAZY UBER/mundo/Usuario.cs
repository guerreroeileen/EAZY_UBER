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



        //relaciones
        private List<Ruta> rutas;
        private List<Vehiculo> vehiculos;
        private List<Recorrido> recorridos;




        public Usuario(string nombre, string apellido, string celular, string contrasenia, string correo, string rutaFoto)
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



        public Boolean registrarRuta()
        {
            bool registrado = false;


            // no lo hice porque aun no tengo claro como vas a trabajar la ruta



            return registrado;
        }

        public Boolean registrarRecorrido(Double tarifa, string fecha, string hora, Vehiculo vehiculo, Ruta ruta)
        {
            bool registrado = false;
            if (hora.Length < 1)
            {
                throw new AgregarRecorridoExcepcion("Debe agregar la hora de salida");
            }
            else if (fecha.Length < 1)
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
                throw new AgregarVehiculoExcepcion("El vehiculo que esta intentando eliminar no existe");
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
    }
}
