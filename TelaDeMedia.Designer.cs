namespace Projetoteste
{
    partial class TelaDeMedia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valorDigitado = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Valores = new System.Windows.Forms.ListBox();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valorDigitado
            // 
            this.valorDigitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorDigitado.Location = new System.Drawing.Point(42, 112);
            this.valorDigitado.Name = "valorDigitado";
            this.valorDigitado.Size = new System.Drawing.Size(179, 20);
            this.valorDigitado.TabIndex = 1;
            this.valorDigitado.Click += new System.EventHandler(this.valorDigitado_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdicionar.Location = new System.Drawing.Point(42, 160);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(66, 22);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(137, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Media";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Valores
            // 
            this.Valores.FormattingEnabled = true;
            this.Valores.Location = new System.Drawing.Point(240, 112);
            this.Valores.Name = "Valores";
            this.Valores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Valores.Size = new System.Drawing.Size(83, 264);
            this.Valores.TabIndex = 5;
            this.Valores.SelectedIndexChanged += new System.EventHandler(this.Valores_SelectedIndexChanged);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Red;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(712, 406);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(77, 31);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // TelaDeMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.valorDigitado);
            this.Name = "TelaDeMedia";
            this.Text = "Medias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valorDigitado;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Button Sair;
    }
}