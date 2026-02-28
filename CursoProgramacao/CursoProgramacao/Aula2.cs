
namespace CursoProgramacao
{
    public class aula2
    {
        public void ValorPar()
        {
            Console.WriteLine("Informe Um Valor");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Esse Numero é Par");
            }

            else
            {
                Console.WriteLine("Esse numero é Impar");
            }

        }

        public void MaiorIdade()
        {
            Console.WriteLine("Informe sua Idade!");
            int idade;
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Voce é Maior de idade, prossiga ");

            }
            else
            {
                Console.WriteLine("É Necessario Ser Maior de Idade");
            
            }
        }

        public void Aprovado()
        {
            Console.WriteLine("Informe sua Nota");
            int Nota;
            Nota = int.Parse(Console.ReadLine());

            if (Nota >= 7)
            {
                Console.WriteLine("Você Está APROVADO");
            }
            else if (Nota >= 5)
            {
                Console.WriteLine("Você Está de RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("Você Está REPROVADO");
            }











        }
    
    }
}


