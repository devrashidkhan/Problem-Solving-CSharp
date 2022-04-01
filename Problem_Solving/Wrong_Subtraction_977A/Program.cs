using System;

namespace Wrong_Subtraction_977A
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = Console.ReadLine().Split(' ');

			string tempVar =(input[0]);
			string tempVar2 = (input[1]);

			int a = 0;
			int n = 0;
			if (tempVar != null)
			{
				n = int.Parse(tempVar);
			}
			if (tempVar2 != null)
			{
				a = int.Parse(tempVar2);
			}
			for (int i = 1; i <= a; i++)
			{
				int r = n % 10;
				if (r == 0)
				{
					n /= 10;
				}
				else
				{
					n -= 1;
				}
			}
			Console.Write(n);
		}
	}
}