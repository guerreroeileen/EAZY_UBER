using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mundo
{
    [Serializable]
    public class Notificacion
    {
        //usuario que envia la solicitud
        private Usuario solicitante;
        //tipo de solicitud
        private string tipo;
        //recorrido sobre el cual se esta realizando la solicitud
        private Recorrido recorrido;
        //tipos de solicitudes
        public const string TIPO_SOLICITAR_CUPO = "solicitarCupo";
        public const string TIPO_OFRECER_CUPO = "ofrecerCupo";
        public const string TIPO_RECHAZAR_SOLICITUD = "RechazarSOli";
        public const string TIPO_ACEPTAR_SOLICITUD = "AceptarSoli";
        /*Constructor
         * tipo: tipo de notificación que se va a enviar
         * solicitante: usuario que envia la notificación
         * recorrido: recorrido sobre el cual se esta gestionando la solicitud
         */
        public Notificacion(string tipo, Usuario solicitante, Recorrido recorrido)
        {
            this.tipo = tipo;
            this.solicitante = solicitante;
            this.recorrido = recorrido;
        }



        //devuelve el texto a mostrar en las notificaciones segun el tipo
        public override string ToString()
        {
            switch (tipo)
            {
                case TIPO_SOLICITAR_CUPO:
                    return "El usuario identificado como "+ solicitante.Nombre + " " + solicitante.Apellido + " desea un cupo en tu recorrido del " + 
                            recorrido.Fecha+ ". Para más información comunicate con el al námero de celular: " + solicitante.Celular;

                case TIPO_OFRECER_CUPO:
                    return "El usuario identificado como " + solicitante.Nombre + " " + solicitante.Apellido + " desea ofrecerte un cupo en uno de sus recorridos" +
                        ". Para más información comunicate con el al número de celular: " + solicitante.Celular;

                case TIPO_RECHAZAR_SOLICITUD:
                    return "El usuario identificado como " + solicitante.Nombre + " " + solicitante.Apellido + " ha rechazado tu solicitud";

                case TIPO_ACEPTAR_SOLICITUD:
                    return "El usuario identificado como " + solicitante.Nombre + " " + solicitante.Apellido + " ha aceptado tu solicitud."+
                            " Para más información comunícate con el al número de celular: " + solicitante.Celular;;
                default:
                    return "";
            }
        }
        //GET_SET
        public string Tipo { get => tipo; set => tipo = value; }
        public Usuario Solicitante { get => solicitante; set => solicitante = value; }
        public Recorrido Recorrido { get => recorrido; set => recorrido = value; }
    }
}
