using System;
namespace l3
{
    class Program
    {
        static void Main()
        {
            ////1.9
            //Console.WriteLine("1.9");
            //Console.Write("Введите высоту массива(n): ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите ширину массива(m): ");
            //int m = Convert.ToInt32(Console.ReadLine());

            //int[,] key_arr = new int[n, m];
            //int[,] rnd_arr = new int[n, n];
            //int[,] diag_arr = new int[n, n];

            //Arr2 keyboard_arr = new Arr2(key_arr);
            //keyboard_arr.KeyboardArr();

            //Arr2 random_arr = new Arr2(rnd_arr);
            //random_arr.RandomArr();

            //Arr2 diagonal_arr = new Arr2(diag_arr);
            //diagonal_arr.DiagonalArr();

            ////2.9
            //Console.WriteLine("2.9");
            //Console.Write("Введите высоту массива для подсчета максимальной суммы эл-тов столбцов: ");
            //int h = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите ширину массива для подсчета максимальной суммы эл-тов столбцов: ");
            //int w = Convert.ToInt32(Console.ReadLine());
            //int[,] sum_arr = new int[h, w];

            //Arr2 sums_arr = new Arr2(sum_arr);
            //sums_arr.KeyboardArr();
            //sums_arr.SumCols();

            //3.9
            Console.WriteLine("3.9");
            Console.WriteLine("Дано выражение: (А+4*В)-Ст, где A, B, C - матрицы");
            Console.Write("Введите высоту матрицы A: ");
            int ah = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину матрицы A: ");
            int aw = Convert.ToInt32(Console.ReadLine());
            int[,] Amatr = new int[ah, aw];

            Console.Write("Введите высоту матрицы B: ");
            int bh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину матрицы B: ");
            int bw = Convert.ToInt32(Console.ReadLine());
            int[,] Bmatr = new int[bh, bw];

            Console.Write("Введите высоту матрицы C: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину матрицы C: ");
            int cw = Convert.ToInt32(Console.ReadLine());
            int[,] Cmatr = new int[ch, cw];

            Arr2 A = new Arr2(Amatr);
            Arr2 B = new Arr2(Bmatr);
            Arr2 C = new Arr2(Cmatr);
            A.KeyboardArr();
            C.Matrix(A, B, C);
        }
    }
}