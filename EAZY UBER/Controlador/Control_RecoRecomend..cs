using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAZY_UBER;
using mundo;

namespace Controlador
{
    class Control_RecoRecomend
    {
        private SistemaRecomendaciones sistema;
        private panel_RecorridoRecomendado pRecomend;
        private Control_Inicio cInicio;
        public Control_RecoRecomend(panel_RecorridoRecomendado pRecomend, SistemaRecomendaciones sistema, Control_Inicio cInicio) {
            this.sistema = sistema;
            this.pRecomend = pRecomend;
            this.cInicio = cInicio;

            pRecomend.lbRecorridos.SelectedIndexChanged += evento_seleccionRecorrido;
            pRecomend.btnDescartar.Click += evento_descartarRecorrido;
        }


        /*
         * Muestra la informacion del recorrido seleccionado
         */
        private void evento_seleccionRecorrido(object sender, EventArgs e) {
            int iReco = pRecomend.lbRecorridos.SelectedIndex;
            String ruta = pRecomend.lbRecorridos.SelectedItem.ToString();//Se sca el nombre de la ruta
            if (iReco >= 0 && sistema.Estado_recorridosRecomendados.Count>0)
            {
                
                //Una posible solución-Convertir el diccionario a una lista de KeyValuePair
              List  <KeyValuePair<Usuario, Recorrido>> xd = sistema.Estado_recorridosRecomendados.ToList();
                Usuario usua = xd [iReco].Key ;    
                Recorrido reco = xd[iReco].Value;
                //Otra posible solución---Se compara con la el nombr de la ruta ya que estos son los que estan en la list box

                 var objeto = from x in sistema.Estado_recorridosRecomendados where x.Value.Ruta.Equals(ruta) select x;
                // Usuario usua = objeto.First().Key;    
                // Recorrido reco = objeto.First().Value;

                //Otra propuesta de solucion -- Me parece buena
                KeyValuePair<Usuario, Recorrido> parOrdenadoDatos = sistema.Estado_recorridosRecomendados.FirstOrDefault(x => x.Value.Ruta.Equals(ruta));
               // Usuario usua = parOrdenadoDatos.Key;
                //Recorrido reco = parOrdenadoDatos.Value;




                pRecomend.lbNombre.Text = usua.Nombre;
                pRecomend.lbApellido.Text = usua.Apellido;
                pRecomend.lbCalificacion.Text = usua.darCalificacion() + "";

                pRecomend.lbTarifa.Text = reco.Tarifa + "";
                pRecomend.lbHora.Text = reco.Fecha.ToShortDateString();

                pRecomend.lbPlaca.Text = reco.Vehiculo.Placa;
                pRecomend.lbColor.Text = reco.Vehiculo.Color;
                pRecomend.lbLinea.Text = reco.Vehiculo.Linea;
                pRecomend.lbMarca.Text = reco.Vehiculo.Marca;

                //Pinta ruta en el mapa
                cInicio.pintarRutaMapa(reco.Ruta);

                pRecomend.btnDescartar.Enabled = true;
            }
            else {
                pRecomend.clear();
                pRecomend.btnDescartar.Enabled = false;
                cInicio.pintarRutaMapa(null);
            }
        }

        /*
         * Elimina el recorrido seleccionado que se descarta
         */
        public void evento_descartarRecorrido(object sender, EventArgs e) {
            if (sistema.Estado_recorridosRecomendados.Count > 0)
            {
                sistema.Estado_recorridosRecomendados.Remove(sistema.Estado_recorridosRecomendados.ToList()[pRecomend.lbRecorridos.SelectedIndex].Key);
                refreshPanelRecorridosRecomend();
            }
        }

        /*
         * Metodo que refresca el listBox del panel de Recorridos Recomendados.
         * 
         * pre: Se debe llamar primero al sistema para que actualice el estado.
         * */
        public void refreshPanelRecorridosRecomend() {
            if (sistema.Estado_recorridosRecomendados != null){
                pRecomend.lbRecorridos.Items.Clear();
                if (sistema.Estado_usuarioLogged.Rutas != null)
                {
                    foreach (var r in sistema.Estado_usuarioLogged.Rutas) { pRecomend.lbRecorridos.Items.Add(r.Nombre); }
                }
                cInicio.pintarRutaMapa(null);
                pRecomend.lbRecorridos.SelectedIndex = -1;
                pRecomend.lbRecorridos.Text = "";
            }
            else {
                pRecomend.lbRecorridos.Items.Clear();
            }
        }
    }
}
