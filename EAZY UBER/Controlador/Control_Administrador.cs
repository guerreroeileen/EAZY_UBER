using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mundo;
using EAZY_UBER;
using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace Controlador
{
    class Control_Administrador
    { 
        private SistemaRecomendaciones sistema;    
        private Administrador admon;

        public Control_Administrador(Administrador admon, SistemaRecomendaciones sistema)
        {
            this.admon = admon;
            this.admon.FormClosing += Form1_FormClosing;
            this.sistema = sistema;
            this.admon.eventoCambiarDatos += cambiarObejeto;
            llenar_Datos();           
        }

        public void llenar_Datos()
        {
            //LLENADO DE DATOS GENERALES
            //cantidad de users registrados
            this.admon.labelUsuariosRegistrados.Text = "" + this.sistema.Usuarios.Count();
            //carros totales
            int carrosT = sistema.Usuarios.Aggregate(0, (a, b) => a + b.Vehiculos.Count); 
            this.admon.labelAutosRegistrados.Text = "" + carrosT;
            //recorridos registrados
            int recorridosTotales = sistema.Usuarios.Aggregate(0,(a,b)=> a+b.Recorridos.Count);
            this.admon.labelRecorridosRegistrados.Text = "" + recorridosTotales;
            //usuarios con auto
            int usuariosConAuto = 0;
            for (int i = 0; i < this.sistema.Usuarios.Count; i++)
            {
                if (this.sistema.Usuarios.ElementAt(i).Vehiculos.Count > 0)
                {
                    usuariosConAuto = usuariosConAuto + this.sistema.Usuarios.ElementAt(i).Vehiculos.Count;
                }

            }
            this.admon.labelUsuariosAuto.Text = "" + usuariosConAuto;
            //usuarios sin auto
            this.admon.labelUsuariosSinAuto.Text = "" + (this.sistema.Usuarios.Count - usuariosConAuto);


            var usuarios = sistema.Usuarios.Select(a => new { celular = a.Celular });
            foreach (var a in usuarios)
            {
                this.admon.listUsuariosRegistrados.Items.Add(a.celular);
            }
            admon.Show();

        }


        public void cambiarObejeto(Object sender)
        {
            //TODO
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Inicio ini = (Inicio) admon.Owner;
            ini.panel_LogIn1.limpiarTextos();
            admon.Owner.Visible = true;
        }




    }
}
