int x = 0;
for (int i = 1; i <= 5; ++i)
{
    for (int j = 1; j <= 5; ++j)
    {
        
        if (x == 1)
        {
            Console.WriteLine(x(i - 3) + x(j - 3));
        }
    }
}