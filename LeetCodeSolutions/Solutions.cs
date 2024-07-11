#region FindNonMinOrMax
//public class Solution
//{
//    public int FindNonMinOrMax(int[] nums)
//    {
//        Array.Sort(nums);
//        if (nums.Length <= 2)
//            return -1;

//        return nums[1];
//    }
//}

//public class Program
//{
//    static void Main()
//    {
//        Solution solution = new Solution();
//        Console.WriteLine(solution.FindNonMinOrMax([1,2]));
//    }
//}
#endregion

#region ThirdMaxNum
public class Solution
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

public class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.ThirdMax([1, 2, 2, 5, 3, 5])); // 1 2 3 4 5
    }
}
#endregion