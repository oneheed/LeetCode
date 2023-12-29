// See https://aka.ms/new-console-template for more information
using System.Text;

var solution = new Solution();

string[] strs = ["flower", "flow", "flight"];
var output = solution.LongestCommonPrefix(strs);
Console.WriteLine(output); // "fl"


string[] strs1 = ["dog", "racecar", "car"];
var output1 = solution.LongestCommonPrefix(strs1);
Console.WriteLine(output1); // ""

string[] strs2 = ["ab", "a"];
var output2 = solution.LongestCommonPrefix(strs2);
Console.WriteLine(output2); // "a"


public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = new StringBuilder();

        for (int i = 0; i < strs[0].Length; i++)
        {
            result = result.Append(strs[0][i]);

            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j][i] != strs[0][i])
                    return result.ToString()[0..^1];
                else if (i == strs[j].Length - 1)
                    return result.ToString();
            }

        }

        return result.ToString();
    }
}