// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s = "A man, a plan, a canal: Panama";
var output = solution.IsPalindrome(s);
Console.WriteLine(output); // true

var s1 = "race a car";
var output1 = solution.IsPalindrome(s1);
Console.WriteLine(output1); // false

var s2 = "0P";
var output2 = solution.IsPalindrome(s2);
Console.WriteLine(output2); // false

var s3 = "Marge, let's \"[went].\" I await {news} telegram.";
var output3 = solution.IsPalindrome(s3);
Console.WriteLine(output3); // true

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var text = new List<char>();
        s = s.ToLower();
        foreach (var c in s)
        {
            if ((c - 'a' >= 0 && c - 'a' < 26) || (c - '0' >= 0 && c - '0' < 10))
            {
                text.Add(c);
            }
        }

        for (int i = 0; i < text.Count / 2; i++)
        {
            if (text[i] != text[^(i + 1)])
            {
                return false;
            }
        }

        return true;
    }
}