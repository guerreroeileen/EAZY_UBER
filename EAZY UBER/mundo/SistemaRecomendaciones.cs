using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using mundo.Properties;
using System.Diagnostics;


namespace mundo
{ 
    
    public class SistemaRecomendaciones 
    {
        private Dictionary<Usuario, Recorrido> estado_recorridosRecomendados;
        private Usuario estado_usuarioVisualizado;
        private List<Usuario> estado_usuariosRecomendados;
        private Usuario estado_usuarioLogged;

        private List<Usuario> usuarios;

        
        
        public SistemaRecomendaciones() {
            estado_recorridosRecomendados=null;
            estado_usuarioVisualizado=null;
            estado_usuariosRecomendados=null;
            estado_usuarioLogged=null;

            usuarios= new List<Usuario>();            
            cargarDB();
            if (!usuarios.Where(a => a.Celular.Equals("0000000000")).Any())
            {
                usuarios.Add(new Usuario("prueba", "equipo", "correo@", "0000000000", "", "password", true));
                Debug.WriteLine("Agrego");
            }
                
              
        }

        /* Agrega un usuario al sistema
         * 
         * arroja excepcion si hay alguna irregularidad en la entrada
         * excepcion: tiene un arreglo de enteros, 0 si esta bien 1 si no
         *      INDICES EN EL ARREGLO
         *      nombre: indice 0
         *      apellido: indice 1
         *      correo: 2
         *      celular: 3
         *      rutafoto: 4
         *      contrasena: 5
         *     
         */
        public Boolean registrarUsuario(string nombre, string apellido, string correo, string celular, string rutaFoto, string contrasena, string confContrasena, bool recomendar)
        {
            int[] controlRegistro = new int[6];
            controlRegistro[0] = (nombre == null) ?  1: (nombre.Length < 3) ?  1 : 0;
            controlRegistro[1] = (apellido == null) ? 1 : (apellido.Length < 3) ? 1 : 0;
            controlRegistro[2] = (correo == null) ? 1 : (usuarios.Any(a => a.Correo.Equals(correo)) || !correo.Contains("@") || correo.Length < 3) ? 1 : 0;
            controlRegistro[3] = (celular == null) ? 1 : (usuarios.Any(a => a.Celular.Equals(celular)) || celular.Length != 10) ? 1 : 0;
            controlRegistro[5] = (contrasena == null || confContrasena == null) ? 1 : (contrasena.Length < 5 || !contrasena.Equals(confContrasena)) ? 1 : 0;
            if (controlRegistro.Any(a => a == 1))
                throw new AgregarUsuarioExcepcion(controlRegistro);
            usuarios.Add(new Usuario(nombre, apellido, correo, celular, rutaFoto, contrasena, recomendar));
            return true;
        }


        public Usuario darUsuario(string celular) {
            return usuarios.Find(x => x.Celular.Equals(celular));
        }

        /*
         * Metodo que recomienda lo primero 15 usuarios para un recorrido.
         * El criterio de ordenamiento es la distancia del usuario a la ruta.
         */
        public Boolean recomendarUsuarios(Recorrido recorrido) {
            List<Usuario> auxList = new List<Usuario>();
            foreach (Usuario u in usuarios) {
                if (u.Ubicacion != null) {
                    auxList.Add(u);
                }
            }
            Estado_usuariosRecomendados = auxList.Select(x => new { dist = distMinimaARuta(recorrido, x.Ubicacion), usu = x }).OrderBy(x => x.dist).Select(x => x.usu).Take(15).ToList();
            return true;
        }

