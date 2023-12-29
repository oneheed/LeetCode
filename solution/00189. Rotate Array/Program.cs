// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums = [1, 2, 3, 4, 5, 6, 7];
int k = 3;
solution.Rotate(nums, k);
Console.WriteLine(string.Join(',', nums)); // [5,6,7,1,2,3,4]

int[] nums1 = [-1, -100, 3, 99];
int k1 = 2;
solution.Rotate(nums1, k1);
Console.WriteLine(string.Join(',', nums1)); // [3,99,-1,-100]

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        var split1 = nums[(nums.Length - k)..^0];
        var split2 = nums[0..(nums.Length - k)];

        for (int i = 0; i < split1.Length; i++)
        {
            nums[i] = split1[i];
        }

        for (int i = 0; i < split2.Length; i++)
        {
            nums[k + i] = split2[i];
        }

        //k = k % nums.Length;
        //Array.Reverse(nums);
        //Array.Reverse(nums, 0, k);
        //Array.Reverse(nums, k, nums.Length - k);
    }
}