namespace LeetCodeSolutions
{
    internal class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int prev = 1;
            int cur = 1;
            int temp;
            for (int i = 1; i < n; i++)
            {
                temp = cur;
                cur += prev;
                prev = temp;
            }
            return cur;
        }
       
    }
}
