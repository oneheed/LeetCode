// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums = [1, 2, 3, 1];
var output = solution.ContainsDuplicate(nums);
Console.WriteLine(output); // true

int[] nums1 = [1, 2, 3, 4];
var output1 = solution.ContainsDuplicate(nums1);
Console.WriteLine(output1); // false

int[] nums2 = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
var output2 = solution.ContainsDuplicate(nums2);
Console.WriteLine(output2); // false

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var dic = new Dictionary<int, bool>();
        foreach (int num in nums)
        {
            if (dic.ContainsKey(num))
            {
                return true;
            }

            dic[num] = true;
        }

        return false;
    }
}