namespace EAZY_UBER
{
    partial class RegistroRuta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNombreRuta = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombreRuta = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionRuta = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnAgregarPuntos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(88, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Registra una ruta";
            // 
            // labelNombreRuta
            // 
            this.labelNombreRuta.AutoSize = true;
            this.labelNombreRuta.Location = new System.Drawing.Point(12, 39);
            this.labelNombreRuta.Name = "labelNombreRuta";
            this.labelNombreRuta.Size = new System.Drawing.Size(94, 13);
            this.labelNombreRuta.TabIndex = 1;
            this.labelNombreRuta.Text = "Nombre de la ruta:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 65);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxNombreRuta
            // 
            this.textBoxNombreRuta.Location = new System.Drawing.Point(120, 39);
            this.textBoxNombreRuta.Name = "textBoxNombreRuta";
            this.textBoxNombreRuta.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombreRuta.TabIndex = 3;
            // 
            // textBoxDescripcionRuta
            // 
            this.textBoxDescripcionRuta.Location = new System.Drawing.Point(120, 65);
            this.textBoxDescripcionRuta.Multiline = true;
            this.textBoxDescripcionRuta.Name = "textBoxDescripcionRuta";
            this.textBoxDescripcionRuta.Size = new System.Drawing.Size(178, 76);
            this.textBoxDescripcionRuta.TabIndex = 4;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(310, 9);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(330, 354);
            this.gMapControl1.TabIndex = 5;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(173, 159);
            this.btnFin.Margin = new System.Windows.Forms.Padding(2);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(101, 22);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "Seleccionar fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(33, 159);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(100, 22);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Seleccionar inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(310, 388);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(76, 26);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnAgregarPuntos
            // 
            this.btnAgregarPuntos.Location = new System.Drawing.Point(194, 203);
            this.btnAgregarPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPuntos.Name = "btnAgregarPuntos";
            this.btnAgregarPuntos.Size = new System.Drawing.Size(104, 21);
            this.btnAgregarPuntos.TabIndex = 11;
            this.btnAgregarPuntos.Text = "Agregar puntos";
            this.btnAgregarPuntos.UseVisualStyleBackColor = true;
            this.btnAgregarPuntos.Click += new System.EventHandler(this.btnAgregarPuntos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(194, 228);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 22);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar punto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 160);
            this.listBox1.TabIndex = 13;
            // 
            // RegistroRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 425);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarPuntos);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.textBoxDescripcionRuta);
            this.Controls.Add(this.textBoxNombreRuta);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombreRuta);
            this.Controls.Add(this.labelTitulo);
            this.Name = "RegistroRuta";
            this.Text = "Registro Ruta";
            this.Load += new System.EventHandler(this.RegistroRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNombreRuta;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnEliminar;
        public GMap.NET.WindowsForms.GMapControl gMapControl1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TextBox textBoxDescripcionRuta;
        public System.Windows.Forms.TextBox textBoxNombreRuta;
        public System.Windows.Forms.Button btnFin;
        public System.Windows.Forms.Button btnInicio;
        public System.Windows.Forms.Button btnAgregarPuntos;
    }
}