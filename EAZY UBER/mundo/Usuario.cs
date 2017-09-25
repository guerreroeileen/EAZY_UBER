using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    class Usuario
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




        public Usuario(string nombre, string apellido, string celular, string contrasenia, string correo, string rutaFoto, List<Usuario> usuariosAceptados, List<Usuario> usuariosPorAceptar, Dictionary<string, int> calificadores)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.contrasenia = contrasenia;
            this.correo = correo;
            this.rutaFoto = rutaFoto;
            this.usuariosAceptados = usuariosAceptados;
            this.usuariosPorAceptar = usuariosPorAceptar;
            this.calificadores = calificadores;
            rutas = new List<Ruta>();
            vehiculos = new List<Vehiculo>();
            recorridos = new List<Recorrido>();
        }

        public Boolean registrarVehiculo()
        {
            bool registrado= false;






            return registrado;
        }



        public Boolean registrarRuta()
        {
            bool registrado = false;






            return registrado;
        }

        public Boolean registrarRecorrido()
        {
            bool registrado = false;






            return registrado;
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
