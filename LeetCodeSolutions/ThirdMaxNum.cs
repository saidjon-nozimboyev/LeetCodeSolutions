namespace LeetCodeSolutions;

public class ThirdMaxNum
{
    public int ThirdMax(int[] nums)
    {
        var distinct_numbers = nums.ToHashSet();
        if (distinct_numbers.Count() < 3)
            return distinct_numbers.Max();

        var list = distinct_numbers.ToArray();
        Array.Sort(list);
        return list[^3];
    }
}

public class MainThirdMaxNumSolution
{
    public static void MainThirdMaxNum() 
    {
        ThirdMaxNum thirdMaxNum = new ThirdMaxNum();
        Console.WriteLine(thirdMaxNum.ThirdMax([1, 2, 2, 5, 3, 5]));
    }
}
