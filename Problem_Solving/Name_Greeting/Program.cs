// See https://aka.ms/new-console-template for more information

NameGreeting name = new NameGreeting();
Console.WriteLine(name.HelloName());

public class NameGreeting
{
    public string name;

    public string HelloName()
    {
        Console.Write("Type a name : ");
        name = Console.ReadLine();
        return "Hello " + name + '!';
    }
}
