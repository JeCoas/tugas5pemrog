using _22._11._4856;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 90, 72, 41, 21, 93, 35 };

            MinMax mm = new MinMax();

            int max, min;
            mm.GetMinMax(arr, out max, out min);

            Console.WriteLine("Bilangan terbesar: " + max);
            Console.WriteLine("Bilangan terkecil: " + min);
        }
    }
}

