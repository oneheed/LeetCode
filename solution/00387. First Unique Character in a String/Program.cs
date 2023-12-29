// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s = "leetcode";
var output = solution.FirstUniqChar(s);
Console.WriteLine(output); // 0

var s1 = "loveleetcode";
var output1 = solution.FirstUniqChar(s1);
Console.WriteLine(output1); // 2

var s2 = "aabb";
var output2 = solution.FirstUniqChar(s2);
Console.WriteLine(output2); // -1

var s3 = "aadadaad";
var output3 = solution.FirstUniqChar(s3);
Console.WriteLine(output3); // -1

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var chars = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            if (chars[s[i] - 'a'] != 0)
            {
                chars[s[i] - 'a'] = -1;
            }
            else
            {
                chars[s[i] - 'a'] = i + 1;
            }
        }

        var result = chars.Where(c => c > 0);
        return result.Any() ? result.Min() - 1 : -1;
    }
}

public class Solution1
{
    public int FirstUniqChar(string s)
    {
        var chars = new int[26];

        foreach (var c in s)
        {
            chars[c - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (chars[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}