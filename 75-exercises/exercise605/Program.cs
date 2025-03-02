using System.Diagnostics;
using exercise605;

Solution solution = new Solution();
int[] flowerBed = { 0, 0, 1, 0, 0 };
int newFlowers = 1;

var timer = new Stopwatch();
timer.Start();
bool result = solution.CanPlaceFlowers(flowerBed, newFlowers);
timer.Stop();

System.Console.Write($"Result: {result}");
System.Console.WriteLine();
System.Console.WriteLine($"Duration: {timer.ElapsedMilliseconds} ms");
