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
    class Control_UsuarioRecom
    {

        private panel_UsuarioRecomendado pUsuarioRecom;
        private SistemaRecomendaciones sistema;

        public Control_UsuarioRecom(panel_UsuarioRecomendado pUsuarioRecom, SistemaRecomendaciones sistema)
        {
            this.pUsuarioRecom = pUsuarioRecom;
            this.sistema = sistema;


        }

        private void evento_selectedUsuarioRecom(object sender, EventArgs e) {
            int iUserReco = pUsuarioRecom.lbxUsuarios.SelectedIndex;
            if (iUserReco > -1)
            {
                Usuario uReco = sistema.Estado_usuariosRecomendados[iUserReco];

                pUsuarioRecom.lbNombre.Text = uReco.Nombre;
                pUsuarioRecom.lbApellido.Text = uReco.Apellido;

                //falta actualizar la imagen
            }
            else {
                pUsuarioRecom.clear();
            }
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
