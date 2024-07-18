using System.Text.RegularExpressions;

namespace LeetCodeSolutions;

internal class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;
        string pattern = @"[a-zA-Z0-9]";
        MatchCollection matches = Regex.Matches(s, pattern);

        string result = "";
        foreach (Match match in matches)
        {
            result += match.Value;
        }
        var reversed = result.ToArray();
        Array.Reverse(reversed);
        var compare = string.Join("", reversed);

        if(result.ToLower() == compare.ToLower())
            return true;
        return false;
    }
}
