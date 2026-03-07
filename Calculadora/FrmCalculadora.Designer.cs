namespace Calculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            bntNove = new Button();
            btnDividir = new Button();
            btnOito = new Button();
            bntSeis = new Button();
            bntCinco = new Button();
            bntSete = new Button();
            bntQuatro = new Button();
            bntTres = new Button();
            bntDois = new Button();
            bntUm = new Button();
            button9 = new Button();
            button10 = new Button();
            bntLimpar = new Button();
            bntLimparTudo = new Button();
            bntSoma = new Button();
            bntMultiplicar = new Button();
            bntSubtrair = new Button();
            bntCalcular = new Button();
            txtCalculo = new TextBox();
            SuspendLayout();
            // 
            // bntNove
            // 
            bntNove.BackColor = SystemColors.Desktop;
            bntNove.FlatStyle = FlatStyle.Popup;
            bntNove.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntNove.ForeColor = Color.Lavender;
            bntNove.Location = new Point(171, 194);
            bntNove.Name = "bntNove";
            bntNove.Size = new Size(80, 75);
            bntNove.TabIndex = 11;
            bntNove.Text = "9";
            bntNove.UseVisualStyleBackColor = false;
            bntNove.Click += Botao_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = SystemColors.WindowFrame;
            btnDividir.FlatStyle = FlatStyle.Popup;
            btnDividir.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(257, 113);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(80, 75);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += Operador_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.Desktop;
            btnOito.FlatStyle = FlatStyle.Popup;
            btnOito.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOito.ForeColor = Color.Lavender;
            btnOito.Location = new Point(87, 194);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(80, 75);
            btnOito.TabIndex = 21;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += Botao_Click;
            // 
            // bntSeis
            // 
            bntSeis.BackColor = SystemColors.Desktop;
            bntSeis.FlatStyle = FlatStyle.Popup;
            bntSeis.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSeis.ForeColor = Color.Lavender;
            bntSeis.Location = new Point(171, 275);
            bntSeis.Name = "bntSeis";
            bntSeis.Size = new Size(80, 75);
            bntSeis.TabIndex = 22;
            bntSeis.Text = "6";
            bntSeis.UseVisualStyleBackColor = false;
            bntSeis.Click += Botao_Click;
            // 
            // bntCinco
            // 
            bntCinco.BackColor = SystemColors.Desktop;
            bntCinco.FlatStyle = FlatStyle.Popup;
            bntCinco.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntCinco.ForeColor = Color.Lavender;
            bntCinco.Location = new Point(87, 275);
            bntCinco.Name = "bntCinco";
            bntCinco.Size = new Size(80, 75);
            bntCinco.TabIndex = 23;
            bntCinco.Text = "5";
            bntCinco.UseVisualStyleBackColor = false;
            bntCinco.Click += Botao_Click;
            // 
            // bntSete
            // 
            bntSete.BackColor = SystemColors.Desktop;
            bntSete.FlatStyle = FlatStyle.Popup;
            bntSete.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSete.ForeColor = Color.Lavender;
            bntSete.Location = new Point(1, 194);
            bntSete.Name = "bntSete";
            bntSete.Size = new Size(80, 75);
            bntSete.TabIndex = 24;
            bntSete.Text = "7";
            bntSete.UseVisualStyleBackColor = false;
            bntSete.Click += Botao_Click;
            // 
            // bntQuatro
            // 
            bntQuatro.BackColor = SystemColors.Desktop;
            bntQuatro.FlatStyle = FlatStyle.Popup;
            bntQuatro.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntQuatro.ForeColor = Color.Lavender;
            bntQuatro.Location = new Point(1, 275);
            bntQuatro.Name = "bntQuatro";
            bntQuatro.Size = new Size(80, 75);
            bntQuatro.TabIndex = 25;
            bntQuatro.Text = "4";
            bntQuatro.UseVisualStyleBackColor = false;
            bntQuatro.Click += Botao_Click;
            // 
            // bntTres
            // 
            bntTres.BackColor = SystemColors.Desktop;
            bntTres.FlatStyle = FlatStyle.Popup;
            bntTres.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntTres.ForeColor = Color.Lavender;
            bntTres.Location = new Point(171, 356);
            bntTres.Name = "bntTres";
            bntTres.Size = new Size(80, 75);
            bntTres.TabIndex = 26;
            bntTres.Text = "3";
            bntTres.UseVisualStyleBackColor = false;
            bntTres.Click += Botao_Click;
            // 
            // bntDois
            // 
            bntDois.BackColor = SystemColors.Desktop;
            bntDois.FlatStyle = FlatStyle.Popup;
            bntDois.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntDois.ForeColor = Color.Lavender;
            bntDois.Location = new Point(85, 356);
            bntDois.Name = "bntDois";
            bntDois.Size = new Size(80, 75);
            bntDois.TabIndex = 27;
            bntDois.Text = "2";
            bntDois.UseVisualStyleBackColor = false;
            bntDois.Click += Botao_Click;
            // 
            // bntUm
            // 
            bntUm.BackColor = SystemColors.Desktop;
            bntUm.FlatStyle = FlatStyle.Popup;
            bntUm.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntUm.ForeColor = Color.Lavender;
            bntUm.Location = new Point(1, 356);
            bntUm.Name = "bntUm";
            bntUm.Size = new Size(80, 75);
            bntUm.TabIndex = 28;
            bntUm.Text = "1";
            bntUm.UseVisualStyleBackColor = false;
            bntUm.Click += Botao_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Desktop;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Lavender;
            button9.Location = new Point(171, 435);
            button9.Name = "button9";
            button9.Size = new Size(80, 75);
            button9.TabIndex = 29;
            button9.Text = ",";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Botao_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Desktop;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Lavender;
            button10.Location = new Point(85, 435);
            button10.Name = "button10";
            button10.Size = new Size(80, 75);
            button10.TabIndex = 30;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Botao_Click;
            // 
            // bntLimpar
            // 
            bntLimpar.BackColor = SystemColors.Desktop;
            bntLimpar.FlatStyle = FlatStyle.Popup;
            bntLimpar.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntLimpar.ForeColor = Color.Lavender;
            bntLimpar.ImageKey = "(nenhum)";
            bntLimpar.Location = new Point(1, 435);
            bntLimpar.Name = "bntLimpar";
            bntLimpar.Size = new Size(80, 75);
            bntLimpar.TabIndex = 31;
            bntLimpar.Text = "C";
            bntLimpar.UseVisualStyleBackColor = false;
            bntLimpar.Click += Operador_Click;
            // 
            // bntLimparTudo
            // 
            bntLimparTudo.BackColor = SystemColors.Desktop;
            bntLimparTudo.FlatStyle = FlatStyle.Popup;
            bntLimparTudo.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntLimparTudo.ForeColor = Color.Lavender;
            bntLimparTudo.ImageKey = "(nenhum)";
            bntLimparTudo.Location = new Point(171, 113);
            bntLimparTudo.Name = "bntLimparTudo";
            bntLimparTudo.Size = new Size(80, 75);
            bntLimparTudo.TabIndex = 32;
            bntLimparTudo.Text = "CE";
            bntLimparTudo.UseVisualStyleBackColor = false;
            bntLimparTudo.Click += Operador_Click;
            // 
            // bntSoma
            // 
            bntSoma.BackColor = SystemColors.WindowFrame;
            bntSoma.FlatStyle = FlatStyle.Popup;
            bntSoma.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSoma.Location = new Point(257, 194);
            bntSoma.Name = "bntSoma";
            bntSoma.Size = new Size(80, 75);
            bntSoma.TabIndex = 33;
            bntSoma.Text = "+";
            bntSoma.UseVisualStyleBackColor = false;
            bntSoma.Click += Operador_Click;
            // 
            // bntMultiplicar
            // 
            bntMultiplicar.BackColor = SystemColors.WindowFrame;
            bntMultiplicar.FlatStyle = FlatStyle.Popup;
            bntMultiplicar.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntMultiplicar.Location = new Point(257, 275);
            bntMultiplicar.Name = "bntMultiplicar";
            bntMultiplicar.Size = new Size(80, 75);
            bntMultiplicar.TabIndex = 34;
            bntMultiplicar.Text = "*";
            bntMultiplicar.UseVisualStyleBackColor = false;
            bntMultiplicar.Click += Operador_Click;
            // 
            // bntSubtrair
            // 
            bntSubtrair.BackColor = SystemColors.WindowFrame;
            bntSubtrair.FlatStyle = FlatStyle.Popup;
            bntSubtrair.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntSubtrair.Location = new Point(257, 356);
            bntSubtrair.Name = "bntSubtrair";
            bntSubtrair.Size = new Size(80, 75);
            bntSubtrair.TabIndex = 35;
            bntSubtrair.Text = "-";
            bntSubtrair.UseVisualStyleBackColor = false;
            bntSubtrair.Click += Operador_Click;
            // 
            // bntCalcular
            // 
            bntCalcular.BackColor = SystemColors.WindowFrame;
            bntCalcular.FlatStyle = FlatStyle.Popup;
            bntCalcular.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCalcular.Location = new Point(257, 433);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(80, 75);
            bntCalcular.TabIndex = 36;
            bntCalcular.Text = "=";
            bntCalcular.UseVisualStyleBackColor = false;
            bntCalcular.Click += bntCalcular_Click;
            // 
            // txtCalculo
            // 
            txtCalculo.BackColor = SystemColors.Desktop;
            txtCalculo.Font = new Font("Segoe UI", 30F);
            txtCalculo.ForeColor = SystemColors.Window;
            txtCalculo.Location = new Point(5, 12);
            txtCalculo.Multiline = true;
            txtCalculo.Name = "txtCalculo";
            txtCalculo.Size = new Size(332, 81);
            txtCalculo.TabIndex = 37;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(349, 510);
            Controls.Add(txtCalculo);
            Controls.Add(bntCalcular);
            Controls.Add(bntSubtrair);
            Controls.Add(bntMultiplicar);
            Controls.Add(bntSoma);
            Controls.Add(bntLimparTudo);
            Controls.Add(bntLimpar);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(bntUm);
            Controls.Add(bntDois);
            Controls.Add(bntTres);
            Controls.Add(bntQuatro);
            Controls.Add(bntSete);
            Controls.Add(bntCinco);
            Controls.Add(bntSeis);
            Controls.Add(btnOito);
            Controls.Add(btnDividir);
            Controls.Add(bntNove);
            ForeColor = Color.Lavender;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bntNove;
        private Button btnDividir;
        private Button btnOito;
        private Button bntSeis;
        private Button bntCinco;
        private Button bntSete;
        private Button bntQuatro;
        private Button bntTres;
        private Button bntDois;
        private Button bntUm;
        private Button button9;
        private Button button10;
        private Button bntLimpar;
        private Button bntLimparTudo;
        private Button bntSoma;
        private Button bntMultiplicar;
        private Button bntSubtrair;
        private Button bntCalcular;
        private TextBox txtCalculo;
    }
}
