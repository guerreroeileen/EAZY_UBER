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
        private Dictionary<Usuario, Recorrido> estado_recorridosRecomendados;
        private Usuario estado_usuarioVisualizado;
        private List<Usuario> estado_usuariosRecomendados;
        private Usuario estado_usuarioLogged;

        private List<Usuario> usuarios;

        public Modelo() {
            Dictionary<Usuario, Recorrido> estado_recorridosRecomendados=null;
            Usuario estado_usuarioVisualizado=null;
            List<Usuario> estado_usuariosRecomendados=null;
            Usuario estado_usuarioLogged=null;

            List<Usuario> usuarios= new List<Usuario>();
        }

        public Boolean registrarUsuario(string nombre, string apellido, string celular, string contrasenia, string correo, string rutaFoto, Tuple <double,double> ubicacion) {

            if (nombre != null) { throw new AgregarUsuarioExcepcion("Debe ingresar nombre"); }
            if (apellido != null) { throw new AgregarUsuarioExcepcion("Debe ingresar apellido"); }
            if (celular != null) { throw new AgregarUsuarioExcepcion("Debe ingresar celular"); }
            if (contrasenia != null) { throw new AgregarUsuarioExcepcion("Debe ingresar contraseña"); }
            if (rutaFoto != null) { rutaFoto = ""; }
            if (correo != null) { throw new AgregarUsuarioExcepcion("Debe ingresar Correo Electronico"); }

            if ((usuarios.Find(x => x.Celular.Equals(celular)))!=null) {
                usuarios.Add(new Usuario(nombre, apellido, celular, contrasenia, correo, rutaFoto, ubicacion));                
            }
            
            return true;
        }

        public Usuario darUsuario(string celular) {
            return usuarios.Find(x => x.Celular.Equals(celular));
        }

        public Boolean recomendarRecorridos(Tuple<double, double> ubicacion) {
          
            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido> ();
            
            foreach (Usuario u in usuarios) {
                if (u.Ubicacion.Item1 != ubicacion.Item1 && u.Ubicacion.Item2 != ubicacion.Item2)
                {
                    List<Recorrido> recomendaciones = new List<Recorrido>();
                    foreach (Recorrido r in u.Recorridos)
                    {
                        recomendaciones.Add(r);
                    }

                    List<Recorrido> auxiliar = recomendaciones.Select(x => new { dist = distMinimaARuta(x, ubicacion), reco = x }).OrderBy(x => x.dist).Select(x => x.reco).ToList();
                    estado_recorridosRecomendados.Add(u, auxiliar[0]);

                    
                }
            }

           var dictionary= from entry in estado_recorridosRecomendados orderby distMinimaARuta(entry.Value, ubicacion) ascending select entry;
            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido>();
            foreach (KeyValuePair<Usuario, Recorrido> kvp in dictionary)
            {
                estado_recorridosRecomendados.Add(kvp.Key, kvp.Value);

            }


            return true;
        }

        public Boolean recomendarRecorridos(Tuple<double, double> ubicacion, double radio)
        {
         
            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido>();
            foreach (Usuario u in usuarios)
            {
                List<Recorrido> recomendaciones = new List<Recorrido>();
                if (u.Ubicacion.Item1 != ubicacion.Item1 && u.Ubicacion.Item2 != ubicacion.Item2)
                {
                    foreach (Recorrido r in u.Recorridos)
                    {
                        recomendaciones.Add(r);
                    }
                    List<Recorrido> auxiliar = recomendaciones.Select(x => new { dist = distMinimaARuta(x, ubicacion), reco = x }).Where(x => x.dist <= radio).OrderBy(x => x.dist).Select(x => x.reco).ToList();
                    estado_recorridosRecomendados.Add(u, auxiliar[0]);
                   
                }
            }
            var dictionary = from entry in estado_recorridosRecomendados orderby distMinimaARuta(entry.Value, ubicacion) ascending select entry;
            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido>();
            foreach (KeyValuePair<Usuario, Recorrido> kvp in dictionary)
            {
                estado_recorridosRecomendados.Add(kvp.Key, kvp.Value);

            }


            return true;
        }
        public Boolean recomendarPasajeros( Recorrido recorrido)
        {
            estado_usuariosRecomendados = usuarios.Where(x=>x.Celular.Equals(estado_usuarioLogged.Celular)).Select(x => new { dist = distMinimaARuta(recorrido, x.Ubicacion), usuario = x }).OrderBy(x => x.dist).Select(x => x.usuario).Take(9).ToList();
            return true;

        }
        public Boolean calificarUsuario (Usuario calificador,Usuario usuarioCalificado,int calificacion)
        {
            if (usuarioCalificado.UsuariosAceptados.Contains(calificador))
            {
                usuarioCalificado.agregarCalificacion(calificador, calificacion);
            }
            return usuarioCalificado.Calificadores.ContainsKey(calificador.Nombre);
        }

        public Boolean loguearUsuario(String celular) {
            Boolean logued = true;
            Usuario aux = usuarios.Find(x => x.Celular.Equals(celular));
            if (aux != null)            {
                estado_usuarioLogged = aux;
            }
            else {
                logued = false;
            }
            return logued;
        }

        public Boolean desloguearUsuario() {
            if (estado_usuarioLogged != null)
            {
                estado_usuarioLogged = null;
                return true;
            }
            else {
                return false;
            }
        }


        public double distMinimaARuta(Recorrido recorrido, Tuple<double, double> punto) {
            double dist = double.MaxValue;
            double v1=0.0;
            double v2=0.0;
            double distAux=0.0;
            Tuple < double, double> ini = recorrido.Ruta.Inicio;
            Tuple<double, double> fin;
            foreach (var p in recorrido.Ruta.Puntos) {
                fin = p;
                v1 = fin.Item1 - ini.Item1;
                v2 = fin.Item2 - ini.Item2;
                distAux = (Math.Abs((v2 * punto.Item1) + (v1 * punto.Item2) + ((ini.Item1 * v2) + (ini.Item2 * v1)))) / (Math.Sqrt((v2 * v2) + (v1 * v1)));
                dist = Math.Min(dist, distAux);

                ini = p;
            }
            fin = recorrido.Ruta.Fin;
            v1 = fin.Item1 - ini.Item1;
            v2 = fin.Item2 - ini.Item2;
            distAux = (Math.Abs((v2 * punto.Item1) + (v1 * punto.Item2) + ((ini.Item1 * v2) + (ini.Item2 * v1)))) / (Math.Sqrt((v2 * v2) + (v1 * v1)));
            dist = Math.Min(dist, distAux);
            
            return dist;
        }
       

    }
}
