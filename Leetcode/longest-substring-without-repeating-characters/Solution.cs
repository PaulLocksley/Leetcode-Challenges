using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Leetcode.longest_substring_without_repeating_characters;

/*
var x = Leetcode.longest_substring_without_repeating_characters.Solution.LengthOfLongestSubstring2("pwwkew");
Console.WriteLine(" 3 :" + x  + " " + (x==3));
x = Leetcode.longest_substring_without_repeating_characters.Solution.LengthOfLongestSubstring2("abcabcbb");
Console.WriteLine(" 3 : " + x  + " " + (x==3));

x = Leetcode.longest_substring_without_repeating_characters.Solution.LengthOfLongestSubstring2(" ");
Console.WriteLine(" 1 : " + x  + " " + (x==1));
x = Leetcode.longest_substring_without_repeating_characters.Solution.LengthOfLongestSubstring2("aab");
Console.WriteLine("2 : " +x + " " + (x==2));
x = Leetcode.longest_substring_without_repeating_characters.Solution.LengthOfLongestSubstring2("abcb");
Console.WriteLine("3 : " + x  + " " + (x==3));
*/

public class Solution
{ //20% 5%ram
    public static int LengthOfLongestSubstring(string s)
    {
        if(s.ToHashSet().Count == s.Length)
        {
            return s.Length;
        }
        var longest = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var charCache = new HashSet<char>();
            charCache.Add(s[i]);
            for (var j = i + 1; j < s.Length; j++)
            {
                if (charCache.Contains(s[j]))
                {
                    longest = longest > j - i  ? longest : j - i ;
                    break;
                }
                else
                {
                    charCache.Add(s[j]);
                }
                
                if (j == s.Length - 1)
                {
                    longest = longest > j - i + 1  ? longest : j - i + 1 ;
                    return longest;
                }
            }

        }

        return longest;
    }

    public static int LengthOfLongestSubstring2(string s)
    {//30.8%
        if (s.ToHashSet().Count == s.Length)
        {
            return s.Length;
        }
        
        var longest = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var hashCache = new HashSet<char>();
            hashCache.Add(s[i]);
            for (var j = i + 1; j < s.Length; j++)
            {
                var tmpLength = hashCache.Count;
                hashCache.Add(s[j]);
                if (hashCache.Count == tmpLength)
                {
                    longest = longest > hashCache.Count ? longest : hashCache.Count;
                    break;
                }else if (j == s.Length - 1)
                {
                    return longest > hashCache.Count ? longest : hashCache.Count;
                }
            }
        }

        return longest;
    }
}

