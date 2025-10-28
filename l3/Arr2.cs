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

        public void PrintArr()
        {
            int height = arr2.GetLength(0);
            int width = arr2.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void KeyboardArr()
        {
            int height = arr2.GetLength(0);
            int width = arr2.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("Введите элемент массива по индексу: [" + i + "," + j + "]: ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив введенный с клавиатуры(nxm): ");
            PrintArr();
        }

        public void RandomArr()
        {

            int rank = arr2.GetLength(0);

            Random random = new Random();

            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    int rnd_num;
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

            PrintArr();
        }

        public void DiagonalArr()
        {
            int rank = arr2.GetLength(0);//размер массива
            int num = 1;

            // Заполняем диагоналями, начиная с нижнего ряда
            for (int startRow = rank - 1; startRow >= 0; startRow--)
            {
                int row = startRow;
                int col = 0;
                while (row < rank && col < rank)
                {
                    arr2[row, col] = num++;
                    row++;
                    col++;
                }
            }

            PrintArr();
        }

        
    }
}
