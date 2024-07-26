using System.Numerics;

namespace LeetCodeSolutions;

public class Program
{
    public static void Main()
    {
        ConvertTemperature convertTemperature = new ConvertTemperature();
        Console.WriteLine(string.Join(", ", convertTemperature.ConvertTemperaturee(36.50)));
    }
}
