using EAZY_UBER;
using Excepciones;
using mundo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    class Control_RegistroRecorrido
    {
        public event delegado1 eventoAgregar; 

        private RegistroRecorrido registroRecorrido;
        private Usuario usuario;

        public Control_RegistroRecorrido(Usuario usuario, RegistroRecorrido registroRecorrido)
        {
            this.registroRecorrido = registroRecorrido;
            this.usuario = usuario;
            this.registroRecorrido.Show();
            this.registroRecorrido.botonConfirmar.Click += confirmar_click;
            registroRecorrido.pintarCombos(this.usuario);
        }

        public void confirmar_click(Object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(registroRecorrido.dateTimePicker2.Value.Year,
                                           registroRecorrido.dateTimePicker2.Value.Month,
                                           registroRecorrido.dateTimePicker2.Value.Day,
                                           registroRecorrido.dateTimePicker1.Value.Hour,
                                           registroRecorrido.dateTimePicker2.Value.Minute,
                                           registroRecorrido.dateTimePicker2.Value.Second);
            int cupo = 0;
            double tarifa = -1;
            Vehiculo vehi = usuario.Vehiculos[registroRecorrido.comboBoxVehiculo.SelectedIndex];
            Ruta ruta = usuario.Rutas[registroRecorrido.comboBoxRuta.SelectedIndex];
            try { cupo = int.Parse(registroRecorrido.txbCupos.Text); } catch { MessageBox.Show("El numero de cupos debe ser un valor numerico"); }
            if (!registroRecorrido.txbTarifa.Text.SequenceEqual(""))
            {
                try { tarifa = double.Parse(registroRecorrido.txbTarifa.Text); } catch { MessageBox.Show("La tarifa debe ser un valor numerico"); }
            }
            try
            {
               usuario.registrarRecorrido(tarifa, cupo, fecha, vehi, ruta);
               if (eventoAgregar != null)
                   eventoAgregar.Invoke(this);
            }
            catch (AgregarRecorridoExcepcion ex)
            {
                bool[] campos = ex.CamposF;
                registroRecorrido.errorFecha.Visible = campos[2];
                registroRecorrido.errorHora.Visible = campos[2];
                registroRecorrido.errorCupo.Visible = campos[3];
                registroRecorrido.errorTarifa.Visible = campos[4];
            }  
        }

        internal void cerrar()
        {
            registroRecorrido.Close();
        }
    }
}
