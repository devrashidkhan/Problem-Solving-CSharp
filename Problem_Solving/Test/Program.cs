using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            long m, n, a, x, y;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            if (m % a == 0)
            {
                x = m / a;
            }
            else
            {
                x = m / a + 1;
            }

            if (n % a == 0)
            {
                y = n / a;
            }

            else
            {
                y = n / a + 1;
            }
            Console.WriteLine(x * y);
        }
    }
}
