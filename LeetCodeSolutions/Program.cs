namespace LeetCodeSolutions;

public class Program
{
    public static void Main()
    {
        FizBuz fizBuz = new FizBuz();
        Console.WriteLine(string.Join(", ",fizBuz.FizzBuzz(3)));
    }
}
