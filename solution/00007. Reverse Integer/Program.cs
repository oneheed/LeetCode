// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//int x = 123;
//var output = solution.Reverse(x);
//Console.WriteLine(output); // 321

//int x1 = -123;
//var output1 = solution.Reverse(x1);
//Console.WriteLine(output1); // -321

//int x2 = 120;
//var output2 = solution.Reverse(x2);
//Console.WriteLine(output2); // 21

int x3 = 1534236469;
var output3 = solution.Reverse(x3);
Console.WriteLine(output3); // 0


public class Solution
{
    public int Reverse(int x)
    {
        var result = 0;

        while (x != 0)
        {
            var i = x % 10;
            x = x / 10;

            if (result > int.MaxValue / 10) return 0;
            if (result < int.MinValue / 10) return 0;

            result = result * 10 + i;
        }

        return result;
    }
}