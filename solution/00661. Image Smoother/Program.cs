// See https://aka.ms/new-console-template for more information
using LeetCode.Extension;

var solution = new Solution();

int[][] img = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
var output = solution.ImageSmoother(img);
Console.WriteLine(output.ArrayToString()); // true

int[][] img1 = [[100, 200, 100], [200, 50, 200], [100, 200, 100]];
var output1 = solution.ImageSmoother(img1);
Console.WriteLine(output1.ArrayToString()); // true

public class Solution
{
    public int[][] ImageSmoother(int[][] img)
    {
        var result = new int[img.Length][];
        var row = img.Length;
        var low = img[0].Length;

        for (var x = 0; x < row; x++)
        {
            result[x] = new int[low];
            for (var y = 0; y < low; y++)
            {
                //Console.WriteLine(Math.Max(0, x - 1) + ", " + Math.Min(row, x + 2));
                //Console.WriteLine(Math.Max(0, y - 1) + ", " + Math.Min(low, y + 2));

                var count = 0;
                var sum = 0;
                for (var i = Math.Max(0, x - 1); i < Math.Min(row, x + 2); i++)
                {
                    for (var j = Math.Max(0, y - 1); j < Math.Min(low, y + 2); j++)
                    {
                        count++;
                        sum += img[i][j];
                    }
                }


                result[x][y] = sum / count;
            }
        }

        return result;
    }
}