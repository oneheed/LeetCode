// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var s = "011101";
var output = solution.MaxScore(s);
Console.WriteLine(output); // 5

var s1 = "00111";
var output1 = solution.MaxScore(s1);
Console.WriteLine(output1); // 5

var s2 = "1111";
var output2 = solution.MaxScore(s2);
Console.WriteLine(output2); // 3

var s3 = "00";
var output3 = solution.MaxScore(s3);
Console.WriteLine(output3); // 1

public class Solution
{
    public int MaxScore(string s)
    {
        var zeroCount = s[0] == '0' ? 1 : 0;
        var oneCount = 0;
        var result = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == '1')
                oneCount++;
        }

        result = zeroCount + oneCount;

        for (int i = 1; i < s.Length - 1; i++)
        {
            if (s[i] == '1')
                oneCount--;

            if (s[i] == '0')
                zeroCount++;

            result = Math.Max(result, zeroCount + oneCount);
        }

        return result;
    }
}

public class Solution1
{
    public int MaxScore(string s)
    {
        int zeroCount = 0, oneCount = 0, max = int.MinValue;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
                zeroCount++;
            else if (s[i] == '1')
                oneCount++;

            if (i != s.Length - 1)
                max = Math.Max(max, zeroCount - oneCount);
        }

        return max + oneCount;
    }
}