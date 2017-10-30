using System;
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
        private delegado1 eventoCambiarDatos;

        private SistemaRecomendaciones sistema;
        public Administrador()
        {
            InitializeComponent();
        }

        public void addHandlerCambiarDatos(delegado1 delegado)
        {
            eventoCambiarDatos += delegado;
        }


        private void listUsuariosRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
