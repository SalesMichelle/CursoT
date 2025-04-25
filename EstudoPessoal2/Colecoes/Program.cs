

namespace Listas_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();

            valores.Add(16);
            valores.Add(18);
            valores.Add(23);
            valores.Add(12);

            int[] numeros = new int[] {32, 12, 7, 20};
            valores.AddRange(numeros);

            Console.WriteLine("A lista possui " + valores.Count() + " elementos");

        }
    }
}