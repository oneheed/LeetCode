// See https://aka.ms/new-console-template for more information
var solution = new Solution();

string[] bank = ["011001", "000000", "010100", "001000"];
var output = solution.NumberOfBeams(bank);
Console.WriteLine(output); // 8

string[] bank1 = ["000", "111", "000"];
var output1 = solution.NumberOfBeams(bank1);
Console.WriteLine(output1); // 8


public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        var result = 0;
        var left = 0;

        foreach (var item in bank.Select(b => b.Count(c => c == '1')).Where(c => c != 0))
        {
            result += left * item;
            left = item;
        }

        return result;
    }
}
