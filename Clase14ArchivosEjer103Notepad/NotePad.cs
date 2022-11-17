using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Clase14ArchivosEjer103Notepad
{
    public partial class Notepad : Form
    {
        private SaveFileDialog saveFileDialog;
        string path;
        public Notepad()
        {
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            saveFileDialog.Title = "Save a Text File";
            path = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLbl_caracteres.Text = "0 caracteres";
        }

        public int CantidadDecaracteres(string texto)
        {
            int cantidadDeCaracteres = 0;
            if (texto is not null)
            {
                foreach (char c in texto)
                {
                    cantidadDeCaracteres += 1;
                }
            }

            return cantidadDeCaracteres;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //obtengo el nombre del archivo
                        this.path = ofd.FileName;                        

                        using (StreamReader streamReader = new StreamReader(this.path))
                        {
                            richTextBox1.Text = streamReader.ReadToEnd();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MostrarVentanaDeError(ex);
                }
            }

            this.toolStripStatusLbl_caracteres.Text = $" {CantidadDecaracteres(this.richTextBox1.Text)} caracteres";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        this.path = saveFileDialog.FileName;

                        using (StreamWriter streamWriter = new StreamWriter(this.path, true))
                        {
                            streamWriter.Write(richTextBox1.Text);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(this.path))
            {

                try
                {

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            this.path = saveFileDialog.FileName;

                            using (StreamWriter streamWriter = new StreamWriter(path, true))
                            {
                                streamWriter.Write(richTextBox1.Text);
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                    MostrarVentanaDeError(ex);
                }
            }
            else
            {
                
                using (StreamWriter streamWriter = new StreamWriter(this.path))// si le saco el true pisa directo y actualiza el archivo al estado actual
                {
                    streamWriter.Write(richTextBox1.Text);
                }
                MessageBox.Show("Se actualizo el archivo");
            }
            

        }
        //para el stack trace y ventana de error
        private void MostrarVentanaDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Error: {ex.Message}");
            stringBuilder.AppendLine("Detalle:");
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}

