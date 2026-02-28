using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
    public class Aula1
    {
        int valor1;
        int valor2;
        //Método Somar
        public void Soma()
        {
           


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Infome o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A Soma é: {valor1 + valor2}");

        }
        //Método Multiplicar 
        public void Multiplicar()
        {

            


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Infome o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A Multiplicaçao é: {valor1 * valor2}");
        }
        //Metdo Dividir
        public void Divisao()
        {
            

            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"A Divisão é: \n {valor1 / valor2}");
        }
        //Subtrair 
        public void Subtrair()
        {
           ;
            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o calor 2");
            valor2 = int.Parse(Console.ReadLine());


            Console.WriteLine($" A Subtração é : {valor1 - valor2}");
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

} 
