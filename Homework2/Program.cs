using Homework2;

public class Program
{
    public static void Main(string[] args)
    {
        Computer computer = new();
        try
        {
            Console.WriteLine("Computer components information:");
            computer.GetComponentInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
        }
    }
}