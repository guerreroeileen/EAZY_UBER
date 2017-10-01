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
        private Panel_registro panel_registro1;
        private Panel_LogIn panel_LogIn1;

        public Inicio()
        {
           
            InitializeComponent();
            panel_LogIn1.addHandlerregistro(iniciarRegistro);
            panel_LogIn1.addHandlerIngreso(ingresar);
            panel_registro1.addHandlerregistro(registrarse);
            panel_registro1.addHandlerCancelar(cancelarRegistro);
            panel_registro1.Visible = false;
        }

        //Control navegacion
        public void iniciarRegistro(Object sender)
        {
            panel_registro1.Visible = true;
        }
        public void ingresar(Object sender)
        {
            //TODO
            this.Close();
            new NavegacionUsuario().Show();
        }
        public void cancelarRegistro(Object sender)
        {
            //TODO limpiar campos
            panel_registro1.Visible = false;
        }
        public void registrarse(Object sender)
        {
            //TODO
        }
       

        private void InitializeComponent()
        {
            this.panel_registro1 = new EAZY_UBER.Panel_registro();
            this.panel_LogIn1 = new EAZY_UBER.Panel_LogIn();
            this.SuspendLayout();
            // 
            // panel_registro1
            // 
            this.panel_registro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_registro1.Location = new System.Drawing.Point(140, 122);
            this.panel_registro1.Name = "panel_registro1";
            this.panel_registro1.Size = new System.Drawing.Size(304, 342);
            this.panel_registro1.TabIndex = 1;
            // 
            // panel_LogIn1
            // 
            this.panel_LogIn1.Location = new System.Drawing.Point(177, 132);
            this.panel_LogIn1.Name = "panel_LogIn1";
            this.panel_LogIn1.Size = new System.Drawing.Size(253, 289);
            this.panel_LogIn1.TabIndex = 0;
            // 
            // Inicio
            // 
            this.BackgroundImage = global::EAZY_UBER.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panel_registro1);
            this.Controls.Add(this.panel_LogIn1);
            this.Name = "Inicio";
            this.ResumeLayout(false);

        }
    }
}
