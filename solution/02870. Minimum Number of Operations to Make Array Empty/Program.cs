// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums = [2, 3, 3, 2, 2, 4, 2, 3, 4];
var output = solution.MinOperations(nums);
Console.WriteLine(output); // 4

int[] nums1 = [2, 1, 2, 2, 3, 3];
var output1 = solution.MinOperations(nums1);
Console.WriteLine(output1); // -1

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var result = 0;
        var intCount = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (intCount.ContainsKey(i))
            {
                intCount[i]++;
            }
            else
            {
                intCount[i] = 1;
            }
        }

        foreach (int i in intCount.Select(i => i.Value))
        {
            if (i == 1)
                return -1;

            var d = i / 3;
            var rem = i % 3 == 0 ? 0 : 1;
            result += (d + rem);
        }

        return result;
    }
}