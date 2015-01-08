using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entrar();
        }

        public void entrar()
        {
            MySqlConnection conexionAlternativa = SQL_Methods.IniciarConnection();
            
           
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuarios WHERE usr_usuario='" + txtUser.Text + "' and usr_password='" + txtPass.Text + "'", conexionAlternativa);
            MySqlDataReader ejecuta = consulta.ExecuteReader();

            if (ejecuta.Read() == true)
            {
                MessageBox.Show("Bienvenido " + txtUser.Text.ToUpper() + "!", "Usuario Correcto");
                conexionAlternativa.Close();
                string monto="0";
                //monto = Microsoft.VisualBasic.Interaction.InputBox("¿Desea ingresar el monto inicial de la caja?", "Caja", "0", Size.Height, Size.Width);
                //CenterToScreen();
                Form frmPantallaPrincipal = new frmPantallaPrincipal(int.Parse(monto));
                frmPantallaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese correctamente los datos", "Usuario Incorrecto");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                this.txtUser.Select();

            }
            //miConexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
