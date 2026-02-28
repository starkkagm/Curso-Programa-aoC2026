


namespace CursoProgramacao
{
    public class Aula3
    {
       //Switch

        public void AvaliaçaoSwitch()
        {
            Console.WriteLine("Infome Sua Nota");
            int Nota;
            Nota = int.Parse(Console.ReadLine());

            switch (Nota)
            {
                case >= 7:
                    Console.WriteLine("Aprovado");
                    break;

                case >= 5:
                    Console.WriteLine("Recuperação");
                    break;

               default:
                    Console.WriteLine("Reprovado");
                    break;

             }







        }

        public void CategoriaIdade()
        {
            Console.WriteLine("Informe Sua Idade");
            int idade;
            idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case >= 60:
                    Console.WriteLine("Idoso");
                    break;

                case >= 30:
                    Console.WriteLine("Adulto");
                    break;

                case >= 20:
                    Console.WriteLine("Jovem");
                    break;

                case >= 10:
                    Console.WriteLine("Adolecente");
                    break;

                default:
                    Console.WriteLine("Criança");
                    break;
                } 
           }   
    }
}
