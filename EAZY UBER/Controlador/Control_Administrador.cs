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
        private SistemaAdministrador sistemaAdmon;    
        private Administrador admon;

        public Control_Administrador(Administrador admon, SistemaAdministrador sistemaAdmon)
        {
            this.admon = admon;
            this.admon.FormClosing += Form1_FormClosing;
            this.admon.eventoCambiarDatos += cambiarDatos;
            this.sistemaAdmon = sistemaAdmon;

            this.admon.generarUsuariosToolStripMenuItem.Click += eventHandler_generarUsuarios;
            llenar_Datos();           
        }

        public void llenar_Datos()
        {
            SistemaRecomendaciones sistema = sistemaAdmon.SistRecomendaciones;
            if (sistema.Usuarios == null) { Debug.WriteLine("usuarios es null es null"); }
            //LLENADO DE DATOS GENERALES
            //cantidad de users registrados
            this.admon.labelUsuariosRegistrados.Text = "" + sistema.Usuarios.Count();
            //carros totales
            int carrosT = sistema.Usuarios.Aggregate(0, (a, b) => a + b.Vehiculos.Count); 
            this.admon.labelAutosRegistrados.Text = "" + carrosT;
            //recorridos registrados
            int recorridosTotales = sistema.Usuarios.Aggregate(0,(a,b)=> a+b.Recorridos.Count);
            this.admon.labelRecorridosRegistrados.Text = "" + recorridosTotales;
            //usuarios con auto
            int usuariosConAuto = 0;
            for (int i = 0; i < sistema.Usuarios.Count; i++)
            {
                if (sistema.Usuarios.ElementAt(i).Vehiculos.Count > 0)
                {
                    usuariosConAuto = usuariosConAuto + sistema.Usuarios.ElementAt(i).Vehiculos.Count;
                }

            }
            this.admon.labelUsuariosAuto.Text = "" + usuariosConAuto;
            //usuarios sin auto
            this.admon.labelUsuariosSinAuto.Text = "" + (sistema.Usuarios.Count - usuariosConAuto);


            var usuarios = sistema.Usuarios.Select(a => new { celular = a.Celular });
            foreach (var a in usuarios)
            {
                this.admon.listUsuariosRegistrados.Items.Add(a.celular);
            }
            admon.Show();

        }

        /*
         * EventHandler para llamar al generador de usuario del sistema administrador
         */
        public void eventHandler_generarUsuarios(object sender, EventArgs e) {
            sistemaAdmon.SistRecomendaciones.Usuarios = sistemaAdmon.generarBaseDatos(10);
            llenar_Datos();
        }

        public void cambiarDatos(Object sender)
        {
            SistemaRecomendaciones sistema = sistemaAdmon.SistRecomendaciones;
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
