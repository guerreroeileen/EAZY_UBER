using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mundo;
using EAZY_UBER;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using System.Diagnostics;

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
            this.admon.eventoCambiarDatos += cambiarDatos;
            this.sistema = sistema;
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


        public void cambiarDatos(Object sender)
        {
            Usuario user = sistema.darUsuario(admon.listUsuariosRegistrados.SelectedItem.ToString());
            admon.LabelNombre.Text = user.Nombre + " " + user.Apellido;
            admon.labelCelular.Text = user.Celular;
            admon.labelCorreo.Text = user.Correo;

            admon.comboBoxRutas.SelectedIndex = -1;
            admon.comboBoxRutas.Items.Clear();
            foreach (var ruta in user.Rutas)
            {
                admon.comboBoxRutas.Items.Add(ruta.Nombre);
            }
            if (admon.comboBoxRutas.Items.Count > 0)
                admon.comboBoxRutas.SelectedIndex = 0;

            admon.comboBoxVehiculos.SelectedIndex = -1;
            admon.comboBoxVehiculos.Items.Clear();
            foreach (var vehiculo in user.Vehiculos)
            {
                admon.comboBoxVehiculos.Items.Add(vehiculo.Placa);
            }
            if (admon.comboBoxVehiculos.Items.Count > 0)
                admon.comboBoxVehiculos.SelectedIndex = 0;

            admon.comboBoxRecorridos.SelectedIndex = -1;
            admon.comboBoxRecorridos.Items.Clear();
            foreach (var recorridos in user.Recorridos)
            {
                admon.comboBoxRecorridos.Items.Add(recorridos.Fecha);
            }
            if(admon.comboBoxRecorridos.Items.Count>0)
                admon.comboBoxRecorridos.SelectedIndex = 0;
            //Debug.WriteLine(user.Nombre);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Inicio ini = (Inicio) admon.Owner;
            ini.panel_LogIn1.limpiarTextos();
            admon.Owner.Visible = true;
        }




    }
}
