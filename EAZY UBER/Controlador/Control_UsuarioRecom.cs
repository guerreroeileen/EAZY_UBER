using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAZY_UBER;
using mundo;
using System.Diagnostics;

namespace Controlador
{
    class Control_UsuarioRecom
    {

        private panel_UsuarioRecomendado pUsuarioRecom;
        private SistemaRecomendaciones sistema;

        public Control_UsuarioRecom(panel_UsuarioRecomendado pUsuarioRecom, SistemaRecomendaciones sistema)
        {
            this.pUsuarioRecom = pUsuarioRecom;
            this.sistema = sistema;

            pUsuarioRecom.lbxUsuarios.SelectedIndexChanged += evento_selectedUsuarioRecom;
            pUsuarioRecom.btnDescartar.Click += evento_selectedUsuarioRecom;
            pUsuarioRecom.btnOfrecerCupo.Click += ofrecerCupo_Click;
        }

        private void evento_selectedUsuarioRecom(object sender, EventArgs e) {
            int iUserReco = pUsuarioRecom.lbxUsuarios.SelectedIndex;
            if (iUserReco > -1)
            {
                Usuario uReco = sistema.Estado_usuariosRecomendados[iUserReco];

                pUsuarioRecom.lbNombre.Text = uReco.Nombre;
                pUsuarioRecom.lbApellido.Text = uReco.Apellido;

                //falta actualizar la imagen
                pUsuarioRecom.btnDescartar.Enabled = true;
                pUsuarioRecom.btnOfrecerCupo.Enabled = true;

            }
            else {
                pUsuarioRecom.clear();
                pUsuarioRecom.btnDescartar.Enabled = false;
                pUsuarioRecom.btnOfrecerCupo.Enabled = false;

            }
        }

        private void evento_descartarUsuario(object sender, EventArgs e) {
            sistema.Estado_usuariosRecomendados.Remove(sistema.Estado_usuariosRecomendados[pUsuarioRecom.lbxUsuarios.SelectedIndex]);
            actualizarPanelUsuarioRecom();
        }

        /*
         * Notifica al usuario que se desea oferecr un cupu
         */
        private void ofrecerCupo_Click(Object sender, EventArgs e)
        {
            int iUserReco = pUsuarioRecom.lbxUsuarios.SelectedIndex;
            Usuario uReco = sistema.Estado_usuariosRecomendados[iUserReco];
            uReco.notificarUsuario(Notificacion.TIPO_OFRECER_CUPO, sistema.Estado_usuarioLogged, null);
            Debug.WriteLine("Se ofrecio un cupo" + "--size:" + uReco.Notificaciones.Count);
        }

        public void actualizarPanelUsuarioRecom() {
            if (sistema.Estado_usuariosRecomendados != null)
            {
                int i = 0;
                pUsuarioRecom.lbxUsuarios.DataSource = sistema.Estado_usuariosRecomendados.Select(x => { i++; return "Usuario " + i; });
            }
            else {
                pUsuarioRecom.lbxUsuarios.Items.Clear();
            }
        }

    }
}
