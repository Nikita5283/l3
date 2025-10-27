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

            int[,] arr2Dnm = new int[n, m];
            int[,] arr2Dnn = new int[n, n];

            Arr2 keyboard_arr = new Arr2(arr2Dnm);
            keyboard_arr.KeyboardArr();

            Arr2 random_arr = new Arr2(arr2Dnn);
            random_arr.RandomArr();
        }
    }
}