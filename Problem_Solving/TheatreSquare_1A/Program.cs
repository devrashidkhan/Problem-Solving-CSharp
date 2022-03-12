long m, n, a, x, y;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
a = int.Parse(Console.ReadLine());

if (m % a == 0)
    x = m / a;
else
    x = m / a + 1;

if(n% a == 0)
    y = n / a;
else
    y = n / a + 1;

Console.WriteLine(x*y);