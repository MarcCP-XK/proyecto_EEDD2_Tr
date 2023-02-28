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

        private StreamWriter sw;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //tablaToolStripMenuItem.Text = openFileDialog1.FileName;
            //}

            //File.ReadAllLines(openFileDialog1.FileName);
            textBox1.ScrollBars = ScrollBars.Vertical;

            String path = openFileDialog1.FileName;

            sw = new StreamWriter(path, true, Encoding.ASCII);
            for(int i = 0; i < sw.NewLine.Length; i++)
            {
                textBox1.Text += sw.ToString();
                //buenas
                


            }
        }
    }
}
