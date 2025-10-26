using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    internal class Array2
    {
        public void Run()
        {
            int[,] array2D = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
