namespace LeetCodeSolutions;

public class RemoveDublicates
{
    public int RemoveDuplicates(int[] nums)
    {
        nums.ToHashSet();
        return nums.Length;
    }
}
