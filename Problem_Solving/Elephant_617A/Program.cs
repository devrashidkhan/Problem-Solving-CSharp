using System;

namespace Elephant_617A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int pass = a / 5;

            if(a % 5 > 0)
            {
                pass++;
            }
            Console.Write(pass);
        }
    }
}
