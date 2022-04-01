using System;
using System.Collections.Generic;
using System.IO;

namespace WayTooLongWords_71A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    string b = Console.ReadLine();
                    int c = (b.Length);
                    int d = c - 2;

                    if (c >= 1 && c <= 10)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(b.ToString()[0] + "" + d + "" + b.ToString()[c - 1]);
                    }
                }
            }

        }
    }
}