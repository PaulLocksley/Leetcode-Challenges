using System.Xml.Xsl;

namespace Leetcode.Palindrome_Number;

public class Solution
{
    //faster than 78.52% and less ram than 69.32%
    public bool IsPalindrome(int x)
    {
        var s = x.ToString();
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[^ (i+1)])
            {
                return false;
            }
        }
        return true;
    }
}