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

        // Конструктор для 2.9
        public Arr2(int[,] arr2)
        {
            this.arr2 = arr2;
        }

        //1.9

        // Ввод массива с клавиатуры
        public Arr2(ushort[,] arr2)
        {
            int height = arr2.GetLength(0);
            int width = arr2.GetLength(1);
            this.arr2 = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("Введите элемент массива по индексу: [" + i + "," + j + "]: ");
                    int el = Convert.ToInt32(Console.ReadLine());
                    arr2[i, j] = Convert.ToUInt16(el);
                    this.arr2[i, j] = el;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив введенный с клавиатуры(nxm): ");
            PrintArr(arr2);
        }

        // Заполнение в шахматном порядке(черные-четные, белые-нечетные)
        public Arr2(byte[,] arr)
        {
            int rank = arr.GetLength(0);
            this.arr2 = new int[rank, rank];

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

                    arr[i, j] = (byte)rnd_num;
                    this.arr2[i, j] = rnd_num;
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив рандомных чисел(nxn): ");

            PrintArr(arr2);
        }

        // Заполнение массива по диагоналям
        public Arr2(short[,] arr2)
        {
            int rank = arr2.GetLength(0);//размер массива
            this.arr2 = new int[rank, rank];
            int num = 1;

            // Заполняем диагоналями, начиная с нижнего ряда
            for (int startRow = rank - 1; startRow >= 0; startRow--)
            {
                int row = startRow;
                int col = 0;
                while (row < rank && col < rank)
                {
                    arr2[row, col] = (short)num;
                    this.arr2[row, col] = num;
                    num++;
                    row++;
                    col++;
                }
            }
            Console.WriteLine("Диагонально заполненный массив(nxn): ");
            PrintArr(arr2);
        }

        //метод для вывода массива
        public void PrintArr(Array arr)
        {
            int height = arr.GetLength(0);
            int width = arr.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{arr.GetValue(i, j),4}");
                }
                Console.WriteLine();
            }
        }

        //2.9
        public void SumCols()
        {
            int rank = arr2.GetLength(0);
            int[] sums = new int [rank];
            
            int col = 0;
            for (int Endrow = rank - 1; Endrow >= 0; Endrow--)
            {
                int row = 0;

                while (row < Endrow) 
                {
                    sums[col] += arr2[row, col];
                    row++;
                }
                col++;
                
            }

            for (int i = 0; i < rank; i++)
            {
                Console.WriteLine("сумма эл-тов в столбце " + i + ": " + sums[i]);
            }

            Console.WriteLine("Максимальная сумма: " + sums.Max());
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
            PrintArr(arr2);
        }

        //3.9
        public void Transposition(int[,] matr)
        {
            int heightM = matr.GetLength(0);
            int widthM = matr.GetLength(1);
            int[,] Ctr = new int[heightM, widthM];
            for (int i = 0; i < heightM; i++)
            {
                for (int j = 0; j < widthM; j++)
                {
                    Ctr[i, j] = matr[j, i];
                }
            }

            PrintArr(Ctr);

        }

        
    }
}
