using System;

namespace Linal_IDZ
{
    class Program
    {
        /// <summary>
        /// Улучшеный алгоритм Евклида.
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>gcd</returns>
        static int Gcd_euclid_enxanced(int a, int b)
        {
            while (a != 0 & b != 0)
                if (a > b)
                    a %= b;
                else
                    b %= a;
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            // Порядок по условию пункта б.
            int ord = 170;
            int counter = 0;
            for (int i = 3; i <= 510; i += 3)
            {
                if (Gcd_euclid_enxanced(i / 3, ord) == 1)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
            Console.WriteLine("Количество чисел:");
            Console.WriteLine(counter);
        }
    }
}
