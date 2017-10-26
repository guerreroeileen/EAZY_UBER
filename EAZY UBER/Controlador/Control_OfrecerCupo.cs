﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Windows.Forms;
using mundo;
using EAZY_UBER;

namespace Controlador
{
    class Control_OfrecerCupo
    {
        private Inicio vPrinc;        
        private SistemaRecomendaciones sistema;
        
        public Control_OfrecerCupo(Inicio vPrinc, SistemaRecomendaciones sistema) {
            this.vPrinc = vPrinc;
            this.sistema = sistema;

            vPrinc.panel_OfrecerCupo1.botonConfirmar.Click += evento_RegistroRecorrido;
        }

        private void evento_RegistroRecorrido(object sender, EventArgs e) {
            var pUsuario = vPrinc.panel_PerfilUsuario1;
            var pOfrecerCupo = vPrinc.panel_OfrecerCupo1;
            int iRuta = pUsuario.comboBoxRutas.SelectedIndex;
            int iVehiculo = pUsuario.comboBoxVehiculos.SelectedIndex;
            DateTime fecha = new DateTime(pOfrecerCupo.dateTimePicker2.Value.Year,
                                            pOfrecerCupo.dateTimePicker2.Value.Month,
                                            pOfrecerCupo.dateTimePicker2.Value.Day,
                                            pOfrecerCupo.dateTimePicker1.Value.Hour,
                                            pOfrecerCupo.dateTimePicker2.Value.Minute,
                                            pOfrecerCupo.dateTimePicker2.Value.Second);
            int cupo = 0;
            double tarifa = -1;
            try { cupo = int.Parse(pOfrecerCupo.txbCupos.Text); } catch { MessageBox.Show("El numero de cupos debe ser un valor numerico"); }
            if (!pOfrecerCupo.txbTarifa.Text.SequenceEqual("")) { 
             try { tarifa = double.Parse(pOfrecerCupo.txbTarifa.Text); } catch { MessageBox.Show("La tarifa debe ser un valor numerico"); }
            }
            try
            {
                sistema.Estado_usuarioLogged.registrarRecorrido(tarifa, cupo, fecha, sistema.Estado_usuarioLogged.Vehiculos[iVehiculo], sistema.Estado_usuarioLogged.Rutas[iRuta]);
            }
            catch(AgregarRecorridoExcepcion ex) {
                bool[] campos = ex.CamposF;
                pUsuario.errorRuta.Visible = campos[0];
                pUsuario.errorVehiculo.Visible = campos[1];
                pOfrecerCupo.errorFecha.Visible = campos[2];
                pOfrecerCupo.errorHora.Visible = campos[2];
                pOfrecerCupo.errorCupo.Visible = campos[3];
                pOfrecerCupo.errorTarifa.Visible = campos[4];
            }
            mostrarPUsuariosRecomendados();
        }


        private void mostrarPUsuariosRecomendados() {
            //Refrescar lista y toda la cosa
            vPrinc.panel_UsuarioRecomendado1.Visible = true;
            vPrinc.panel_RecorridoRecomendado1.Visible = false;
        }
    }
}