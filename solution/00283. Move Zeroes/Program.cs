// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums = [0, 1, 0, 3, 12];
solution.MoveZeroes(nums);
Console.WriteLine(string.Join(",", nums)); // [1,3,12,0,0]


public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[i];
                nums[i] = 0;
                nums[index] = temp;
                index++;
            }
        }
    }
}