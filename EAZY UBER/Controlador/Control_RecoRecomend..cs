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

            pRecomend.lbRecorridos.SelectedIndexChanged += evento_selecionRecorrido;
        }

        private void evento_selecionRecorrido(object sender, EventArgs e) {
            int iReco = pRecomend.lbRecorridos.SelectedIndex;
            String ruta = pRecomend.lbRecorridos.SelectedItem.ToString();//Se sca el nombre de la ruta
            if (iReco >= 0)
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
                pRecomend.lbHora.Text = reco.Fecha.ToLongDateString();

                pRecomend.lbPlaca.Text = reco.Vehiculo.Placa;
                pRecomend.lbColor.Text = reco.Vehiculo.Color;
                pRecomend.lbLinea.Text = reco.Vehiculo.Linea;
                pRecomend.lbMarca.Text = reco.Vehiculo.Marca;

                //Pinta ruta en el mapa
                cInicio.pintarRutaMapa(reco.Ruta);
            }
            else {
                pRecomend.clear();
            }
        }

        /**
         * Metodo que refresca el listBox del panel de Recorridos Recomendados.
         * 
         * pre: Se debe llamar primero al sistema para que actualice el estado.
         * */
        public void refreshPanelRecorridosRecomend() {
            if (sistema.Estado_recorridosRecomendados != null){
                pRecomend.lbRecorridos.DataSource = sistema.Estado_recorridosRecomendados.Select(x => x.Value.Ruta.Nombre);
            }
            else {
                pRecomend.lbRecorridos.Items.Clear();
            }
        }
    }
}
