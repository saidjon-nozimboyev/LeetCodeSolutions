namespace LeetCodeSolutions
{
    internal class NumberOfDistinct
    {
        public int DistinctAverages(int[] nums)
        {
            if (nums.Length == 2)
                return 1;

            var list = nums.ToArray();
            Array.Sort(list);
            double[] averages = new double[list.Length / 2];

            int i = 0;
            int j = list.Length - 1;
            int length = list.Length;

            while (length != 0)
            {
                averages[i] = (((list[i] + list[j]) / 2));
                Console.WriteLine(((list[i] + list[j]) / 2));
                i++;
                j--;
                length -= 2;
            }
            averages.ToHashSet();
            return averages.Length;
        }
    }
}
