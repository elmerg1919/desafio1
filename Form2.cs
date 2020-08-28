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
        private string[,] arreglo= new string[3,7];
        private string[,] arreglo1 = new string[3, 7];
        public Form2()
        {
            InitializeComponent();
        }
        private void LlenarMatrizProgramas() 
        {
            //Datos GOT
            arreglo[0, 0] = "Título en español: Juego de tronos";
            arreglo[0, 1] = "Creado por: David Benioff y D.B. Weiss";
            arreglo[0, 2] = "Sean Bena, Nikolaj Coster-Waldau, Peter Dinklade, Emilia Clarke, Lena Headey, Iain Glen, Kit Harington, Sophie Turner, Maisie Williams, Isaac Hempstead-Wright, Natalie Dormer";
            arreglo[0, 3] = "País de origen: Estados Unidos";
            arreglo[0, 4] = "Temporadas: 8";
            arreglo[0, 5] = "Episodios: 73";
            arreglo[0, 6] = "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el"+
" continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio";

            //Datos CHERNOBYL
            arreglo[1, 0] = "Título en español: Chernóbil";
            arreglo[1, 1] = "Creado por: Craig Mazin";
            arreglo[1, 2] = "Jared Harris, Stellan Skarsgård, Emely Watson";
            arreglo[1, 3] = "País de origen: Estados Unidos, Reino Unido";
            arreglo[1, 4] = "Temporadas: 1";
            arreglo[1, 5] = "Episodios: 5";
            arreglo[1, 6] = "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron. Cuenta con un reparto encabezado por Jared"+
" Harris, Stellan Skarsgård y Emily Watson.";

            //DATOS TMMM
            arreglo[2, 0] = "Título en español: La maravillosa Señora Maise";
            arreglo[2, 1] = "Creado por: Amy Sherman-Palladino";
            arreglo[2, 2] = "Rachel Brosnahan, Michael Zegen, Alex Borstein, Tony Shalhoub, Marin Hinkle";
            arreglo[2, 3] = "País de origen: Estados Unidos";
            arreglo[2, 4] = "Temporadas: 3";
            arreglo[2, 5] = "Episodios: 26";
            arreglo[2, 6] = "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte" +
" de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamaciónde la crítica.";

        }

        private void LlenarMatrizLenguaje() 
        {
            //Datos PHYTON
            arreglo1[0, 0] = "Desarolladores: Python Software Foundation";
            arreglo1[0, 1] = "Apareció en: 1991";
            arreglo1[0, 2] = ".py, .pyc, .pyd, .pyo, .pyw, .pyz";
            arreglo1[0, 3] = "Sistema Operativo: Multiplataforma";
            arreglo1[0, 4] = "Última versión estable: 3.8.3";
            arreglo1[0, 5] = "Licencia: Python Software Foundation License";
            arreglo1[0, 6] = "Multiparadigma: orientado a objetos, imperativo, funcional,reflexivo";
        }

        private void LimpiarMatriz(string[,] matriz) 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matriz[i, j] = " ";
                }
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarMatrizProgramas();
            string elemento = string.Empty;
            lblImg.ImageIndex = comboBox1.SelectedIndex;
          
            if (comboBox1.SelectedItem.ToString() == "CHERNOBYL")
            {

                label1.Text = arreglo[1, 0].ToString();
                label4.Text = arreglo[1, 1].ToString();
                string[] protas = arreglo[1, 2].ToString().Split(',');
                for (int i = 0; i < protas.Length; i++)
                {
                    elemento+= protas[i];
                    lsProta.Items.Add(elemento);
                    elemento = "";
                }

                label6.Text = arreglo[1, 3].ToString();
                label7.Text = arreglo[1, 4].ToString();
                label9.Text = arreglo[1, 5].ToString();
                txtSip.Text=arreglo[1,6].ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "GAME OF THRONES")
            {
                label1.Text = arreglo[0, 0].ToString();
                label4.Text = arreglo[0, 1].ToString();
                string[] protas1 = arreglo[0, 2].ToString().Split(',');
                for (int i = 0; i < protas1.Length; i++)
                {
                    elemento += protas1[i];
                    lsProta.Items.Add(elemento);
                    elemento = "";
                }

                label6.Text = arreglo[0, 3].ToString();
                label7.Text = arreglo[0, 4].ToString();
                label9.Text = arreglo[0, 5].ToString();
                txtSip.Text = arreglo[0, 6].ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "THE MARVELOUS MRS. MAISEL")
            {
                label1.Text = arreglo[2, 0].ToString();
                label4.Text = arreglo[2, 1].ToString();
                string[] protas2 = arreglo[2, 2].ToString().Split(',');
                for (int i = 0; i < protas2.Length; i++)
                {
                    elemento += protas2[i];
                    lsProta.Items.Add(elemento);
                    elemento = "";
                }

                label6.Text = arreglo[2, 3].ToString();
                label7.Text = arreglo[2, 4].ToString();
                label9.Text = arreglo[2, 5].ToString();
                txtSip.Text = arreglo[2, 6].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblImgLibros.ImageIndex = comboBox2.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarMatriz(arreglo);
            LlenarMatrizLenguaje();
            string elemento = string.Empty;

            lblImgLeng.ImageIndex = comboBox3.SelectedIndex;

            if (comboBox3.SelectedItem.ToString()== "PYTHON")
            {
                label21.Text = arreglo[0, 0].ToString();
                label20.Text = arreglo[0, 1].ToString();
                string[] ext = arreglo[0, 2].ToString().Split(',');
                for (int i = 0; i < ext.Length; i++)
                {
                    elemento += ext[i];
                    lsLen.Items.Add(elemento);
                    elemento = "";
                }

                label18.Text = arreglo[0, 3].ToString();
                label17.Text = arreglo[0, 4].ToString();
                label3.Text = arreglo[0, 5].ToString();
                txtPar.Text = arreglo[0, 6].ToString();
            }
        }
    }
}
