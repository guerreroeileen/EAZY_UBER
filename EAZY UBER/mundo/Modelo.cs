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

        public Boolean recomendarRecorridos(Tuple<double, double> ubicacion) {
            List<Recorrido> recomendaciones = new List<Recorrido>();
            foreach (Usuario u in usuarios) {
                foreach (Recorrido r in u.Recorridos) {
                    recomendaciones.Add(r);
                }
            }

            var auxiliar = recomendaciones.Select(x => new { dist = distMinimaARuta(x, ubicacion), reco = x }).OrderBy(x=>x.dist).Select(x=>x.reco);
            recomendaciones = auxiliar.ToList();
            return true;
        }

        public Boolean recomendarRecorridos(Tuple<double, double> ubicacion, double radio)
        {
            List<Recorrido> recomendaciones = new List<Recorrido>();
            foreach (Usuario u in usuarios)
            {
                foreach (Recorrido r in u.Recorridos)
                {
                    recomendaciones.Add(r);
                }
            }

            var auxiliar = recomendaciones.Select(x => new { dist = distMinimaARuta(x, ubicacion), reco = x }).Where(x=>x.dist<=radio).OrderBy(x => x.dist).Select(x => x.reco);
            
            return true;
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
