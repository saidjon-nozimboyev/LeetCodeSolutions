namespace LeetCodeSolutions;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] answer = new int[2];
        int sub = target - nums[0]; // 6 - 3
        int not_take_index = 0; // 0 not taking


        // finding not needed index
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (target - nums[i] == sub)
            {
                not_take_index = i;
            }
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i == not_take_index)
                continue;
            else if (nums[i] + sub == target)
            {
                answer[0] = i;
                answer[1] = not_take_index;
            }
        }
        return answer;
    }
    private class Program
    {
        static void MainTwoSum()
        {
            TwoSumSolution solution = new();
            Console.WriteLine(string.Join(" ,", solution.TwoSum([3, 2, 4], 6)));
        }
    }
}

