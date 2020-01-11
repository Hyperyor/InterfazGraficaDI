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
            //se inicializan los componentes
            InitializeComponent();

            //limpiamos y mostramos mensajes al usuario
            //señalando que no hay datos cargados
            CleanPictureData();

            //inhabilitamos los botones relacionados
            //con las imagenes
            CheckImageOptions();
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

                //Añadimos el nombre de la imagen al listbox y la ruta a un arraylist
                AddToList(ruta_fichero);

                ColocarImagen(ruta_fichero);
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
            //coloca una imagen en el picturebox a 
            //partir de una ruta
            pictureBox.Image = Image.FromFile(ruta);

            //mostramos sus  datos
            MostrarDatosImagenCargada(ruta);

            //comprobamos si hay que habilitar los
            //botones de imagen
            CheckImageOptions();

            //cambiamos el titulo de la ventana
            this.Text = "" + Path.GetFileName(ruta) + " - Visor";

            ControlBotonesMovimiento();
        }

        private void CleanPictureData()
        {
            //borra la imagen que se estuviera mostrando
            pictureBox.Image = null;

            //muestra un mensaje al usuario
            labelPath.Text = "No hay imagen activa";
            labelName.Text = "No hay imagen activa";
            labelType.Text = "No hay imagen activa";

            this.Text = " - Visor";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cierra la ventana
            this.Close();
        }

        private void resetearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //borra todos los datos del listbox
            listadoImagenes.Items.Clear();
            //borra todas las rutas del arraylist
            listadoRutas = new ArrayList();
            //limpiamos los datos y mostramos
            //mensajes indicando que no hay datos
            CleanPictureData();
            //inhabilitamos los botones de imagen
            CheckImageOptions();
        }

        private void CheckImageOptions()
        {
            if(listadoImagenes.Items.Count == 0 )
            {
                //desactiva el menu de imagen
                imagenToolStripMenuItem.Enabled = false;
            }
            else
            {
                //activa el menu de imagen
                imagenToolStripMenuItem.Enabled = true;
            }
        }

        private void ControlBotonesMovimiento()
        {
            //si solo hay un elemento en la lista
            if(listadoImagenes.Items.Count == 1)
            {
                avanzarToolStripMenuItem.Enabled = false;
                retrocederToolStripMenuItem.Enabled = false;
            }
            else
            {
                //si hemos seleccionado el primer elemento
                if (listadoImagenes.SelectedIndex == 0)
                {
                    avanzarToolStripMenuItem.Enabled = true;
                    retrocederToolStripMenuItem.Enabled = false;
                }
                else
                {
                    //si hemos seleccionado el ultimo elemento
                    if(listadoImagenes.SelectedIndex == listadoImagenes.Items.Count - 1)
                    {
                        avanzarToolStripMenuItem.Enabled = false;
                        retrocederToolStripMenuItem.Enabled = true;
                    }
                    else //en caso de estar en medio
                    {
                        avanzarToolStripMenuItem.Enabled = true;
                        retrocederToolStripMenuItem.Enabled = true;

                    }
                }
            }

        }

        private void avanzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //esto hara que se llame al metodo 
            //listadoImagenes_SelectedIndexChanged, que
            //desencadenara todas las acciones necesarias
            //para mostrar la imagen correspondiente
            //y sus datos
            listadoImagenes.SelectedIndex = listadoImagenes.SelectedIndex + 1;
        }

        private void retrocederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadoImagenes.SelectedIndex = listadoImagenes.SelectedIndex - 1;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            if(listadoImagenes.Items.Count != 0)
            {
                nombreImagen.SetToolTip(this.pictureBox, "Esta visualizando la imagen " + listadoImagenes.Items[listadoImagenes.SelectedIndex]);
            }
            
        }

        private void listadoImagenes_MouseHover(object sender, EventArgs e)
        {
            if (listadoImagenes.Items.Count != 0)
            {
                nombreImagenLista.SetToolTip(this.listadoImagenes, "La imagen seleccionada es " + listadoImagenes.Items[listadoImagenes.SelectedIndex]);
            }
        }
    }
}
