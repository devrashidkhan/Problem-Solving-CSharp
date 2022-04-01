using System;

namespace Helpful_Maths_339A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int l = (s.Length) / 2;
            l = l + 1;
            string[] values = s.Split('+');
            int[] ar = new int[l];

            for (int i = 0; i < l; i++)
            {
                int a = int.Parse(values[i]);
                ar[i] = a;
            }

            for (int j = 0; j < l; j++)
            {
                for (int h = 0; h < l; h++)
                {
                    if (ar[h] < ar[j])
                    {
                        int temp = ar[j];
                        ar[j] = ar[h];
                        ar[h] = temp;
                    }
                }
            }

            for (int d = l - 1; d >= 0; d--)
            {
                if (d != 0)
                {
                    Console.Write(ar[d]);
                }
                if (d != 0)
                {
                    Console.Write("+");
                }
                if (d == 0)
                {
                    Console.WriteLine(ar[d]);
                }
            }
        }
    }
}
