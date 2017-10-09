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
    public partial class panel_BuscarRuta : UserControl
    {
        private event delegado1 eventoConfirmarBuscarRuta;

        public panel_BuscarRuta()
        {
            
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = new DateTime(2017, 12, 31);

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        public void addHandlerConfirmarOfrecerCupoo(delegado1 delegado)
        {
            eventoConfirmarBuscarRuta += delegado;
        }
        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (eventoConfirmarBuscarRuta != null)
                eventoConfirmarBuscarRuta.Invoke(this);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel_BuscarRuta_Load(object sender, EventArgs e)
        {

        }
    }
}
