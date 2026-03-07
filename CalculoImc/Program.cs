partial class Program
{
    static void Main(string[] args)
    {
        float peso;
        float altura;
        string opcao;
        //Estrutura de repetiçao
        
        while (true)
        {
            //solicitando as Informaçoes 
            Console.WriteLine("Me informe seu Peso");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora Informe Sua Altura");
            altura = float.Parse(Console.ReadLine());

            Console.Clear();

            ///Fazer o Calculo 
            float imc = peso / (altura * altura);

            Console.WriteLine($"Seu Imc é: {imc:F2}");

            Console.WriteLine("Sua Classificação é");

            if (imc >= 40)
            {
                Console.WriteLine("Obesidade III (Mórbida)");
            }
            else if (imc >= 35)
            {
                Console.WriteLine("Obesidade Grau II(SEVERA)");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc >= 25)
            {
                Console.WriteLine("Levemente Acima do Peso");
            }
            else if (imc >= 18.6)
            {
                Console.WriteLine("Peso Ideal (Parabens)");
            }
            else
            {
                Console.WriteLine("Abaixo Do Peso");
            }






                Console.WriteLine("Deseja Refazer ? S/N");

            opcao =Console.ReadLine();
            
            //Finaliazr a estutura de repetiçao
         
          if (opcao != "S")
            {
                break;
            }
            Console.Clear();
        }





















    }
}
