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
            this.gMapControl1.Location = new System.Drawing.Point(15, 169);
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
            this.gMapControl1.Size = new System.Drawing.Size(283, 178);
            this.gMapControl1.TabIndex = 5;
            this.gMapControl1.Zoom = 0D;
            // 
            // RegistroRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 359);
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
        private System.Windows.Forms.TextBox textBoxNombreRuta;
        private System.Windows.Forms.TextBox textBoxDescripcionRuta;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}