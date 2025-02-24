using System.Diagnostics;
using exercise1431;

Solution solution = new Solution();
int[] candies = { 2, 3, 5, 1, 3 };
int extraCandies = 3;

var timer = new Stopwatch();
timer.Start();
IList<bool> boolList = solution.KidsWithCandies(candies, extraCandies);
timer.Stop();

System.Console.Write($"Result: ");
foreach (var result in boolList)
{
    System.Console.Write($"[{result}]");
}

System.Console.WriteLine();
System.Console.WriteLine($"Duration: {timer.ElapsedMilliseconds} ms");
