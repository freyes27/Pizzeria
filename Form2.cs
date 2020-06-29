using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Menupizza : Form
    {
        public Menupizza()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonPedido_Click(object sender, EventArgs e)
        {
            {
                int pedido = Pedidos.Rows.Add();
                int PizzaFamiliar = 22000;
                int PizzMediana = 12000;
                int PizzaIndividual = 8000;
                int Individual = 1500;
                int Familiar = 5000;
                int cantPiz = Convert.ToInt32(Cajapizza.Text);
                int cantBeb = Convert.ToInt32(Cajabebida.Text);


                if (BotonFamiliar.Checked == true && BotonBebida1.Checked == true)
                {

                    Pedidos.Rows[pedido].Cells[0].Value = Cajapizza.Text;
                    Pedidos.Rows[pedido].Cells[1].Value = BotonFamiliar.Text;
                    Pedidos.Rows[pedido].Cells[2].Value = Cajabebida.Text;
                    Pedidos.Rows[pedido].Cells[3].Value = BotonBebida1.Text;
                    Pedidos.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaFamiliar) + (cantBeb * Individual));
                }
                else if (BotonFamiliar.Checked == true && BotonBebida2.Checked == true)
                {
                    Pedidos.Rows[pedido].Cells[0].Value = Cajapizza.Text;
                    Pedidos.Rows[pedido].Cells[1].Value = BotonFamiliar.Text;
                    Pedidos.Rows[pedido].Cells[2].Value = Cajabebida.Text;
                    Pedidos.Rows[pedido].Cells[3].Value = BotonBebida2.Text;
                    Pedidos.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaFamiliar) + (cantBeb * Familiar));
                }
                if (BotonMediana.Checked == true && BotonBebida1.Checked == true)
                {
                    Pedidos.Rows[pedido].Cells[0].Value = Cajapizza.Text;
                    Pedidos.Rows[pedido].Cells[1].Value = BotonMediana.Text;
                    Pedidos.Rows[pedido].Cells[2].Value = Cajabebida.Text;
                    Pedidos.Rows[pedido].Cells[3].Value = BotonBebida1.Text;
                    Pedidos.Rows[pedido].Cells[4].Value = ((cantPiz * PizzMediana) + (cantBeb * Individual));
                }
                else if (BotonMediana.Checked == true && BotonBebida2.Checked == true)
                {
                    Pedidos.Rows[pedido].Cells[0].Value = Cajapizza.Text;
                    Pedidos.Rows[pedido].Cells[1].Value = BotonMediana.Text;
                    Pedidos.Rows[pedido].Cells[2].Value = Cajabebida.Text;
                    Pedidos.Rows[pedido].Cells[3].Value = BotonBebida2.Text;
                    Pedidos.Rows[pedido].Cells[4].Value = ((cantPiz * PizzMediana) + (cantBeb * Familiar));
                }
                if (BotonIndividual.Checked == true && BotonBebida1.Checked == true)
                {
                    Pedidos.Rows[pedido].Cells[0].Value = Cajapizza.Text;
                    Pedidos.Rows[pedido].Cells[1].Value = BotonIndividual.Text;
                    Pedidos.Rows[pedido].Cells[2].Value = Cajabebida.Text;
                    Pedidos.Rows[pedido].Cells[3].Value = BotonBebida1.Text;
                    Pedidos.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaIndividual) + (cantBeb * Individual));
                }
                else if (BotonIndividual.Checked == true && BotonBebida2.Checked == true)
                {
                    Pedidos.Rows[pedido].Cells[0].Value = Cajapizza.Text;
                    Pedidos.Rows[pedido].Cells[1].Value = BotonIndividual.Text;
                    Pedidos.Rows[pedido].Cells[2].Value = Cajabebida.Text;
                    Pedidos.Rows[pedido].Cells[3].Value = BotonBebida2.Text;
                    Pedidos.Rows[pedido].Cells[4].Value = ((cantPiz * PizzaIndividual) + (cantBeb * Individual));
                }


            }
        }

        private void BotonCerrarCja_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(Pedidos.Columns["Total"]);
            int sum = 0;
            for (int i = 0; i < Pedidos.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(Pedidos.Rows[i].Cells[4].Value);
            }



            MessageBox.Show("Total Vendido: " + "$ " + sum.ToString());
            MessageBox.Show("Gracias por su compra!");
            MessageBox.Show("Vuelva pronto!");
            MessageBox.Show("Cuidese del tio Covid");


            this.Close();
            Login otro = new Login();
            otro.Show();


        }
    }
}

   