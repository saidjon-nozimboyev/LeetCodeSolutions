namespace LeetCodeSolutions;

public class DetectCapitalUse
{
    public bool DetectCapitalUsee(string word)
    {
        string getAfterFirstLetter = word.Substring(1);
        if (word == word.ToLower())
            return true;
        if (word[0].ToString().ToUpper() == word[0].ToString() && word.Substring(1).ToLower() == getAfterFirstLetter)
            return true;
        return word == word.ToUpper();
    }
}
