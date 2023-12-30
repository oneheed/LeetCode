// See https://aka.ms/new-console-template for more information
var solution = new Solution();

string[] words = ["abc", "aabc", "bc"];
var output = solution.MakeEqual(words);
Console.WriteLine(output); // true

string[] words1 = ["ab", "a"];
var output1 = solution.MakeEqual(words1);
Console.WriteLine(output1); // false

public class Solution
{
    public bool MakeEqual(string[] words)
    {
        int[] result = new int[26];

        foreach (string word in words)
        {
            foreach (int c in word)
            {
                result[c - 'a']++;
            }
        }

        return result.All(r => r % words.Length == 0);
    }
}