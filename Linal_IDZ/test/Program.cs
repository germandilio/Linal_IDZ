using System;
using System.Collections.Generic;

/// <summary>
/// Здесь находится код для поиска делителей нуля для 8 задачи.
/// </summary>
namespace Linal_IDZ
{ 
    class Program
    {
        static void Main(string[] args)
        {

            List<Matrix> matrices = FillMatrixList();

            List<Matrix> result = FindDevidersOfZero(matrices);

            int counter = 0;
            Console.Clear();
            Console.WriteLine("Делители нуля:");
            Console.WriteLine("(Единица обозначает наличие элемента, при этом индекс" +
                " ставится в соответствии с изначальным \"трафаретом\" множества)");
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("\n" + result[i]);
                counter++;
            }

            Console.WriteLine("Количество:");
            Console.WriteLine(counter);
        }


        private static List<Matrix> FindDevidersOfZero(List<Matrix> matrices)
        {
            List<Matrix> result = new List<Matrix>();
            Matrix e = new Matrix(0, 0, 0, 0);

            for (int i = 0; i < matrices.Count; i++)
            {
                for (int j = 0; j < matrices.Count; j++)
                {
                    if ((matrices[i] * matrices[j]).Equals(e))
                    {
                        if (!result.Contains(matrices[i]))
                            result.Add(matrices[i]);
                        if (!result.Contains(matrices[j]))
                            result.Add(matrices[j]);
                    }
                }

            }
            return result;
        }

        private static List<Matrix> FillMatrixList()
        {
            List<Matrix> matrices = new List<Matrix>();

            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        for (int d = 0; d < 2; d++)
                        {
                            if ((a == 0) && (b == 0) && (c == 0) && (d == 0))
                                continue;
                            else
                                matrices.Add(new Matrix(a, b, c, d));
                        }
                    }
                }
            }

            return matrices;
        }
    }
}
