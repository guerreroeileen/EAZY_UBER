using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mundo;
using EAZY_UBER;

namespace Controlador
{
    class Control_Administrador
    {
      
        public event delegado1 eventoQueSeNecesite;
    
        private SistemaRecomendaciones sistema;
        
        private Administrador admon;

        public Control_Administrador(Administrador admen, SistemaRecomendaciones sis)
        {
            
            admon = admen;
            sistema = sis;


            //LLENADO DE DATOS GENERALES

            //cantidad de users registrados
            admen.labelUsuariosRegistrados.Text = ""+sis.Usuarios.Count();
            //carros totales
            int carrosTotales = 0;
            for (int i =0; i< sis.Usuarios.Count; i++)
            {
                carrosTotales = carrosTotales + sis.Usuarios.ElementAt(i).Vehiculos.Count;
            }
            admen.labelAutosRegistrados.Text = "" + carrosTotales;
            //recorridos registrados
            int recorridosTotales = 0;
            for (int i = 0; i < sis.Usuarios.Count; i++)
            {
                recorridosTotales = recorridosTotales + sis.Usuarios.ElementAt(i).Recorridos.Count;
            }
            admen.labelRecorridosRegistrados.Text = "" + recorridosTotales;
            //usuarios con auto
            int usuariosConAuto = 0;
            for (int i = 0; i < sis.Usuarios.Count; i++)
            {
                if ( sis.Usuarios.ElementAt(i).Vehiculos.Count > 0)
                {
                    usuariosConAuto = usuariosConAuto + sis.Usuarios.ElementAt(i).Vehiculos.Count;
                }
                
            }
            admen.labelUsuariosAuto.Text = "" + usuariosConAuto;

            //usuarios sin auto
            admen.labelUsuariosSinAuto.Text = "" + (sis.Usuarios.Count - usuariosConAuto);

            for (int i =0; i < sis.Usuarios.Count; i++)
            {
                admen.listUsuariosRegistrados.Items.Add(sis.Usuarios.ElementAt(i).Celular);
            }



            admon.Show();



            admon.addHandlerCambiarDatos(cambiarObejeto);


        }

        public void cambiarObejeto(Object sender)
        {
            admon.panel_PerfilUsuario1.lbNombre.Text = sistema.darUsuario(admon.listUsuariosRegistrados.Text).Nombre;
        }




        internal void cerrar()
        {
            admon.Close();
            
        }


    }
}
