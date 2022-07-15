abstract class AbstractClass
{
    public abstract int sum();
}
class Sum : AbstractClass
{
    private int x;
    private int y;
    public Sum(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override int sum()
    {
        Console.Write("Sum is: ");
        return (x + y);

    }
}
class Test
{
    static void Main(string[] args)
    {
        AbstractClass op = new Sum(4, 5);
        double result = op.sum();
        Console.Write("{0}", result);
    }
}
