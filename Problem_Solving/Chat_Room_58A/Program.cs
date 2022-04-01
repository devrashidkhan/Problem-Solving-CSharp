using System;

namespace Chat_Room_58A
{
    class Program
    {
        static void Main(string[] args)
        {
			string a = Console.ReadLine();
			string b = "hello";
			int j = 0;
			int pas = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == b[j])
				{
					j++;
					pas++;

					if (pas == 5)
					{
						break;
					}
				}
			}
			if (pas == 5)
			{
				Console.Write("YES");
			}
			else
			{
				Console.Write("NO");
			}
		}
    }
}
