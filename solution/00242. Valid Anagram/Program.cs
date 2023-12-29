// See https://aka.ms/new-console-template for more information
var solution = new Solution();

string s = "anagram", t = "nagaram";
var output = solution.IsAnagram(s, t);
Console.WriteLine(output); // true

string s1 = "rat", t1 = "car";
var output1 = solution.IsAnagram(s1, t1);
Console.WriteLine(output1); // false

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dic = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
                dic[s[i]]++;
            else
                dic.Add(s[i], 1);

            if (dic.ContainsKey(t[i]))
                dic[t[i]]--;
            else
                dic.Add(t[i], -1);
        }

        return dic.All(v => v.Value == 0);
    }
}

public class Solution1
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var result = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            result[s[i] - 'a']++;
            result[t[i] - 'a']--;
        }

        return result.All(v => v == 0);
    }
}