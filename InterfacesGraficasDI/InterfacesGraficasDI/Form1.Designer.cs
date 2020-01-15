
namespace InterfacesGraficasDI
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.avanzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrocederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir_imagen = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.listadoImagenes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreImagen = new System.Windows.Forms.ToolTip(this.components);
            this.nombreImagenLista = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.botonCargar2 = new System.Windows.Forms.Button();
            this.botonEliminar2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.imagenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarUnArchivoToolStripMenuItem,
            this.resetearToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(88, 29);
            this.menuArchivo.Text = "Archivo";
            // 
            // cargarUnArchivoToolStripMenuItem
            // 
            this.cargarUnArchivoToolStripMenuItem.Name = "cargarUnArchivoToolStripMenuItem";
            this.cargarUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.cargarUnArchivoToolStripMenuItem.Text = "Cargar imagen";
            this.cargarUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarUnArchivoToolStripMenuItem_Click);
            // 
            // resetearToolStripMenuItem
            // 
            this.resetearToolStripMenuItem.Name = "resetearToolStripMenuItem";
            this.resetearToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.resetearToolStripMenuItem.Text = "Resetear";
            this.resetearToolStripMenuItem.Click += new System.EventHandler(this.resetearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator2,
            this.avanzarToolStripMenuItem,
            this.retrocederToolStripMenuItem});
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // avanzarToolStripMenuItem
            // 
            this.avanzarToolStripMenuItem.Name = "avanzarToolStripMenuItem";
            this.avanzarToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.avanzarToolStripMenuItem.Text = "Avanzar";
            this.avanzarToolStripMenuItem.Click += new System.EventHandler(this.avanzarToolStripMenuItem_Click);
            // 
            // retrocederToolStripMenuItem
            // 
            this.retrocederToolStripMenuItem.Name = "retrocederToolStripMenuItem";
            this.retrocederToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.retrocederToolStripMenuItem.Text = "Retroceder";
            this.retrocederToolStripMenuItem.Click += new System.EventHandler(this.retrocederToolStripMenuItem_Click);
            // 
            // abrir_imagen
            // 
            this.abrir_imagen.FileName = "Seleccione una imagen";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(248, 52);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(260, 198);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(136, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(0, 20);
            this.labelPath.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(140, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 6;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(140, 112);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(0, 20);
            this.labelType.TabIndex = 7;
            // 
            // listadoImagenes
            // 
            this.listadoImagenes.FormattingEnabled = true;
            this.listadoImagenes.ItemHeight = 20;
            this.listadoImagenes.Location = new System.Drawing.Point(0, 52);
            this.listadoImagenes.Name = "listadoImagenes";
            this.listadoImagenes.Size = new System.Drawing.Size(187, 364);
            this.listadoImagenes.TabIndex = 1;
            this.listadoImagenes.SelectedIndexChanged += new System.EventHandler(this.listadoImagenes_SelectedIndexChanged);
            this.listadoImagenes.MouseHover += new System.EventHandler(this.listadoImagenes_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelPath);
            this.groupBox1.Location = new System.Drawing.Point(248, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // botonCargar2
            // 
            this.botonCargar2.Location = new System.Drawing.Point(226, 415);
            this.botonCargar2.Name = "botonCargar2";
            this.botonCargar2.Size = new System.Drawing.Size(158, 34);
            this.botonCargar2.TabIndex = 3;
            this.botonCargar2.Text = "Cargar";
            this.botonCargar2.UseVisualStyleBackColor = true;
            this.botonCargar2.Click += new System.EventHandler(this.botonCargar2_Click);
            // 
            // botonEliminar2
            // 
            this.botonEliminar2.Location = new System.Drawing.Point(432, 414);
            this.botonEliminar2.Name = "botonEliminar2";
            this.botonEliminar2.Size = new System.Drawing.Size(170, 35);
            this.botonEliminar2.TabIndex = 4;
            this.botonEliminar2.Text = "Eliminar imagen";
            this.botonEliminar2.UseVisualStyleBackColor = true;
            this.botonEliminar2.Click += new System.EventHandler(this.botonEliminar2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEliminar2);
            this.Controls.Add(this.botonCargar2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listadoImagenes);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Biblioteca de imagenes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem cargarUnArchivoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog abrir_imagen;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ListBox listadoImagenes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem resetearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem avanzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrocederToolStripMenuItem;
        private System.Windows.Forms.ToolTip nombreImagen;
        private System.Windows.Forms.ToolTip nombreImagenLista;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonCargar2;
        private System.Windows.Forms.Button botonEliminar2;
    }
}

