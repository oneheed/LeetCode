// See https://aka.ms/new-console-template for more information
// 1001 => 1010, 0101  2
// 1000 => 1010 1
// 1100 => 1010 2

var solution = new Solution();

var s = "0100";
var output = solution.MinOperations(s);
Console.WriteLine(output); // 1

var s1 = "10";
var output1 = solution.MinOperations(s1);
Console.WriteLine(output1); // 0

var s2 = "1111";
var output2 = solution.MinOperations(s2);
Console.WriteLine(output2); // 2

// 10010100
// 10101010 => 5
// 01010101 => 3
var s3 = "10010100";
var output3 = solution.MinOperations(s3);
Console.WriteLine(output3); // 3

// 101101111
// 101010101
var s4 = "101101111";
var output4 = solution.MinOperations(s4);
Console.WriteLine(output4); // 4

public class Solution
{
    public int MinOperations(string s)
    {
        var count1 = 0; // even 1
        var count2 = 0; // odd 1

        for (var i = 0; i < s.Length; i++)
        {
            if ((i % 2 == 1 && s[i] == '0') || (i % 2 == 0 && s[i] == '1'))
            {
                count1++;
            }

            if ((i % 2 == 1 && s[i] == '1') || (i % 2 == 0 && s[i] == '0'))
            {
                count2++;
            }
        }

        return Math.Min(count1, count2);
    }
}