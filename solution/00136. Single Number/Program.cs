// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums = [2, 2, 1];
var output = solution.SingleNumber(nums);
Console.WriteLine(output); // 1

int[] nums1 = [4, 1, 2, 1, 2];
var output1 = solution.SingleNumber(nums1);
Console.WriteLine(output1); // 4

int[] nums2 = [1];
var output2 = solution.SingleNumber(nums2);
Console.WriteLine(output2); // 1

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var dic = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (dic.ContainsKey(num))
            {
                dic[num]++;
            }
            else
            {
                dic[num] = 1;
            }
        }

        return dic.Single(v => v.Value == 1).Key;
    }
}

public class Solution1
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;

        foreach (int num in nums)
        {
            result ^= num;
        }

        return result;
    }
}