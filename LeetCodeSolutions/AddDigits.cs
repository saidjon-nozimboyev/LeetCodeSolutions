namespace LeetCodeSolutions
{
    internal class AddDigits
    {
        public int AddDigit(int num)
        {
            if (num == 0)
                return 0;
            return (num - 1) % 9 + 1;
        }
    }
}
