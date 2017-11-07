using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Windows.Forms;
using mundo;
using EAZY_UBER;

namespace Controlador
{
    class Control_OfrecerCupo
    {
        private Inicio vPrinc;        
        private SistemaRecomendaciones sistema;
        private Control_UsuarioRecom cUsuarioReco;


        public Control_OfrecerCupo(Inicio vPrinc, SistemaRecomendaciones sistema, Control_UsuarioRecom cUsuarioReco) {
            this.vPrinc = vPrinc;
            this.sistema = sistema;
            this.cUsuarioReco = cUsuarioReco;

            //Assigna el evento registro a la accion de click del boton confirmar.
            vPrinc.panel_OfrecerCupo1.botonConfirmar.Click += evento_RegistroRecorrido;
        }


        /*
         * Evento para el boton confirmar registro de recorrido cuando un usuario recomienda un recorrido
         */
        private void evento_RegistroRecorrido(object sender, EventArgs e) {
               
            sistema.recomendarUsuarios( sistema.Estado_usuarioLogged.Recorridos[vPrinc.panel_OfrecerCupo1.comboBox1.SelectedIndex]);
            mostrarPUsuariosRecomendados();
        }

        /**
         * Actualiza el listBox de usuarios recomendados en el panel, y muestra el panel de usuarios recomendados
         * 
         * pre: Se debe llamar al metodo de recomendar usuarios.
         */
        private void mostrarPUsuariosRecomendados() {
            cUsuarioReco.actualizarPanelUsuarioRecom();
            vPrinc.panel_UsuarioRecomendado1.Visible = true;
            vPrinc.panel_RecorridoRecomendado1.Visible = false;
        }
    }
}
