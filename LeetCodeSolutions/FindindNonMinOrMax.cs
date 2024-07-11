namespace LeetCodeSolutions;

public class FindindNonMinOrMax
{
    public int FindNonMinOrMax(int[] nums)
    {
        Array.Sort(nums);
        if (nums.Length <= 2)
            return -1;

        return nums[1];
    }
}

public class FindindNonMinOrMaxSolution
{
    static void MainFindindNonMinOrMax()
    {
        FindindNonMinOrMax findindNonMinOrMax = new FindindNonMinOrMax();
    }
}