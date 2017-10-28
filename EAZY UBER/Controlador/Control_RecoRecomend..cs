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
            if (iReco >= 0)
            {
                Usuario usua = null;    //Lo mismo ->Daniel 
                Recorrido reco = null; //poner el recorrido en la posicion iReco-> Daniel soluciona esto

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
                //hacer clear
            }
        }

        /**
         * Metodo que refresca el listBox del panel de Recorridos Recomendados.
         * 
         * pre: Se debe llamar primero al sistema para que actualice el estado.
         * */
        public void refreshPanelRecorridosRecomend() {
            if (sistema.Estado_recorridosRecomendados != null)
            {
                pRecomend.lbRecorridos.DataSource = sistema.Estado_recorridosRecomendados.Select(x => x.Value.Ruta.Nombre);
            }
            else {
                pRecomend.lbRecorridos.Items.Clear();
            }
        }
    }
}
