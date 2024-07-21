namespace LeetCodeSolutions;

internal class LargestGroup
{
    public int CountLargestGroup(int n)
    {
        int answer = 0;
        while (n != 0)
        {
            answer += n % 10;
            n = n / 10;
        }
        return answer;
    }
}
