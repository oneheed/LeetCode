// See https://aka.ms/new-console-template for more information

// Top Interview Questions : Array
var solution = new Solution();

int[] prices = [7, 1, 5, 7, 8, 4];
var output = solution.MaxProfit(prices);
Console.WriteLine(output); // 7

int[] prices1 = [1, 2, 3, 4, 5];
var output1 = solution.MaxProfit(prices1);
Console.WriteLine(output1); // 4

int[] prices2 = [7, 6, 4, 3, 1];
var output2 = solution.MaxProfit(prices2);
Console.WriteLine(output2); // 0

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var sum = 0;

        for (var i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i + 1] > prices[i])
            {
                sum += (prices[i + 1] - prices[i]);
            }
        }

        return sum;
    }
}