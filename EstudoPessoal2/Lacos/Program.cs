// Desafio: Imprimir os números de 1 a 50, mas somente os múltiplos de 5 ou múltiplos de 7.

using System ;

class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Números primos entre 1 e 100: ");

            int i ;
            for(i = 1; i <= 50; i ++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    Console.Write(i + " ");
                }

            }
        }
}