using mundo;
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
    public partial class RegistroRecorrido : Form
    {
        private Label label4;
        private Label label1;
        public DateTimePicker dateTimePicker1;
        private Label label2;
        public TextBox txbTarifa;
        public Button botonConfirmar;
        private Label label3;
        public Label errorCupo;
        public DateTimePicker dateTimePicker2;
        public Label errorHora;
        public Label errorTarifa;
        public Label errorFecha;
        private Label label5;
        public TextBox txbCupos;
        private Label label6;
        public ComboBox comboBoxRuta;
        public ComboBox comboBoxVehiculo;
        private Label label7;

        public RegistroRecorrido()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTarifa = new System.Windows.Forms.TextBox();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorCupo = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.errorHora = new System.Windows.Forms.Label();
            this.errorTarifa = new System.Windows.Forms.Label();
            this.errorFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCupos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRuta = new System.Windows.Forms.ComboBox();
            this.comboBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ofrecer Cupos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hora";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "\"hh:mm\"";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 57);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tarifa";
            // 
            // txbTarifa
            // 
            this.txbTarifa.Location = new System.Drawing.Point(59, 104);
            this.txbTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.txbTarifa.Name = "txbTarifa";
            this.txbTarifa.Size = new System.Drawing.Size(137, 20);
            this.txbTarifa.TabIndex = 20;
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(178, 234);
            this.botonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(91, 23);
            this.botonConfirmar.TabIndex = 21;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha";
            // 
            // errorCupo
            // 
            this.errorCupo.AutoSize = true;
            this.errorCupo.ForeColor = System.Drawing.Color.Red;
            this.errorCupo.Location = new System.Drawing.Point(200, 85);
            this.errorCupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorCupo.Name = "errorCupo";
            this.errorCupo.Size = new System.Drawing.Size(14, 13);
            this.errorCupo.TabIndex = 31;
            this.errorCupo.Text = "X";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(59, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // errorHora
            // 
            this.errorHora.AutoSize = true;
            this.errorHora.ForeColor = System.Drawing.Color.Red;
            this.errorHora.Location = new System.Drawing.Point(200, 63);
            this.errorHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorHora.Name = "errorHora";
            this.errorHora.Size = new System.Drawing.Size(14, 13);
            this.errorHora.TabIndex = 26;
            this.errorHora.Text = "X";
            // 
            // errorTarifa
            // 
            this.errorTarifa.AutoSize = true;
            this.errorTarifa.ForeColor = System.Drawing.Color.Red;
            this.errorTarifa.Location = new System.Drawing.Point(200, 104);
            this.errorTarifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorTarifa.Name = "errorTarifa";
            this.errorTarifa.Size = new System.Drawing.Size(14, 13);
            this.errorTarifa.TabIndex = 27;
            this.errorTarifa.Text = "X";
            // 
            // errorFecha
            // 
            this.errorFecha.AutoSize = true;
            this.errorFecha.ForeColor = System.Drawing.Color.Red;
            this.errorFecha.Location = new System.Drawing.Point(264, 38);
            this.errorFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorFecha.Name = "errorFecha";
            this.errorFecha.Size = new System.Drawing.Size(14, 13);
            this.errorFecha.TabIndex = 28;
            this.errorFecha.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cupos";
            // 
            // txbCupos
            // 
            this.txbCupos.Location = new System.Drawing.Point(59, 82);
            this.txbCupos.Margin = new System.Windows.Forms.Padding(2);
            this.txbCupos.Name = "txbCupos";
            this.txbCupos.Size = new System.Drawing.Size(137, 20);
            this.txbCupos.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ruta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Vehiculo";
            // 
            // comboBoxRuta
            // 
            this.comboBoxRuta.FormattingEnabled = true;
            this.comboBoxRuta.Location = new System.Drawing.Point(59, 156);
            this.comboBoxRuta.Name = "comboBoxRuta";
            this.comboBoxRuta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRuta.TabIndex = 34;
            // 
            // comboBoxVehiculo
            // 
            this.comboBoxVehiculo.FormattingEnabled = true;
            this.comboBoxVehiculo.Location = new System.Drawing.Point(59, 129);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehiculo.TabIndex = 35;
            // 
            // RegistroRecorrido
            // 
            this.ClientSize = new System.Drawing.Size(423, 283);
            this.Controls.Add(this.comboBoxVehiculo);
            this.Controls.Add(this.comboBoxRuta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorCupo);
            this.Controls.Add(this.txbCupos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorFecha);
            this.Controls.Add(this.errorTarifa);
            this.Controls.Add(this.errorHora);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.txbTarifa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "RegistroRecorrido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void pintarCombos(Usuario user)
        {
            comboBoxVehiculo.Items.Clear();
            foreach (var i in user.Vehiculos)
            {
                comboBoxVehiculo.Items.Add(i.Placa);
            }
            comboBoxVehiculo.SelectedIndex = 0;

            comboBoxRuta.Items.Clear();
            foreach(var i in user.Rutas)
            {
                comboBoxRuta.Items.Add(i.Nombre);
            }
            comboBoxRuta.SelectedIndex = 0;
            
        }
    }
}
