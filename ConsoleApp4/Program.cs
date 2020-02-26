using System;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main (string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 6, 5, 7, 8, 11 };
            for (int i = 0; i <= Array.Length-1; i++)
            {
                int temp = Array[i];
                temp %= 2;
                if (temp == 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        } 
    }
}
