namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbValor1 = new Label();
            lbValor2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            btnSomar = new Button();
            btnDivisao = new Button();
            bntMultiplicaçao = new Button();
            bntSubtraçao = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            lbPeso = new Label();
            lbAltura = new Label();
            btnIMC = new Button();
            SuspendLayout();
            // 
            // lbValor1
            // 
            lbValor1.AutoSize = true;
            lbValor1.Location = new Point(39, 35);
            lbValor1.Name = "lbValor1";
            lbValor1.Size = new Size(42, 15);
            lbValor1.TabIndex = 0;
            lbValor1.Text = "Valor 1";
            // 
            // lbValor2
            // 
            lbValor2.AutoSize = true;
            lbValor2.Location = new Point(39, 73);
            lbValor2.Name = "lbValor2";
            lbValor2.Size = new Size(42, 15);
            lbValor2.TabIndex = 1;
            lbValor2.Text = "Valor 2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(87, 27);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(87, 65);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 3;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(114, 103);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(73, 28);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(39, 103);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(59, 28);
            btnDivisao.TabIndex = 5;
            btnDivisao.Text = "Divisao";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // bntMultiplicaçao
            // 
            bntMultiplicaçao.Location = new Point(114, 155);
            bntMultiplicaçao.Name = "bntMultiplicaçao";
            bntMultiplicaçao.Size = new Size(88, 28);
            bntMultiplicaçao.TabIndex = 6;
            bntMultiplicaçao.Text = "Multiplicaçao";
            bntMultiplicaçao.UseVisualStyleBackColor = true;
            bntMultiplicaçao.Click += bntMultiplicaçao_Click;
            // 
            // bntSubtraçao
            // 
            bntSubtraçao.Location = new Point(25, 155);
            bntSubtraçao.Name = "bntSubtraçao";
            bntSubtraçao.Size = new Size(73, 29);
            bntSubtraçao.TabIndex = 7;
            bntSubtraçao.Text = "Subraçao";
            bntSubtraçao.UseVisualStyleBackColor = true;
            bntSubtraçao.Click += bntSubtraçao_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(467, 82);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(129, 23);
            txtAltura.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(467, 35);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(129, 23);
            txtPeso.TabIndex = 11;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(396, 43);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 12;
            lbPeso.Text = "Peso";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(391, 90);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 13;
            lbAltura.Text = "Altura";
            // 
            // btnIMC
            // 
            btnIMC.Location = new Point(436, 135);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(132, 34);
            btnIMC.TabIndex = 14;
            btnIMC.Text = "IMC";
            btnIMC.UseVisualStyleBackColor = true;
            btnIMC.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIMC);
            Controls.Add(lbAltura);
            Controls.Add(lbPeso);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(bntSubtraçao);
            Controls.Add(bntMultiplicaçao);
            Controls.Add(btnDivisao);
            Controls.Add(btnSomar);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lbValor2);
            Controls.Add(lbValor1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbValor1;
        private Label lbValor2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnSomar;
        private Button btnDivisao;
        private Button bntMultiplicaçao;
        private Button bntSubtraçao;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label lbPeso;
        private Label lbAltura;
        private Button btnIMC;
    }
}
