using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<double> notas = new List<double>();

            while (true)
            {
                Console.WriteLine("Insira de 3 a 10 numeros: \t");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                if (quantidade < 3 || quantidade > 10)
                {
                    Console.WriteLine("Insira um numero valido! ");
                    Console.WriteLine();
                    continue;
                }

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine($"Digite o {i} numero: \t");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine() ;

                   notas.Add(numero);

                }
                Console.WriteLine(" =====  Lista de Notas ==== ");
                Console.WriteLine();

                foreach (int nota in notas)
                {
                    Console.WriteLine(nota);
                    Console.WriteLine();
                }

                double soma = CalcularSoma(notas);
                double media = CalcularMedia(notas);

                Console.WriteLine($"A soma de suas notas é de {soma}");
                Console.WriteLine();
                Console.WriteLine($" A Média das suas notas é de {media}");

                break;

            }


        }

        static double CalcularSoma(List<double> notas)
        {
            double Soma = 0;

            foreach ( int nota in notas)
            {
                Soma += nota;
            }
            return Soma;    
        }

        static double CalcularMedia(List<double> notas)
        {
            double soma = CalcularSoma(notas);
            return soma / notas.Count;
        }


    }
}