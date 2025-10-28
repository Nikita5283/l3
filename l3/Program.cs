using System;
namespace l3
{
    class Program
    {
        static void Main()
        {
            //1.9
            Console.WriteLine("1.9");
            Console.Write("Введите высоту массива(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину массива(m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] key_arr = new int[n, m];
            int[,] rnd_arr = new int[n, n];
            int[,] diag_arr = new int[n, n];

            Arr2 keyboard_arr = new Arr2(key_arr);
            //keyboard_arr.KeyboardArr();

            Arr2 random_arr = new Arr2(rnd_arr);
            //random_arr.RandomArr();

            Arr2 diagonal_arr = new Arr2(diag_arr);
            diagonal_arr.DiagonalArr();
        }
    }
}