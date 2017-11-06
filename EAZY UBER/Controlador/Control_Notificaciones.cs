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

        public Control_Notificaciones(Notificaciones notificaciones, SistemaRecomendaciones sistemaRecomendaciones)
        {
            this.notificaciones = notificaciones;
            this.notificaciones.Show();


            Usuario logueado = sistemaRecomendaciones.Estado_usuarioLogged;

            for (int i = 0; i < logueado.Notificaciones.Count; i++){
                notificaciones.listBoxNotificaciones.Items.Add(logueado.Notificaciones.ElementAt(i).Solicitante.Nombre +"");
            }



        }

        internal void cerrar()
        {
            notificaciones.Close();
        }
    }
}
