using System;

namespace A.TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long m = int.Parse(input[0]);
            long n = int.Parse(input[1]);
            long a = int.Parse(input[2]);
            long x, y;

            if (m % a == 0)
                x = m / a;
            else
                x = m / a + 1;

            if (n % a == 0)
                y = n / a;
            else
                y = n / a + 1;

            Console.WriteLine(x * y);
        }
    }
}
