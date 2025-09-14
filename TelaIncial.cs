using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetoteste
{
    public partial class TelaInicial : Form
    {
        double valor1;
        //valor da 1 pacela

        double valor2;
        // valor da 2 pacela 

        double res = 0;
        //resultado da pacelas


        public TelaInicial() => InitializeComponent();



        private void btnok_Click(object sender, EventArgs e)
        {



            if ((pacela1.Text == "") || pacela2.Text == "")
            {
                //metodo de erro para usuario
                //errorProvider1.SetError(pacela1, "ERRO digite um numero");

                if (pacela1.Text == "")
                {

                    errorProvider1.SetError(pacela1, "ERRO digite um numero");

                } 


                if (pacela2.Text == "")
                {

                    errorProvider1.SetError(pacela2, "ERRO digite um numero");

                }
            }


            else
            {
                valor1 = double.Parse(pacela1.Text);

                valor2 = double.Parse(pacela2.Text);


                res = valor1 + valor2;

                resultado.Text = Convert.ToString(res);

                errorProvider1.SetError(pacela1, "");
                errorProvider1.SetError(pacela2, "");
            }  


            //if ((res == 0)  || (valor1 == 0) || valor2 == 0 )
            //{  

                // resultado.Text = String.Empty;

           // }


        }


        private void Cancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpa_Click(object sender, EventArgs e)
        {
            pacela1.Text = String.Empty;
            pacela2.Text = String.Empty;
            resultado.Text = String.Empty;
           
        }

        private void soma_Click(object sender, EventArgs e)
        {


            if ((pacela1.Text == "") || pacela2.Text == "")
            {
                //metodo de erro para usuario
                //errorProvider1.SetError(pacela1, "ERRO digite um numero");

                if (pacela1.Text == "")
                {

                    errorProvider1.SetError(pacela1, "ERRO digite um numero");

                }


                if (pacela2.Text == "")
                {

                    errorProvider1.SetError(pacela2, "ERRO digite um numero");

                }
            }


            else
            {
                valor1 = double.Parse(pacela1.Text);

                valor2 = double.Parse(pacela2.Text);

                res = valor1 + valor2;

                resultado.Text = Convert.ToString(res);

                //limpa o erro acima
                errorProvider1.SetError(pacela1, "");
                errorProvider1.SetError(pacela2, "");

            }
            

            

            if ((valor1 == 0) || valor2 == 0)
            {

                resultado.Text = String.Empty;
                resultado.Text = "#Erro digite um numero!!";



                
            }

        }

        private void menor_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(pacela1.Text);

            valor2 = double.Parse(pacela2.Text);


            res = valor1 - valor2;

            resultado.Text = Convert.ToString(res);
        }

        private void mutiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(pacela1.Text);

            valor2 = double.Parse(pacela2.Text);


            res = valor1 * valor2;

            resultado.Text = Convert.ToString(res);
        }

        private void divisao_Click(object sender, EventArgs e)
        {

            valor1 = double.Parse(pacela1.Text);

            valor2 = double.Parse(pacela2.Text);


            res = valor1 / valor2;

            resultado.Text = Convert.ToString(res);

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            TelaDeMedia telaDeMedia = new TelaDeMedia();
            telaDeMedia.Show();
            this.Hide();
        }
    }
}
