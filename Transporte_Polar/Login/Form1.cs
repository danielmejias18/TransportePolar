
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transporte_Polar.Login;
using Transporte_Polar.Ventanas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transporte_Polar
{
    public partial class Form1 : Form
    {
        public string usuarios, clave;
        public string fileName = "example1.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\mejia\Desktop\C#\giphy.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            // Checks if the ID text field is empty.
            if (textBoxUsuario.Text == string.Empty || textBoxUsuario.Text == string.Empty)
            {
                MessageBox.Show("Please introduce the ID");
            }
            else
            {
                // Retrieves the ID from the text field.
                usuarios = textBoxUsuario.Text;
                clave = textBoxClave.Text;

                // Fetches the current list of customers.
                var list = Repository.UsuariosList();
                Usuarios usuariosAdmin = list.Find(x => x.Usuario.ToLower() == usuarios.ToLower() && x.Clave.ToLower() == clave.ToLower());
                if (usuariosAdmin != null)
                {
                    
                   // MenuPrincipal menu = new MenuPrincipal();
                    //menu.Show();

                    new MenuPrincipal().Show();
                   



                }
                else
                {
                    MessageBox.Show("El usuario o la clave es erroneo");
                }

             }
            


        }
    }
}
