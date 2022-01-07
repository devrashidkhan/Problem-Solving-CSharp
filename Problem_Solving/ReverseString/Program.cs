Console.Write("Plase Your Name : ");
string name = Console.ReadLine();
Console.WriteLine(StringHelper.ReverseString(name));
static class StringHelper
{ 
    public static string ReverseString(string myStr)
    {
        char[] chars = myStr.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
