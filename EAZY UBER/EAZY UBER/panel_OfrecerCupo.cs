using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mundo;

namespace EAZY_UBER
{
    public partial class panel_OfrecerCupo : UserControl
    {

        public panel_OfrecerCupo()
        {
            InitializeComponent();
        }
        public void pintarrecorridos(Usuario user)
        {
            comboBox1.Items.Clear();
            foreach(var i in user.Recorridos)
            {
                comboBox1.Items.Add(i.Fecha);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_OfrecerCupo_Load(object sender, EventArgs e)
        {

        }
    }
}
