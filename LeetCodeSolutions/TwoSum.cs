#region TwoSum
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] answer = new int[2];
//        int sub = target - nums[0]; // 6 - 3
//        int not_take_index = 0; // 0 not taking


//        // finding not needed index
//        for (int i = 0; i < nums.Length - 1; i++)
//        {
//            if (target - nums[i] == sub)
//            {
//                not_take_index = i;
//            }
//        }

//        for (int i = 0; i < nums.Length - 1; i++)
//        {
//            if (i == not_take_index)
//                continue;
//            else if (nums[i] + sub == target)
//            {
//                answer[0] = i;
//                answer[1] = not_take_index;
//            }
//        }
//        return answer;
//    }
//}

//public class Program
//{
//    static void Main()
//    {
//        Solution solution = new Solution();
//        Console.WriteLine(string.Join(" ,", solution.TwoSum([3, 2, 4], 6)));
//    }
//}
#endregion

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
        var distinct_numbers = nums.Distinct();
        if (distinct_numbers.Count() < 3)
            return distinct_numbers.Max(); 

        var answer = distinct_numbers.ToArray();
        Array.Sort(answer);
        var first_max = answer[^1];
        var second_max = answer[^2];
        Array.Reverse(answer);

        int[] newArray = answer.Where((val, index) => val != first_max || val != second_max).ToArray();
        Array.Sort(newArray);
        return newArray[^1];
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