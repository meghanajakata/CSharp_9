namespace CSharp_11.FileLocalType;
file class User
{
    public string Name => "Test Name";
}
internal class UserProvider
{
    public string Name => new User().Name;
}
file interface ICalculator
{
    int Addition(int x, int y);
}

class Calculator : ICalculator
{
    public int Addition(int x, int y)
    {
        return x + y;
    }
}

