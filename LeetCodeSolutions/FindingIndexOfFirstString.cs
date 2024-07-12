namespace LeetCodeSolutions;

public class FindingIndexOfFirstString
{
    public int StrStr(string haystack, string needle)
    {
        int index = -1;
        index = haystack.IndexOf(needle);
        return index;
    }
}
