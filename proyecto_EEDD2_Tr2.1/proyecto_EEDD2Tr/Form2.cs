using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_EEDD2Tr
{
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string fileName = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Buscar archivo";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            // Muestra el cuadro de diálogo y si el usuario ha seleccionado un archivo, carga su contenido
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtén la ruta del archivo seleccionado
                fileName = openFileDialog1.FileName.ToString();

                // Lee el contenido del archivo y carga su contenido en un control TextBox
                //string contenido = File.ReadAllText(rutaArchivo);
                //textBox1.Text = contenido;
            }

            //File.ReadAllLines(fileName);

            StreamReader reader = new StreamReader(fileName);
            string line;
            string[] values;
            StringBuilder sb = new StringBuilder();
            for (line = reader.ReadLine(); line != null; line = reader.ReadLine())
            {
                values = line.Split(',');
                for(int i = 0; i < values.Length; i++)
                {
                    sb.Append(values[i]);
                }
            }
            textBox1.Text = sb.ToString();
            reader.Close();
        }
    }
}