using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;
using mundo;

namespace Controlador
{
    class Control_Notificaciones
    {
        private Notificaciones notificaciones;

        private Inicio vPrin;
        private SistemaRecomendaciones sistema;
        

       

        public Control_Notificaciones(Notificaciones notificaciones, SistemaRecomendaciones sistemaRecomendaciones)
        {
            this.notificaciones = notificaciones;
            this.notificaciones.Show();
            sistema = sistemaRecomendaciones;

            actualizarListaNotificaciones();
         
            notificaciones.btnAceptar.Click += evento_clickBotonAceptar;
            notificaciones.btnDeclinar.Click += evento_clickBotonDeclinar;
            notificaciones.btnEliminar.Click += evento_clickBotonEliminar;
            notificaciones.listBoxNotificaciones.SelectedIndexChanged += evento_cambiarIndiceDeLaLista;//Se le pasa el evento de cambiar Indice de la lista
        }


        public void actualizarListaNotificaciones()
        {
            Usuario logueado = sistema.Estado_usuarioLogged;

            for (int i = 0; i < logueado.Notificaciones.Count; i++)
            {
                notificaciones.listBoxNotificaciones.Items.Add(logueado.Notificaciones.ElementAt(i).Solicitante.Celular + "");
            }
            
    }



        private void evento_cambiarIndiceDeLaLista(object sender, EventArgs e)
        {
            //Acá se pone que pasa al cambiar de indice la lista
            String item = notificaciones.listBoxNotificaciones.SelectedItem.ToString();//Así se recupera el nombre de lo que esté en lista, en este caso usuarios
            int indice = notificaciones.listBoxNotificaciones.SelectedIndex;//Así se recupera el indice para operar con la lsita de notificaciones (solicitante)
            notificaciones.lblMensaje.Text = item;

        }

        private void evento_clickBotonEliminar(object sender, EventArgs e)
        {
            //Acá se pone que pasa al oprimir el boton eliminar
            
            sistema.Estado_usuarioLogged.eliminarNotificacion(notificaciones.listBoxNotificaciones.SelectedIndex);
            notificaciones.listBoxNotificaciones.Items.Clear();
            actualizarListaNotificaciones();

        }
        private void evento_clickBotonDeclinar(object sender, EventArgs e)
        {
            //Acá se pone que pasa al oprimir el boton declinar
            notificaciones.lblMensaje.Text = "Acá se cambia el mensaje" + "\n" + "Zapata es el mejor amigo de Eilen";

        }
        private void evento_clickBotonAceptar(object sender, EventArgs e)
        {
            sistema.darUsuario(notificaciones.listBoxNotificaciones.SelectedItem.ToString()).notificarUsuario(Notificacion.TIPO_ACEPTAR_SOLICITUD, sistema.Estado_usuarioLogged, sistema.Estado_usuarioLogged.darNotificacion(notificaciones.listBoxNotificaciones.SelectedIndex));
            
        }
        internal void cerrar()
        {
            notificaciones.Close();
        }
    }
}
