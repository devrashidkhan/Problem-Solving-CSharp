using System;

namespace Bear_Big_Brother_791A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a =int.Parse(input[0]);
            int b =int.Parse(input[1]);

            int c = 0;

            if(a > b)
            {
                c = 0;
            }
            else
            {
                while(a <= b)
                {
                    a = a * 3;
                    b = b * 2;
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}