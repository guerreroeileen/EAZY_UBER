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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.BackgroundImage = global::EAZY_UBER.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Name = "Inicio";
            this.ResumeLayout(false);

        }
    }
}
