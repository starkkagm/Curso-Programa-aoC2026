namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);


            MessageBox.Show((v1 + v2).ToString(), "Calculo",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);


            MessageBox.Show((v1 / v2).ToString(), "Calculo",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bntSubtraçao_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);


            MessageBox.Show((v1 - v2).ToString(), "Calculo",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bntMultiplicaçao_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtValor1.Text);
            int v2 = int.Parse(txtValor2.Text);


            MessageBox.Show((v1 * v2).ToString(), "Calculo",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float imc;
            imc = peso / (altura*altura);

           

                












        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }



}
