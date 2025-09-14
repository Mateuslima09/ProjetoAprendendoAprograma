namespace Projetoteste
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cancela = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.limpa = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pacela2 = new System.Windows.Forms.TextBox();
            this.pacela1 = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.Button();
            this.menor = new System.Windows.Forms.Button();
            this.mutiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // resultado
            // 
            this.resultado.Cursor = System.Windows.Forms.Cursors.No;
            this.resultado.Enabled = false;
            this.resultado.ForeColor = System.Drawing.Color.IndianRed;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacela 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(173, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pacela 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor das pacelas";
            // 
            // pacela2
            // 
            this.pacela2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacela2.Location = new System.Drawing.Point(255, 217);
            this.pacela2.Margin = new System.Windows.Forms.Padding(4);
            this.pacela2.Name = "pacela2";
            this.pacela2.Size = new System.Drawing.Size(216, 23);
            this.pacela2.TabIndex = 5;
            // 
            // pacela1
            // 
            this.pacela1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacela1.Location = new System.Drawing.Point(255, 167);
            this.pacela1.Margin = new System.Windows.Forms.Padding(4);
            this.pacela1.Name = "pacela1";
            this.pacela1.Size = new System.Drawing.Size(216, 23);
            this.pacela1.TabIndex = 6;
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
            this.divisao.Text = "÷";
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
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Escolha uma opção!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(157, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Aprendento a programa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(323, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMedia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMedia.FlatAppearance.BorderSize = 2;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(587, 81);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(154, 49);
            this.btnMedia.TabIndex = 17;
            this.btnMedia.Text = "Tela de media";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 475);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.mutiplicacao);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.limpa);
            this.Controls.Add(this.Cancela);
            this.Controls.Add(this.pacela1);
            this.Controls.Add(this.pacela2);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaInicial";
            this.Text = " Meu Programa";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button mutiplicacao;
        private System.Windows.Forms.Button menor;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button limpa;
        private System.Windows.Forms.Button Cancela;
        private System.Windows.Forms.TextBox pacela1;
        private System.Windows.Forms.TextBox pacela2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultado;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMedia;
    }
}

