namespace LeetCodeSolutions;

internal class FizBuz
{
    public IList<string> FizzBuzz(int n)
    {
        string[] list = new string[n];
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
            {
                list[i] = "FizzBuzz";
                continue;
            }
            if ((i + 1) % 3 == 0)
            {
                list[i] = "Fizz";
                continue;
            }
            if ((i + 1) % 5 == 0)
            {
                list[i] = "Buzz";
                continue;
            }
            else
                list[i] = $"{i + 1}";
        }
        return list;
    }
}
