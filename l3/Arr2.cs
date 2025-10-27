using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    internal class Arr2
    {
        private int[,] arr2;

        public Arr2(int[,] arr2)
        {
            this.arr2 = arr2;
        }

        public void KeyboardArr()
        {
            int height = arr2.GetLength(0);
            int width = arr2.GetLength(1);

            Console.WriteLine("Массив введенный с клавиатуры(nxm): ");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void RandomArr()
        {

            int height = arr2.GetLength(0);
            int width = arr2.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int rnd_num = 0;
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            do
                            {
                                rnd_num = random.Next(1, 9);
                            }
                            while (rnd_num % 2 == 0);
                        } 
                        else
                        {
                            do
                            {
                                rnd_num = random.Next(1, 9);
                            }
                            while (rnd_num % 2 != 0);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            do
                            {
                                rnd_num = random.Next(1, 9);
                            }
                            while (rnd_num % 2 != 0);
                        }
                        else
                        {
                            do
                            {
                                rnd_num = random.Next(1, 9);
                            }
                            while (rnd_num % 2 == 0);
                        }
                    }

                    arr2[i, j] = rnd_num;
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив рандомных чисел(nxn): ");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        
    }
}
