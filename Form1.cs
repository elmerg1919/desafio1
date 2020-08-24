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

namespace LoginBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string password;

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            string user = textUser.Text;
            string pass = textPass.Text;
            string url = "C:\\Registro\\" + user + ".txt";

            if (File.Exists(url))
            {
                MessageBox.Show("ERROR.  Usuario ya existe!");
                textUser.Clear();
                textUser.Clear();
            }
            else
            {
                File.WriteAllText(url, pass);
                /*CREA UN NUEVO ARCHIVO CON ESE NOMBRE Y GUARDA DENTRO DEL ARCHIVO EL VAOR DEL SEGUNDO PARAMETRO*/
                MessageBox.Show("Usuario registrado!");
                textUser.Clear();
                textPass.Clear();

            }
                
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string user = textUser.Text;
            string pass = textPass.Text;
            string url= "C:\\Registro\\" + user + ".txt";

            if (File.Exists(url))
            {
                password = File.ReadAllText(url);
              //LEE EL TEXTO ALMACENADO DENTRO DEL ARCHIVO 

            if (pass.Equals(password)) //verifica si la contraseña es igual al archivo 
                {
                    MessageBox.Show("BIENVENIDO");
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA INCORRECTA");
                }
            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO");
                
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
