namespace LeetCodeSolutions;

public class Program
{
    public static void Main()
    {
        KthLargestNum kthLargestNum = new KthLargestNum();
        Console.WriteLine(kthLargestNum.FindKthLargest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4));
    }
}
