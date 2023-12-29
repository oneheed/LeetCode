// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums = [3, 6, 1, 0];
var output = solution.DominantIndex(nums);
Console.WriteLine(output); // 1

int[] nums1 = [1, 2, 3, 4];
var output1 = solution.DominantIndex(nums1);
Console.WriteLine(output1); // -1

public class Solution
{
    public int DominantIndex(int[] nums)
    {
        var max = 0;
        var index = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                index = i;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != index && max < nums[i] * 2)
                return -1;
        }

        return index;
    }
}