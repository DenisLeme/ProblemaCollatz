using System;

namespace ProblemaCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int numeroInicial = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sequência para o número {numeroInicial}:");
            MostrarSequenciaCollatz(numeroInicial);
        }

        static void MostrarSequenciaCollatz(int numero)
        {
            Console.Write($"{numero} ");

            while (numero != 1)
            {
                if (numero % 2 == 0)
                    numero /= 2;
                else
                    numero = (3 * numero) + 1;

                Console.Write($"{numero} ");
            }

            Console.WriteLine();
        }
    }
}
