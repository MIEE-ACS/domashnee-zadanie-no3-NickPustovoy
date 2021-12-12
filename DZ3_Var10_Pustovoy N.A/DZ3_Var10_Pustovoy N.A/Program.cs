using System;

namespace DZ3_Var10_Pustovoy_N.A_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = "Привет, Мир!".Split(' ');
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = a[j].Length - 1; i >= 0; i--)
                {
                    Console.Write(a[j][i]);
                }
                Console.Write(' ');
            }
        }
    }
}
