using System;

namespace Word_59A
{
    class Program
    {
        static void Main(string[] args)
        {
			string s = Console.ReadLine();
			int countup = 0;
			int countlow = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsUpper(s[i]))
				{
					countup++;
				}
				else
				{
					countlow++;
				}
			}
			if (countup > countlow)
			{
				char ch;
				for (int i = 0; i < s.Length; i++)
				{
					ch = char.ToUpper(s[i]);
					Console.Write(ch);
				}
			}
			else
			{
				char ch;
				for (int i = 0; i < s.Length; i++)
				{
					ch = char.ToLower(s[i]);
					Console.Write(ch);
				}
			}
		}
	}
}