        public Boolean recomendarRecorridos(Tuple<double, double> ubicacion, DateTime fecha) {

            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido>();

            foreach (Usuario u in usuarios)
            {
                if (!u.Celular.Equals(estado_usuarioLogged.Celular))
                {
                    List<Recorrido> recomendaciones = new List<Recorrido>();
                    foreach (Recorrido r in u.Recorridos)
                    {
                        if((fecha.Minute >= r.Fecha.Minute - 15)  && (fecha.Minute <= r.Fecha.Minute + 15))
                        recomendaciones.Add(r);
                    }

                    List<Recorrido> auxiliar = recomendaciones.Select(x => new { dist = distMinimaARuta(x, ubicacion), reco = x }).OrderBy(x => x.dist).Select(x => x.reco).ToList();
                    estado_recorridosRecomendados.Add(u, auxiliar[0]);


                }
            }

            var dictionary = from entry in estado_recorridosRecomendados orderby distMinimaARuta(entry.Value, ubicacion) ascending select entry;
            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido>();
            foreach (KeyValuePair<Usuario, Recorrido> kvp in dictionary)
            {
                estado_recorridosRecomendados.Add(kvp.Key, kvp.Value);

            }


            return estado_recorridosRecomendados.Count != 0;
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
                    if(auxiliar.Count>0)
                        estado_recorridosRecomendados.Add(u, auxiliar[0]);

                }
            }
            var dictionary = from entry in estado_recorridosRecomendados orderby distMinimaARuta(entry.Value, ubicacion) ascending select entry;
            estado_recorridosRecomendados = new Dictionary<Usuario, Recorrido>();
            foreach (KeyValuePair<Usuario, Recorrido> kvp in dictionary)
            {
                estado_recorridosRecomendados.Add(kvp.Key, kvp.Value);

            }


            return estado_recorridosRecomendados.Count != 0;
        }

        public Boolean loguearUsuario(string celular, string contrasena)
        {
            bool ingresar = Usuarios.Any(a => a.Celular == celular & a.Contrasenia == contrasena);
            estado_usuarioLogged = darUsuario(celular);
            return ingresar;
        }
         public Boolean desloguearUsuario()
        {
                        if (estado_usuarioLogged != null)
                            {
                estado_usuarioLogged = null;
                                return true;
                            }
                        else {
                                return false;
                            }
         }

        public Boolean cargarDB()
        {
            string ruta = Path.GetFullPath("base.bin");
            //Debug.WriteLine(ruta);
            if (File.Exists(ruta))
            {
                IFormatter format = new BinaryFormatter();
                FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
                usuarios = (List<Usuario>)format.Deserialize(stream);
                stream.Close();
                return true;
            }
            return false;

        }

        public Boolean guardarDB() {
            string ruta = Path.GetFullPath("base.bin");
            //Debug.WriteLine(ruta);
            IFormatter format = new BinaryFormatter();
            FileStream stream = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
            format.Serialize(stream, usuarios);
            stream.Close();
            return true;
        }

        private double distMinimaARuta(Recorrido recorrido, Tuple<double, double> punto) {
            double dist = double.MaxValue;
            double v1=0.0;
            double v2=0.0;
            double distAux=0.0;
            Tuple < double, double> ini = recorrido.Ruta.Inicio;
            Tuple<double, double> fin;
            if (recorrido.Ruta.Puntos != null) {
                foreach (var p in recorrido.Ruta.Puntos)
                {
                    fin = p;
                    v1 = fin.Item1 - ini.Item1;
                    v2 = fin.Item2 - ini.Item2;
                    distAux = (Math.Abs((v2 * punto.Item1) + (v1 * punto.Item2) + ((ini.Item1 * v2) + (ini.Item2 * v1)))) / (Math.Sqrt((v2 * v2) + (v1 * v1)));
                    dist = Math.Min(dist, distAux);

                    ini = p;
                }
            }
            fin = recorrido.Ruta.Fin;
            v1 = fin.Item1 - ini.Item1;
            v2 = fin.Item2 - ini.Item2;
            distAux = (Math.Abs((v2 * punto.Item1) + (v1 * punto.Item2) + ((ini.Item1 * v2) + (ini.Item2 * v1)))) / (Math.Sqrt((v2 * v2) + (v1 * v1)));
            dist = Math.Min(dist, distAux);
            
            return dist;
        }

        public Dictionary<Usuario, Recorrido> Estado_recorridosRecomendados { get => estado_recorridosRecomendados; set => estado_recorridosRecomendados = value; }
        public Usuario Estado_usuarioVisualizado { get => estado_usuarioVisualizado; set => estado_usuarioVisualizado = value; }
        public List<Usuario> Estado_usuariosRecomendados { get => estado_usuariosRecomendados; set => estado_usuariosRecomendados = value; }
        public Usuario Estado_usuarioLogged { get => estado_usuarioLogged; set => estado_usuarioLogged = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
    }
}
