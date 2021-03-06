﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mundo;

namespace EAZY_UBER
{
    public partial class Administrador : Form
    {
        public delegado1 eventoCambiarDatos;

        private SistemaRecomendaciones sistema;

        public Administrador()
        {
            InitializeComponent();     
           
        }

        private void listUsuariosRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventoCambiarDatos != null)
                eventoCambiarDatos.Invoke(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
