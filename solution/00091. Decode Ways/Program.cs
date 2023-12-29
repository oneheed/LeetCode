// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var s = "12";
var output = solution.NumDecodings(s);
Console.WriteLine(output); // 2 (AB) (L)

var s1 = "226";
var output1 = solution.NumDecodings(s1);
Console.WriteLine(output1); // 3 (BZ) (VF) (BBF)

var s2 = "06";
var output2 = solution.NumDecodings(s2);
Console.WriteLine(output2); // 1 (F)

var s3 = "236";
var output3 = solution.NumDecodings(s3);
Console.WriteLine(output3); // 2 (BCF) (VF)

// TODO: Dynamic Programming
public class Solution
{
    public int NumDecodings(string s)
    {
        if (s == null || s.Length == 0 || s.StartsWith('0')) return 0;
        if (s.Length == 1) return 1;

        int[] dp = new int[s.Length + 1];

        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= s.Length; i++)
        {
            int l1 = int.Parse(s.Substring(i - 1, 1));
            int l2 = int.Parse(s.Substring(i - 2, 2));

            if (l1 >= 1 && l1 <= 9)
            {
                dp[i] += dp[i - 1];
            }

            if (l2 >= 10 && l2 <= 26)
            {
                dp[i] += dp[i - 2];
            }
        }

        return dp[s.Length];
    }
}