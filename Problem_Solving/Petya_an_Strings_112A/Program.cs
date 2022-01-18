string s = Console.ReadLine();

string str = Console.ReadLine();

string lower = s.ToLower();

string lower1 = str.ToLower();

int i;

if (lower == lower1)
{
    Console.WriteLine("0");
}
else
{
    for (i = 0; i < lower.Length; i++)
    {
        if (lower[i] < lower1[i])
        {
            Console.WriteLine("-1");
            break;
        }
        if (lower[i] > lower1[i])
        {
            Console.WriteLine("1");
            break;
        }
    }
}