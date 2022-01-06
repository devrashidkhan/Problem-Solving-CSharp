// See https://aka.ms/new-console-template for more information

VariableAssignment name = new VariableAssignment();
Console.WriteLine(name.nameConcat(Console.ReadLine()));

public class VariableAssignment
{
    public string nameConcat(string name)
    {
        return (name + "Edabit");
    }
}
