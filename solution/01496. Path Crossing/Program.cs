// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var path = "NES";
var output = solution.IsPathCrossing(path);
Console.WriteLine(output); // false


var path1 = "NESWW";
var output1 = solution.IsPathCrossing(path1);
Console.WriteLine(output1); // true


public class Solution
{
    public bool IsPathCrossing(string path)
    {
        var x = 0;
        var y = 0;
        var hash = new HashSet<string>();

        hash.Add($"{x.ToString()},{y.ToString()}");
        foreach (var point in path)
        {
            switch (point)
            {
                case 'N': y++; break;
                case 'S': y--; break;
                case 'E': x++; break;
                case 'W': x--; break;
            }

            if (hash.Contains($"{x.ToString()},{y.ToString()}"))
            {
                return true;
            }

            hash.Add($"{x.ToString()},{y.ToString()}");
        }

        return false;
    }
}