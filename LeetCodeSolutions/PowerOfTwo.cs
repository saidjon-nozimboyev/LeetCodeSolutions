namespace LeetCodeSolutions;

internal class PowerOfTwo
{
    public bool IsPowerOfTwo(int n)
    {
        var ans = Math.Log2 (n);
        int check = (int)ans;
        if (ans == check)
            return true;
        return false;
    }
}
