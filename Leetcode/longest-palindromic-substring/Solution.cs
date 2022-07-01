namespace Leetcode.longest_palindromic_substring;

public class Solution
{
    
    /*Runtime: 412 ms, faster than 28.41% of C# online submissions for Longest Palindromic Substring.
        Memory Usage: 37.5 MB, less than 61.90% of C# online submissions for Longest Palindromic Substring.*/
    //Issues, did not think through the problem of going over all the chars at least twice. using a middle out analysis would have let me only go over everything once ish.
    public static string LongestPalindrome(string s) {
        
        var charMap = new Dictionary<char, List<int>>();
        var longestPalindrome = s[0].ToString();
        for(var i = 0; i < s.Length; i++)
        {
            if (charMap.ContainsKey(s[i]))
            {
                charMap[s[i]].Add(i);
            }
            else
            {
                var tmpList = new List<int>();
                tmpList.Add(i);
                charMap.Add(s[i], tmpList);
            }
        }

        foreach (var c in charMap)
        {
            if (c.Value.Count == 1)
            {
                continue;
            }

            for (int i = 0; i < c.Value.Count -1; i++)
            {
                for (int j = i+1; j < c.Value.Count; j++)
                {
                    if (c.Value[j] - c.Value[i]+1 < longestPalindrome.Length)
                    {
                        continue;
                    }
                    var substring = s.Substring(c.Value[i], (c.Value[j]) - c.Value[i]+1);
                    if (isPalindrome(substring))
                    {
                        longestPalindrome =  substring;
                        //longestPalindrome.Length > substring.Length ? longestPalindrome :
                    }
                }
            }
        }
        
        
        return longestPalindrome;    
        }

    public static bool isPalindrome(string s)
    {
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