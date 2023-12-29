// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//int[] nums = [2, 7, 11, 15];
//int target = 9;
//var output = solution.TwoSum(nums, target);
//Console.WriteLine(string.Join(",", output)); // [0,1]


//int[] nums1 = [3, 2, 4];
//int target1 = 6;
//var output1 = solution.TwoSum(nums1, target1);
//Console.WriteLine(string.Join(",", output1)); // [1,2]

//int[] nums2 = [3, 3];
//int target2 = 6;
//var output2 = solution.TwoSum(nums2, target2);
//Console.WriteLine(string.Join(",", output2)); // [0,1]

int[] nums3 = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];
int target3 = 11;
var output3 = solution.TwoSum(nums3, target3);
Console.WriteLine(string.Join(",", output3)); // [0,1]


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (dic.TryGetValue(diff, out var index))
            {
                return new int[2] { index, i };
            }

            dic[nums[i]] = i;
        }

        return new int[2];
    }
}