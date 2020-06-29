using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace Pizzeria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BotonIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM TablaCajero WHERE nombre='{0}' AND contraseña='{1}'", CuadroUsuario.Text.Trim(), CuadroContra.Text.Trim());
                DataSet Ds = Utilidades.Ejecutar(CMD);

                string Usuario= Ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                string contraseña = Ds.Tables[0].Rows[0]["contraseña"].ToString().Trim();

                if (Usuario == CuadroUsuario.Text.Trim() && contraseña == CuadroContra.Text.Trim())
                {
                    this.Hide();
                    Menupizza menu1 = new Menupizza();
                    menu1.Show();
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show("Error en contraseña o usuario");

            }

        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

