namespace Projetoteste
{
    partial class MeuPrograma
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeuPrograma));
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.pacela2 = new System.Windows.Forms.TextBox();
            this.pacela1 = new System.Windows.Forms.TextBox();
            this.Cancela = new System.Windows.Forms.Button();
            this.menssagemDeErro = new System.Windows.Forms.TextBox();
            this.limpa = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.menor = new System.Windows.Forms.Button();
            this.mutiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultado.Location = new System.Drawing.Point(255, 336);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(216, 22);
            this.resultado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacela 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(161, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pacela 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor das pacelas";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.btCalcular.Location = new System.Drawing.Point(255, 366);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 28);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btnok_Click);
            // 
            // pacela2
            // 
            this.pacela2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacela2.Location = new System.Drawing.Point(255, 217);
            this.pacela2.Margin = new System.Windows.Forms.Padding(4);
            this.pacela2.Name = "pacela2";
            this.pacela2.Size = new System.Drawing.Size(216, 26);
            this.pacela2.TabIndex = 5;
            // 
            // pacela1
            // 
            this.pacela1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacela1.Location = new System.Drawing.Point(255, 167);
            this.pacela1.Margin = new System.Windows.Forms.Padding(4);
            this.pacela1.Name = "pacela1";
            this.pacela1.Size = new System.Drawing.Size(216, 26);
            this.pacela1.TabIndex = 6;
            // 
            // Cancela
            // 
            this.Cancela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancela.Location = new System.Drawing.Point(521, 443);
            this.Cancela.Margin = new System.Windows.Forms.Padding(4);
            this.Cancela.Name = "Cancela";
            this.Cancela.Size = new System.Drawing.Size(100, 28);
            this.Cancela.TabIndex = 7;
            this.Cancela.Text = "CANCELA";
            this.Cancela.UseVisualStyleBackColor = false;
            this.Cancela.Click += new System.EventHandler(this.Cancela_Click);
            // 
            // menssagemDeErro
            // 
            this.menssagemDeErro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menssagemDeErro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menssagemDeErro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.menssagemDeErro.ForeColor = System.Drawing.Color.Brown;
            this.menssagemDeErro.Location = new System.Drawing.Point(255, 319);
            this.menssagemDeErro.Name = "menssagemDeErro";
            this.menssagemDeErro.Size = new System.Drawing.Size(216, 15);
            this.menssagemDeErro.TabIndex = 8;
            // 
            // limpa
            // 
            this.limpa.BackColor = System.Drawing.Color.Yellow;
            this.limpa.Location = new System.Drawing.Point(371, 366);
            this.limpa.Margin = new System.Windows.Forms.Padding(4);
            this.limpa.Name = "limpa";
            this.limpa.Size = new System.Drawing.Size(100, 28);
            this.limpa.TabIndex = 9;
            this.limpa.Text = "LIMPA";
            this.limpa.UseVisualStyleBackColor = false;
            this.limpa.Click += new System.EventHandler(this.limpa_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.Color.YellowGreen;
            this.soma.Location = new System.Drawing.Point(255, 283);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(28, 23);
            this.soma.TabIndex = 10;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // menor
            // 
            this.menor.BackColor = System.Drawing.Color.OrangeRed;
            this.menor.Location = new System.Drawing.Point(289, 283);
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(28, 23);
            this.menor.TabIndex = 11;
            this.menor.Text = "-";
            this.menor.UseVisualStyleBackColor = false;
            this.menor.Click += new System.EventHandler(this.menor_Click);
            // 
            // mutiplicacao
            // 
            this.mutiplicacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mutiplicacao.Location = new System.Drawing.Point(323, 283);
            this.mutiplicacao.Name = "mutiplicacao";
            this.mutiplicacao.Size = new System.Drawing.Size(28, 23);
            this.mutiplicacao.TabIndex = 12;
            this.mutiplicacao.Text = "x";
            this.mutiplicacao.UseVisualStyleBackColor = false;
            this.mutiplicacao.Click += new System.EventHandler(this.mutiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.SystemColors.Info;
            this.divisao.Location = new System.Drawing.Point(357, 283);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(28, 23);
            this.divisao.TabIndex = 13;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(252, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Escolha uma opção!!";
            // 
            // MeuPrograma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.mutiplicacao);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.limpa);
            this.Controls.Add(this.menssagemDeErro);
            this.Controls.Add(this.Cancela);
            this.Controls.Add(this.pacela1);
            this.Controls.Add(this.pacela2);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeuPrograma";
            this.Text = " Meu Programa";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox pacela2;
        private System.Windows.Forms.TextBox pacela1;
        private System.Windows.Forms.Button Cancela;
        private System.Windows.Forms.TextBox menssagemDeErro;
        private System.Windows.Forms.Button limpa;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button menor;
        private System.Windows.Forms.Button mutiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Label label4;
    }
}

