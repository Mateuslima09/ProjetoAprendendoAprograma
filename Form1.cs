using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetoteste
{
    public partial class Formteste : Form
    {
        int valor1;
        //valor da 1 pacela

        int valor2;
        // valor da 2 pacela 

        int res;
        //resultado da pacelas


        public Formteste()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(pacela1.Text);
            //converte o valor1  texto em numero inteiro.
            valor2 = int.Parse(pacela2.Text);
            // + , - , * , / , %


            // 10/2=5
            // 10%2=0 operador e oq sobra na divisao.
            // 10%3=1
            // 15%3=1

            res = valor1 + valor2;
            // resultado recebe o valor1 + o valor2.
           

            resultado.Text = Convert.ToString(res);
            // converte o texto em string ( caracteres ) no campo resultaado.


            
        }

    }
}
