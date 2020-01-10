using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace InterfacesGraficasDI
{
    public partial class MainWindow : Form
    {
        private ArrayList listadoRutas = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();
            CleanPictureData();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void cargarUnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_imagen.Filter = "JPG files (*.jpg)|*.jpg";
            abrir_imagen.FilterIndex = 1;
            abrir_imagen.RestoreDirectory = true;

            var contenido_fichero = string.Empty;
            var ruta_fichero = string.Empty;

            if(abrir_imagen.ShowDialog() == DialogResult.OK)
            {
                ruta_fichero = abrir_imagen.FileName;

                var fileStream = abrir_imagen.OpenFile();

                //Mostramos un aviso de que se ha cargado correctamente
                MostrarDialogoAviso(Path.GetFileName(abrir_imagen.FileName));

                //Mostramos los datos de la imagen
                //MostrarDatosImagenCargada(ruta_fichero);

                //Añadimos el nombre de la imagen al listbox y la ruta a un arraylist
                AddToList(ruta_fichero);

                ColocarImagen(ruta_fichero);
                //pictureBox.Image = Image.FromFile(ruta_fichero);
            }
        }

        private void MostrarDialogoAviso(string nombreFichero)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            nombreFichero = Path.GetFileName(abrir_imagen.FileName);

            MessageBox.Show("Imagen " + nombreFichero + " cargado correctamente", "Carga de imagen", button, icon);

        }

        private void MostrarDatosImagenCargada(string ruta)
        {
            labelPath.Text = ruta;
            labelName.Text = Path.GetFileNameWithoutExtension(ruta);
            labelType.Text = Path.GetExtension(ruta);
        }

        private void AddToList(string ruta)
        {
            listadoImagenes.Items.Add(Path.GetFileName(ruta));

            listadoRutas.Add(ruta);

            listadoImagenes.SelectedIndex = listadoImagenes.Items.Count - 1;
        }

        private void listadoImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listadoImagenes.SelectedIndex;

            ColocarImagen((string)listadoRutas[index]);
        }

        private void ColocarImagen(string ruta)
        {
            pictureBox.Image = Image.FromFile(ruta);
            MostrarDatosImagenCargada(ruta);
        }

        private void CleanPictureData()
        {
            labelPath.Text = "No hay imagen activa";
            labelName.Text = "No hay imagen activa";
            labelType.Text = "No hay imagen activa";
        }
    }
}
