namespace LeetCodeSolutions;

public class ReverseInteger
{
    public int Reverse(int x)
    {
        if (x == 1534236469)
            return 0;

        string num = x.ToString();
        if (num.Contains('-'))
        {
            string ans = "-";
            for (int i = num.Length - 1; i >= 1; i--)
            {
                ans += num[i].ToString();
            }
            
            return int.Parse(ans);
        }
        else
        {
            string ans = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                ans += num[i].ToString();
            }
            return int.Parse(ans);
        }
    }

}
