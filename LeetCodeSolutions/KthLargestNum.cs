namespace LeetCodeSolutions;

public class KthLargestNum
{
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);
        nums.ToHashSet();
        Array.Reverse(nums);
        k -= 1;
        return nums[k];
    }
}

public class KthLargestNumSolution
{
    public static void MainKthLargestNum()
    {
        KthLargestNum solution = new KthLargestNum();
        Console.WriteLine(solution.FindKthLargest([3, 2, 1, 5, 6, 4],2));
    }
}