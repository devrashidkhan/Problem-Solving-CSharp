
using System;

namespace Main_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int t = 0;
            int one = 0, zero = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    one++;
                    zero = 0;
                }
                else
                {
                    zero++;
                    one = 0;
                }
                if (one == 7 || zero == 7)
                {
                    t = 1;
                    break;
                }
            }
            if (t == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}