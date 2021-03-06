﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mundo;
using EAZY_UBER;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Globalization;

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
            this.admon.buttonEliminar.Click += eliminar_Click;

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
                    usuariosConAuto = usuariosConAuto + 1;
                }

            }
            this.admon.labelUsuariosAuto.Text = "" + usuariosConAuto;
            //usuarios sin auto
            this.admon.labelUsuariosSinAuto.Text = "" + (sistema.Usuarios.Count - usuariosConAuto);

            admon.listUsuariosRegistrados.Items.Clear();
            var usuarios = sistema.Usuarios.Select(a => new { celular = a.Celular });
            foreach (var a in usuarios)
            {
                this.admon.listUsuariosRegistrados.Items.Add(a.celular);
            }

            llenarTablaUsuarios();
            rankingDineroAcumuladoUsuarios();
            admon.Show();

        }

        private void rankingDineroAcumuladoUsuarios() {
            admon.lbxDinero.Items.Clear();
            admon.lbxNombre.Items.Clear();

            List<Tuple<String, Double>> ranking = sistemaAdmon.usuariosQueMasGeneranDinero();
            foreach (var u in ranking) {
                admon.lbxDinero.Items.Add(u.Item2);
                admon.lbxNombre.Items.Add(u.Item1);
            }
            
        }

        private void llenarTablaUsuarios() {
            admon.chartRegUser.Series.Clear();
            admon.chartRegUser.Series.Add("registros");
            List<Tuple<int, int>> datos = sistemaAdmon.reporteRegistroUsuarios();            
            var max = datos.Select(b => b.Item2).Max();
            foreach (var d in datos) {
                admon.chartRegUser.Series["registros"].Points.AddXY(DateTimeFormatInfo.CurrentInfo.GetMonthName( d.Item1), d.Item2);
            }
            admon.chartRegUser.ChartAreas[0].AxisY.Maximum = max + max*0.1;
            admon.chartRegUser.Series["registros"].ChartArea = "ChartArea1";
            
        }


        /*
         * EventHandler para llamar al generador de usuario del sistema administrador
         */
        public void eventHandler_generarUsuarios(object sender, EventArgs e) {
           string resp =  Interaction.InputBox("Ingrese el numero de usuarios a generar aleatoriamente","Gerador usuarios", "");
            int numUsuarios = 100;
            try { numUsuarios = int.Parse(resp);
                sistemaAdmon.SistRecomendaciones.Usuarios = sistemaAdmon.generarBaseDatos(numUsuarios);
                llenar_Datos();
            } catch(Exception ex)
            { MessageBox.Show("Ingresa un valor entero de usuarios a generar"); }            
            
        }

        public void cambiarDatos(Object sender)
        {
            SistemaRecomendaciones sistema = sistemaAdmon.SistRecomendaciones;
            Usuario user = sistema.darUsuario(admon.listUsuariosRegistrados.SelectedItem.ToString());
            if (user != null)
            {
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
                if (admon.comboBoxRecorridos.Items.Count > 0)
                    admon.comboBoxRecorridos.SelectedIndex = 0;
                //Debug.WriteLine(user.Nombre);
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Inicio ini = (Inicio) admon.Owner;
            ini.panel_LogIn1.limpiarTextos();
            admon.Owner.Visible = true;
        }

        public void eliminar_Click(object sender, EventArgs e)
        {
            Usuario user = sistemaAdmon.SistRecomendaciones.darUsuario( admon.listUsuariosRegistrados.SelectedItem.ToString());
            sistemaAdmon.SistRecomendaciones.Usuarios.Remove(user);
            llenar_Datos();
            MessageBox.Show("Se ha eliminado el usuario");
        }



    }
}
