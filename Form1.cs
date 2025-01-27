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
    public partial class MeuPrograma : Form
    {
        double valor1;
        //valor da 1 pacela

        double valor2;
        // valor da 2 pacela 

        double res = 0;
        //resultado da pacelas


        public MeuPrograma()
        {
            InitializeComponent();
        }



        private void btnok_Click(object sender, EventArgs e)
        {



                menssagemDeErro.Text = String.Empty;

            


            

                valor1 = double.Parse(pacela1.Text);

                valor2 = double.Parse(pacela2.Text);


                res = valor1 + valor2;

                resultado.Text = Convert.ToString(res);

              
                


                if (res == 0)
                {
                    menssagemDeErro.Text = "Erro digite um numero valido";

                }


           


        }


        private void Cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpa_Click(object sender, EventArgs e)
        {
            pacela1.Text = String.Empty;
            pacela2.Text = String.Empty;
            resultado.Text = String.Empty;
            menssagemDeErro.Text = String.Empty;
        }

        private void soma_Click(object sender, EventArgs e)
        {

            valor1 = double.Parse(pacela1.Text);
   
            valor2 = double.Parse(pacela2.Text);

            
            res = valor1 + valor2;

            resultado.Text = Convert.ToString(res);



            menssagemDeErro.Text = String.Empty;

            if (res == 0)
            {
                menssagemDeErro.Text = "Erro digite um numero valido";


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

    }
}
