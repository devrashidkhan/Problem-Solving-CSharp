using System;

namespace Bit_282A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int x = 0;
            

            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                if(s[1] == '+')
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            Console.WriteLine(x);
        }
    }
}
