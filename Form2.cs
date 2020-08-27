using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBasic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/ddeu1/Source/Repos/desafio1/imagenes/" + comboBox1.Text + ".jpg";
            if (comboBox1.SelectedItem.ToString() == "CHERNOBYL")
            {
                label1.Text = "EXPLOCION BIEN CABRONA ALV";
            }
            if (comboBox1.SelectedItem.ToString() == "GAME OF THRONES")
            {
                label1.Text = "JUEGO DE TRONOS";
            }
            if (comboBox1.SelectedItem.ToString() == "THE MARVELOUS MRS. MAISEL")
            {
                label1.Text = "Título en español: Juego de tronos";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:/Users/ddeu1/Source/Repos/desafio1/imagenes/" + comboBox2.Text + ".jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "C:/Users/ddeu1/Source/Repos/desafio1/imagenes/" + comboBox3.Text + ".jpg";
        }
    }
}
