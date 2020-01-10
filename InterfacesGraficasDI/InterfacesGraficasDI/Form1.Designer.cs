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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarUnArchivoToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(145, 29);
            this.MainMenu.Text = "Menu principal";
            // 
            // cargarUnArchivoToolStripMenuItem
            // 
            this.cargarUnArchivoToolStripMenuItem.Name = "cargarUnArchivoToolStripMenuItem";
            this.cargarUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cargarUnArchivoToolStripMenuItem.Text = "Cargar un archivo";
            this.cargarUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarUnArchivoToolStripMenuItem_Click);
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
            this.listadoImagenes.TabIndex = 8;
            this.listadoImagenes.SelectedIndexChanged += new System.EventHandler(this.listadoImagenes_SelectedIndexChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(509, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listadoImagenes);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
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
    }
}

