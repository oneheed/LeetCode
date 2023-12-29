// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] s = [1, 7, 3, 6, 5, 6];
var output = solution.PivotIndex(s);
Console.WriteLine(output); // 3

int[] s1 = [1, 2, 3];
var output1 = solution.PivotIndex(s1);
Console.WriteLine(output1); // -1


int[] s2 = [2, 1, -1];
var output2 = solution.PivotIndex(s2);
Console.WriteLine(output2); // 0

int[] s3 = [-1, -1, -1, -1, -1, -1];
var output3 = solution.PivotIndex(s3);
Console.WriteLine(output3); // -1

int[] s4 = [-1, -1, 0, 1, 1, 0];
var output4 = solution.PivotIndex(s4);
Console.WriteLine(output4); // 5


public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var left = 0;
        var right = nums.Sum() - nums[0];

        if (left == right)
        {
            return 0;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            left += nums[i - 1];
            right -= nums[i];

            if (left == right)
            {
                return i;
            }
        }

        return -1;
    }
}