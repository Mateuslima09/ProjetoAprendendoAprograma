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
    public partial class TelaDeMedia : Form
    {
        public TelaDeMedia()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Close();
           
        }

        private void Valores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btnAdicionar_Click(object sender, EventArgs e)
        {
            double valoresAdicionados = 0;

            if (double.TryParse(valorDigitado.Text, out valoresAdicionados))
            {
                Valores.Items.Add(valoresAdicionados);
            }
            else
            {
                valorDigitado.ForeColor = Color.Red;
                valorDigitado.Text = "Valor invalido!";
                valorDigitado.ForeColor = SystemColors.ControlText;
            }


        }

        private void valorDigitado_Click(object sender, EventArgs e)
        {
            valorDigitado.Clear();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
