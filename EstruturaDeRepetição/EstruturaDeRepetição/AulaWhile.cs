

namespace EstruturaRepeticao
{
    internal class AulaWhile
    {
     public void MetodoWilhe()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
     
     public void TabuadaWhile()
        {
            int i = 0; 
         int tabuada = 0;
            Console.WriteLine("Infome  a Tabuada Desejada");
            tabuada = int.Parse(Console.ReadLine());

            while (i < 10)
            {
                Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
                i++;
            }
        }

        public void Calculos()
        {
            //Instanciando
            Calculos calculos = new Calculos();
            int v1 = 0;
            int v2 = 0;
            string operacao;

            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("|  Informw + para Somar        |");
                Console.WriteLine("|  Informw x para Multiplicar  |");
                Console.WriteLine("|  Informw - para Subtrair     |");
                Console.WriteLine("|  Informw / para Divisão      |");
                Console.WriteLine("================================");

                Console.WriteLine("Operação");
                operacao = Console.ReadLine();

                Console.Clear();
                //Coletar os VALORES 
                Console.WriteLine("Informe o Primeiro Valor");
                v1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o Segundo Valor");
                v2 = int.Parse(Console.ReadLine());

                //Calculos

                switch (operacao)
                {
                    case "+":
                        Console.WriteLine($" Soma:{calculos.Soma(v1, v2)}");
                        break;

                    case "x":
                        Console.WriteLine($" Multiplicaçao: {calculos.Multiplicar(v1, v2)}");
                        break;


                    case "-":
                        Console.WriteLine($" SuBtraçao: {calculos.Subtrair(v1, v2)}");
                        break;

                    case "/":
                        Console.WriteLine($" Divisao: {calculos.Dividir(v1, v2)}");
                        break;
                }

                //========Para While
                Console.WriteLine("Deseja Continuar ? s/n");
                operacao = Console.ReadLine();
                Console.WriteLine("Operação");
                Console.Clear();
                if (operacao == "s")
                {
                    
                    break;
                }


            }   
            


        }
    }
}
