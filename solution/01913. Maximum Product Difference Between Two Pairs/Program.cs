// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

var solution = new Solution();

int[] input1 = [5, 6, 2, 7, 4];
var output1 = solution.MaxProductDifference(input1);
Console.WriteLine(output1); // 34

//var summary = BenchmarkRunner.Run<BenchmarkSolution>();

[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
public class BenchmarkSolution
{
    [Params(10)]
    public int N;

    private int[] data;

    [GlobalSetup]
    public void GlobalSetup()
    {
        data = new int[N]; // executed once per each N value
    }

    [Benchmark]
    public void MaxProductDifference()
    {
        int[] input1 = [5, 6, 2, 7, 4];
        var solution = new Solution();
        var output1 = solution.MaxProductDifference(input1);
    }

    [Benchmark]
    public void MaxProductDifference1()
    {
        int[] input1 = [5, 6, 2, 7, 4];
        var solution = new Solution();
        var output1 = solution.MaxProductDifference1(input1);
    }
}

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        // 直接對原Array進行排序，故比OrderBy方法更有效率
        Array.Sort(nums);

        return (nums[^1] * nums[^2]) - (nums[0] * nums[1]);
    }

    public int MaxProductDifference1(int[] nums)
    {
        // order by為LINQ延遲執行，g
        nums = nums.OrderBy(x => x).ToArray();

        return (nums[^1] * nums[^2]) - (nums[0] * nums[1]);
    }
}