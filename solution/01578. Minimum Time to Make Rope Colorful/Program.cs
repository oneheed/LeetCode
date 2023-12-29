// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var colors = "abaac";
int[] neededTime = [1, 2, 3, 4, 5];
var output = solution.MinCost(colors, neededTime);
Console.WriteLine(output); // 3

var colors1 = "abc";
int[] neededTime1 = [1, 2, 3];
var output1 = solution.MinCost(colors1, neededTime1);
Console.WriteLine(output1); // 0

var colors2 = "aabaa";
int[] neededTime2 = [1, 2, 3, 4, 1];
var output2 = solution.MinCost(colors2, neededTime2);
Console.WriteLine(output2); // 2

var colors3 = "aaaaa";
int[] neededTime3 = [1, 2, 3, 4, 5];
var output3 = solution.MinCost(colors3, neededTime3);
Console.WriteLine(output3); // 10

var colors4 = "aaabbbabbbb";
int[] neededTime4 = [3, 5, 10, 7, 5, 3, 5, 5, 4, 8, 1];
var output4 = solution.MinCost(colors4, neededTime4);
Console.WriteLine(output4); // 26 
// 3 5 5 3 4 5
public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        var left = 0;
        var right = 1;
        var sum = 0;

        while (right < colors.Length)
        {
            if (colors[left] == colors[right])
            {
                //Console.WriteLine($"{neededTime[left]} {neededTime[right]} {sum}");
                if (neededTime[right] > neededTime[left])
                {
                    sum += neededTime[left];
                    left = right;
                    right = left + 1;
                }
                else
                {
                    sum += neededTime[right];
                    right = right + 1;
                }
            }
            else
            {
                left = right;
                right = left + 1;
            }
        }

        return sum;
    }
}