// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[][] points = [[8, 7], [9, 9], [7, 4], [9, 7]];
var output = solution.MaxWidthOfVerticalArea(points);
Console.WriteLine(output); // 1

int[][] points1 = [[3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8, 8]];
var output1 = solution.MaxWidthOfVerticalArea(points1);
Console.WriteLine(output1); // 3


public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var x = points.Select(x => x[0]).ToArray();
        Array.Sort(x);

        var result = 0;

        for (int i = 1; i < x.Length; i++)
        {
            result = Math.Max(result, x[i] - x[i - 1]);
        }

        return result;
    }
}