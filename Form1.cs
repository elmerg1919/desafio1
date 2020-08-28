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
    public partial class Form1 : Form
    {
        private Dictionary<string, string> users= new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        public bool isEmpty(string cadena) 
        {
            if (cadena.Length == 0) { return true; }
            else { return false; }
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
           
            string user = textUser.Text;
            string pass = textPass.Text;

            if (isEmpty(textUser.Text))
            {
                MessageBox.Show("Usuario invalido, no puede estar vacío", "Usuario vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUser.Text = "";
                textUser.Focus();
            }
            else if (isEmpty(textPass.Text))
            {
                MessageBox.Show("Usuario invalido, no puede estar vacio", "Contraseña vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPass.Text = "";
                textPass.Focus();
            }
            else
            {
                if (users.Keys.Contains(user))
                {
                    MessageBox.Show("Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUser.Text = "";
                    textPass.Text = "";
                    textUser.Focus();
                }
                else
                {
                    users.Add(user, pass);
                    MessageBox.Show("Usuario ingresado exitosamente" + "\nPuede iniciar sesion", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textUser.Text = "";
                    textPass.Text = "";
                    textUser.Focus();
                }
            }
                            
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string user = textUser.Text;
            string pass = textPass.Text;

            if (users.Keys.Contains(user))
            {
                for (int i = 0; i < users.Count; i++)
                {
                    var item = users.ElementAt(i);
                    if (user == item.Key)
                    {
                        if (item.Value==pass)
                        {
                             MessageBox.Show("Bienvenido " + user, "Ingreso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form2 principal = new Form2();
                            principal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
