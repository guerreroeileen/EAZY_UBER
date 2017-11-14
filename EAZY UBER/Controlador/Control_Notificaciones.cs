using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAZY_UBER;
using mundo;
using System.Windows.Forms;
using System.Diagnostics;

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
                notificaciones.listBoxNotificaciones.Items.Add(logueado.Notificaciones.ElementAt(i).Solicitante.Nombre + " " + logueado.Notificaciones.ElementAt(i).Solicitante.Apellido);
            }
            
    }



        private void evento_cambiarIndiceDeLaLista(object sender, EventArgs e)
        {
            //Acá se pone que pasa al cambiar de indice la lista
            String item = notificaciones.listBoxNotificaciones.SelectedItem.ToString();//Así se recupera el nombre de lo que esté en lista, en este caso usuarios
            int indice = notificaciones.listBoxNotificaciones.SelectedIndex;//Así se recupera el indice para operar con la lsita de notificaciones (solicitante)
            notificaciones.lblMensaje.Text = sistema.Estado_usuarioLogged.darNotificacion(indice).ToString();

        }

        private void evento_clickBotonEliminar(object sender, EventArgs e)
        {        
            // elimino la notificacion
            sistema.Estado_usuarioLogged.eliminarNotificacion(notificaciones.listBoxNotificaciones.SelectedIndex);
            // actualizo la lista
            notificaciones.listBoxNotificaciones.Items.Clear();
            actualizarListaNotificaciones();
            //mensaje al usuario
            MessageBox.Show("Notificacion eliminada");

        }
        private void evento_clickBotonDeclinar(object sender, EventArgs e)
        {
            //Acá se pone que pasa al oprimir el boton declinar
            

        }
        private void evento_clickBotonAceptar(object sender, EventArgs e)
        {
            Recorrido temporalReco = sistema.Estado_usuarioLogged.darNotificacion(notificaciones.listBoxNotificaciones.SelectedIndex).Recorrido;
            if (temporalReco != null && temporalReco.Cupo > 0)
            {
                //envio la notificacion al usuario que pidio el cupo diciendo que he aceptado
                temporalReco.Usuario.notificarUsuario(Notificacion.TIPO_ACEPTAR_SOLICITUD, sistema.Estado_usuarioLogged, temporalReco);
                //disminuyo la cantidad de cupos disponibles
                temporalReco.Cupo--;
                //incrementa el dinero generado en este recorrido     
               temporalReco.DineroGenerado= temporalReco.DineroGenerado+ temporalReco.Tarifa;
                
                //mensaje al usuario
                MessageBox.Show("Notificacion aceptada exitosamente");

                //si decidimos implementar las calificaciones, aqui iria la agregada a los usuarios aceptados
            }
            else
            {
                MessageBox.Show("No tienes cupos disponibles para ofrecer");
            }

            


        }
        internal void cerrar()
        {
            notificaciones.Close();
        }
    }
}
