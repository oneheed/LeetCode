// See https://aka.ms/new-console-template for more information
using LeetCode.Extension;

var solution = new Solution();

char[] s = ['h', 'e', 'l', 'l', 'o'];
solution.ReverseString(s);
Console.WriteLine(s.ArrayToString()); // ['o','l','l','e','h']

char[] s1 = ['H', 'a', 'n', 'n', 'a', 'h'];
solution.ReverseString(s1);
Console.WriteLine(s1.ArrayToString()); // ["h","a","n","n","a","H"]

public class Solution
{
    public void ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            var temp = s[i];
            s[i] = s[^(i + 1)];
            s[^(i + 1)] = temp;
        }
    }
}