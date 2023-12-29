// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] nums1 = [1, 2, 2, 1], nums2 = [2, 2];
var output = solution.Intersect(nums1, nums2);
Console.WriteLine(string.Join(",", output)); // 2, 2

int[] nums11 = [4, 9, 5], nums12 = [9, 4, 9, 8, 4];
var output1 = solution.Intersect(nums11, nums12);
Console.WriteLine(string.Join(",", output1)); // 2, 2

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var dic = new Dictionary<int, int>();
        foreach (int i in nums1)
        {
            if (dic.ContainsKey(i))
            {
                dic[i]++;
            }
            else
            {
                dic[i] = 1;
            }
        }

        var result = new List<int>();
        foreach (int i in nums2)
        {
            if (dic.TryGetValue(i, out var count) && count > 0)
            {
                result.Add(i);
                dic[i]--;
            }
        }

        return result.ToArray();
    }
}
