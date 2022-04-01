using System;

namespace StringTask_118A
{
    class Program
    {
        static void Main(string[] args)
        {
            string lower = Console.ReadLine();

            int l = lower.Length;

            string s = lower.ToLower();

            int count = 0;

            for (int j = 0; j < l; j++)
            {
                if (s[j] != 'a' && s[j] != 'e' && s[j] != 'i' && s[j] != 'o' && s[j] != 'u' && s[j] != 'y')
                {
                    count++;
                }
            }

            Console.Write(".");

            int pount = 0;

            for (int i = 0; i < l; i++)
            {
                if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u' && s[i] != 'y' && pount != count - 1)
                {
                    Console.Write(s[i] + ".");
                    pount++;
                }
                else if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u' && s[i] != 'y' && pount == count - 1)
                {
                    Console.WriteLine(s[i]);
                }
            }

        }
    }
}
