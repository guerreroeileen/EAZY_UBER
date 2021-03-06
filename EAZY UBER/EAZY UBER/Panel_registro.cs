﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAZY_UBER
{
    public partial class Panel_registro : UserControl
    {
        public event delegado1 eventoRegistro;
        public event delegado1 eventoCancelar;
        public event delegado1 eventoSeleccionarRutaImagen;

        public Panel_registro()
        {
            InitializeComponent();

            //ocultar mensajes de error
            mError1.Visible = false;
            mError2.Visible = false;
            nError0.Visible = false;
            nError1.Visible = false;
            nError2.Visible = false;
            nError3.Visible = false;
            nError4.Visible = false;
            nError5.Visible = false;
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            if (eventoRegistro != null)
                eventoRegistro.Invoke(this);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (eventoCancelar != null)
                eventoCancelar.Invoke(this);
        }

        public void limpiar()
        {
            textApellido.Clear();
            textCelular.Clear();
            textConfContrasena.Clear();
            textContrasena.Clear();
            textCorreo.Clear();
            textFoto.Clear();
            textNombre.Clear();

            mError1.Visible = false;
            mError2.Visible = false;
            nError0.Visible = false;
            nError1.Visible = false;
            nError2.Visible = false;
            nError3.Visible = false;
            nError4.Visible = false;
            nError5.Visible = false;

        }

        private void Panel_registro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (eventoSeleccionarRutaImagen != null)
                eventoSeleccionarRutaImagen.Invoke(this);
        }
    }
}
