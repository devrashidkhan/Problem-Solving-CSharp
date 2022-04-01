using System;

namespace BeautifulMatrix_263A
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] num = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                string[] numbers = row.Split(' ');
                for (int j = 0; j < numbers.Length && j < size; j++)
                {
                    num[i, j] = int.Parse(numbers[j]);
                }
            }
        }
    }
}