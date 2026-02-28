

namespace EstruturaRepeticao
{
    public class Aulafor
    {
        public void MetodoFor()
        {
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i);
            }
        }
    
        public void Tabuada()
        {
            Console.WriteLine("Infome a Tabuada");
            int tabuada; 
                tabuada = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
            }







        }
    
        public void SomaFor() 
        {
            int valor = 0;
            int resultado = 1;
            for(int i = 1; i <4; i++)
            {
                Console.WriteLine($"Informe {i}° valor:");
                valor = int.Parse(Console.ReadLine());

                resultado = resultado + valor;
            }
            Console.WriteLine($"Total da Soma:{resultado}");
        }

        public void MultiplicacaoFor()
        {



            int valor = 0;
            int resultado = 1;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Infome o {i}° Valor");
                valor = int.Parse(Console.ReadLine());


                resultado = resultado * valor;
             }
            Console.WriteLine($"O Resultado é {resultado}");
        }
    
    
    
    
    
    }
}
