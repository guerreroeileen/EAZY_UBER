using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAZY_UBER
{
    public partial class RegistroVehiculo : Form
    {

        public event delegado1 eventoRegistrarVehiculo;
        public RegistroVehiculo()
        {
            InitializeComponent();
        }

        private void RegistroVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (eventoRegistrarVehiculo != null)            
                eventoRegistrarVehiculo.Invoke(this);
            
        }
    }
}
