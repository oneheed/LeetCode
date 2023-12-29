// See https://aka.ms/new-console-template for more information
var solution = new Solution();

int[] prices = [1, 2, 2];
int money = 3;
var output = solution.BuyChoco(prices, money);
Console.WriteLine(output); // 0

public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        Array.Sort(prices);

        var result = money - prices[0] - prices[1];
        return result < 0 ? money : result;
    }
}