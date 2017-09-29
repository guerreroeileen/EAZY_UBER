using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace mundo
{
    public class Modelo
    {
        private Dictionary<Usuario, List<Recorrido>> estado_recorridosRecomendados;
        private Usuario estado_usuarioVisualizado;
        private List<Usuario> estado_usuariosRecomendados;
        private Usuario estado_usuarioLogged;

        private List<Usuario> usuarios;

        public Modelo() {
            Dictionary<Usuario, List<Recorrido>> estado_recorridosRecomendados=null;
            Usuario estado_usuarioVisualizado=null;
            List<Usuario> estado_usuariosRecomendados=null;
            Usuario estado_usuarioLogged=null;

            List<Usuario> usuarios= new List<Usuario>();
        }

        public Boolean registrarUsuario(string nombre, string apellido, string celular, string contrasenia, string correo, string rutaFoto) {

            if (nombre != null) { throw new AgregarUsuarioExcepcion("Debe ingresar nombre"); }
            if (apellido != null) { throw new AgregarUsuarioExcepcion("Debe ingresar apellido"); }
            if (celular != null) { throw new AgregarUsuarioExcepcion("Debe ingresar celular"); }
            if (contrasenia != null) { throw new AgregarUsuarioExcepcion("Debe ingresar contraseña"); }
            if (rutaFoto != null) { rutaFoto = ""; }
            if (correo != null) { throw new AgregarUsuarioExcepcion("Debe ingresar Correo Electronico"); }

            if ((usuarios.Find(x => x.Celular.Equals(celular)))!=null) {
                usuarios.Add(new Usuario(nombre, apellido, celular, contrasenia, correo, rutaFoto));                
            }
            
            return true;
        }

        public Usuario darUsuario(string celular) {
            return usuarios.Find(x => x.Celular.Equals(celular));
        }

        

    }
}
