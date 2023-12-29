// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

int[] digits = [1, 2, 3];
var output = solution.PlusOne(digits);
Console.WriteLine(string.Join(",", output)); // [1,2,4]

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var result = new int[digits.Length + 1];
        result[^1] = 1;

        for (int i = 1; i <= digits.Length; i++)
        {
            result[^i] = (result[^i] + digits[^i]);

            if (result[^i] >= 10)
            {
                result[^i] = result[^i] % 10;
                result[^(i + 1)] = result[^(i + 1)] + 1;
            }
        }

        return result[0] == 0 ? result[1..] : result[..];
    }
}

public class Solution1
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        var result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}