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
        public Control_RecoRecomend(panel_RecorridoRecomendado pRecomend, SistemaRecomendaciones sistema) {
            this.sistema = sistema;
            this.pRecomend = pRecomend;

            pRecomend.lbRecorridos.SelectedIndexChanged += evento_selecionRecorrido;
        }

        private void evento_selecionRecorrido(object sender, EventArgs e) {
            int iReco = pRecomend.lbRecorridos.SelectedIndex;
            if (iReco >= 0) {
                //como cojones XD
            }
        }

        public void refreshPanelRecorridosRecomend() {
            pRecomend.lbRecorridos.DataSource = sistema.Estado_recorridosRecomendados.Select(x => x.Value.Ruta.Nombre);
        }
    }
}
