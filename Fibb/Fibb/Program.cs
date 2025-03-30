using System;

namespace Fibb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[,] { { 1, 1 }, { 1, 0 } };
            var result = (int[,])array.Clone();
            var power = 5;

            if (power > 1)
            {
                result = new int[,] { { 1, 0 }, { 0, 1 } };

                while (power > 0)
                {
                    if (power % 2 == 1)
                    {
                        result = Multiply(result, array);
                    }
                    array = Multiply(array, array);
                    power /= 2;
                }
            }

            Console.WriteLine(result[0, 0]);
        }
        static int[,] Multiply(int[,] a, int[,] b)
        {
            var result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
    }
}