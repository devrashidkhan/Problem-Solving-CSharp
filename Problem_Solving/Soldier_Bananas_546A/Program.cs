using System;

namespace Main_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            long sum = 0;

            for (int i = 0; i <= w; i++)
            {
                sum = sum + (i * k);
            }
            
            if(sum <= n)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sum - n);
            }

        }
    }
}