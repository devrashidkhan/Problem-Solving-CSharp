using System;

namespace Petya_Strings_112A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            string lowerStr = s.ToLower();
            string lowerStr1 = s1.ToLower();

            if (lowerStr == lowerStr1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < lowerStr.Length; i++)
                {
                    if (lowerStr[i] < lowerStr1[i])
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                    else if (lowerStr[i] > lowerStr1[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                }
            }
        }
    }
}
