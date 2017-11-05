using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mundo;
using Excepciones;
using EAZY_UBER;

namespace Controlador
{
    class Control_BuscarRuta
    {
        private Inicio vPrin;
        private SistemaRecomendaciones sistema;
        private Control_RecoRecomend cRecorrido;

        public Control_BuscarRuta(Inicio vPrin, SistemaRecomendaciones sistema, Control_RecoRecomend cRecorrido) {
            this.vPrin = vPrin;
            this.sistema = sistema;
            this.cRecorrido = cRecorrido;

            vPrin.panel_BuscarRuta1.botonConfirmar.Click += evento_confirmarBuscarRuta;
        }

        private void evento_confirmarBuscarRuta(object sender, EventArgs e) {            
            var pRuta = vPrin.panel_BuscarRuta1;

            Tuple<double, double> ubica = sistema.Estado_usuarioLogged.Ubicacion;

            DateTime fecha = new DateTime(pRuta.dateTimePicker1.Value.Year,
                                            pRuta.dateTimePicker1.Value.Month,
                                            pRuta.dateTimePicker1.Value.Day,
                                            pRuta.dateTimePicker2.Value.Hour,
                                            pRuta.dateTimePicker2.Value.Minute,
                                            pRuta.dateTimePicker2.Value.Second);

            if (pRuta.txbRadio.Text.SequenceEqual(""))
            {
                if (ubica == null) { MessageBox.Show("Debes asignar un punto de referencia para la busqueda\nDando click en el globo naranja de tu perfil."); }
                else {
                    sistema.recomendarRecorridos(ubica, fecha);
                    //refrescar info de panel recorridosRecomendados y luego mostrar
                    mostrarPRecorridos();
                }
            }
            else
            {
                //llamar recomendacion con radio
                int radio = -1;
                try { radio = int.Parse(pRuta.txbRadio.Text); } catch { MessageBox.Show("El valor del radio debe ser numerico"); }
                if (ubica == null) { MessageBox.Show("Debes asignar un punto de referencia para la busqueda\nDando click en el globo naranja de tu perfil."); }
                else {
                    sistema.recomendarRecorridos(ubica,radio, fecha);
                    //refrescar info de panel recorridosRecomendados y luego mostrar
                    mostrarPRecorridos();
                    //sistema.recomendarRecorridos(ubica, radio);
                }
            
            }
            
        }

        private void mostrarPRecorridos() {
            vPrin.panel_RecorridoRecomendado1.Visible = true;
            vPrin.panel_UsuarioRecomendado1.Visible = false;

            cRecorrido.refreshPanelRecorridosRecomend();
        }
    }
}
