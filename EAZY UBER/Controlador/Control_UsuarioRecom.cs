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
        private Recorrido recorridoReco;

        public Control_UsuarioRecom(panel_UsuarioRecomendado pUsuarioRecom, SistemaRecomendaciones sistema)
        {
            this.pUsuarioRecom = pUsuarioRecom;
            this.sistema = sistema;

            pUsuarioRecom.lbxUsuarios.SelectedIndexChanged += evento_selectedUsuarioRecom;
            pUsuarioRecom.btnDescartar.Click += evento_selectedUsuarioRecom;
            pUsuarioRecom.btnOfrecerCupo.Click += ofrecerCupo_Click;
            pUsuarioRecom.btnDescartar.Enabled = false;
            pUsuarioRecom.btnOfrecerCupo.Enabled = false;
        }

        public void setrecorrido(Recorrido rec)
        {
            recorridoReco = rec;
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
            if (sistema.Estado_usuariosRecomendados != null) {
            sistema.Estado_usuariosRecomendados.Remove(sistema.Estado_usuariosRecomendados[pUsuarioRecom.lbxUsuarios.SelectedIndex]);
            actualizarPanelUsuarioRecom();
                
            }
        }

        /*
         * Notifica al usuario que se desea oferecr un cupu
         */
        private void ofrecerCupo_Click(Object sender, EventArgs e)
        {
            int iUserReco = pUsuarioRecom.lbxUsuarios.SelectedIndex;
            if (iUserReco > -1)
            {
                Usuario uReco = sistema.Estado_usuariosRecomendados[iUserReco];
                uReco.notificarUsuario(Notificacion.TIPO_OFRECER_CUPO, sistema.Estado_usuarioLogged, recorridoReco);
                MessageBox.Show("Se ha ofrecido el cupo en el recorrido exitosamente");
            }
        }

        public void actualizarPanelUsuarioRecom() {
            if (sistema.Estado_usuariosRecomendados != null )
            {
                pUsuarioRecom.lbxUsuarios.Items.Clear();                
                foreach (var u in sistema.Estado_usuariosRecomendados)
                {
                    //Se quita el condicional de agregar el propio nombre al listBox ya que ya se modifico
                    //el método recomendarUsuarios en sistemaRecomendaciones
                    
                        pUsuarioRecom.lbxUsuarios.Items.Add(u.Nombre);
                    
                    
                }
                setrecorrido(sistema.Estado_recorrido);
                pUsuarioRecom.lbxUsuarios.SelectedIndex = -1;
                pUsuarioRecom.lbxUsuarios.Text = "";
                pUsuarioRecom.clear();
            }
            else {
                pUsuarioRecom.lbxUsuarios.Items.Clear();
            }
        }

    }
}
