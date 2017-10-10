using System;
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
    public delegate void delegado1(Object sender);

    public partial class Panel_LogIn : UserControl
    {
        public event delegado1 eventoRegistro;
        public event delegado1 eventoIngresar;


        public Panel_LogIn()
        {
            InitializeComponent();
            error.Visible = false;
        }
        private void registro_Click(object sender, EventArgs e)
        {
            if (eventoRegistro != null)
                eventoRegistro.Invoke(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eventoIngresar != null)
                eventoIngresar.Invoke(this);
        }
    }
}
