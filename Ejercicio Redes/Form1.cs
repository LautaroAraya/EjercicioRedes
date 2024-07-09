using System.IO;
namespace Ejercicio_Redes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Archivo de texto (*.txt)|*.txt| Todos los archivos (*.*)|*.*";
            this.openFileDialog1.ShowDialog();
            this.txtArchivo.Text = this.openFileDialog1.FileName;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader archivo;
            //Abrir el archivo
            try
            {
                archivo = new StreamReader(this.txtArchivo.Text);
                //leer todo el contenido y poner el contenido en el txtbox
                string contenido = archivo.ReadToEnd();
                this.txtContenido.Text = contenido;
                //cerrar el archivo
                archivo.Close();
            }
            catch
            {
                MessageBox.Show("No se puede abrir el archivo");
            }


        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            StreamReader archivoLeer;
            StreamWriter archivoCopia;
            string nombreArchivo;
            string linea;

            try
            {
                archivoLeer = new StreamReader(this.txtArchivo.Text);
                nombreArchivo = this.txtArchivo.Text;//mensaje.txt
                nombreArchivo = nombreArchivo.Substring(0, nombreArchivo.Length - 3);//mensaje.
                nombreArchivo = nombreArchivo + "bak"; //mensaje.bak
                archivoCopia = new StreamWriter(nombreArchivo);
                linea = archivoLeer.ReadLine();
                while (linea != null)
                {
                    archivoCopia.WriteLine(linea);
                    linea = archivoLeer.ReadLine();
                }

                archivoLeer.Close();
                archivoCopia.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error");

            }
        }
    }
}
