// See https://aka.ms/new-console-template for more information
var solution = new Solution();

string haystack = "sadbutsad", needle = "sad";
var output = solution.StrStr(haystack, needle);
Console.WriteLine(output); // 0

string haystack1 = "leetcode", needle1 = "leeto";
var output1 = solution.StrStr(haystack1, needle1);
Console.WriteLine(output1); // -1

string haystack2 = "mississippi", needle2 = "issip";
var output2 = solution.StrStr(haystack2, needle2);
Console.WriteLine(output2); // 4

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        var left = 0;
        var right = 0;
        while (left < haystack.Length)
        {
            if (haystack[left] == needle[right])
            {
                right++;

                if (right == needle.Length)
                    return left - (needle.Length - 1);
            }
            else
            {
                left = left - right;
                right = 0;
            }

            left++;
        }

        return -1;
    }
}

public class Solution1
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}