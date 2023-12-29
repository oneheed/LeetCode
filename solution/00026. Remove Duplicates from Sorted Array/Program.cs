// See https://aka.ms/new-console-template for more information

// Top Interview Questions : Array
var solution = new Solution();

int[] nums = [1, 1, 2];
var output = solution.RemoveDuplicates(nums);
Console.WriteLine(output); // true

int[] nums1 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
var output1 = solution.RemoveDuplicates(nums1);
Console.WriteLine(output1); // true

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var result = 1;
        var temp = nums[0];
        foreach (var num in nums)
        {
            if (temp != num)
            {
                temp = num;
                result++;
                nums[result - 1] = num;
            }
        }

        return result;
    }
}

public class Solution1
{
    public int RemoveDuplicates(int[] nums)
    {
        var pos = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[pos - 1] != nums[i])
            {
                nums[pos] = nums[i];
                pos++;
            }
        }

        return pos;
    }
}