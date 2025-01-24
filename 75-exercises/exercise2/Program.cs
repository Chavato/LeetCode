using System.Diagnostics;
using System.Timers;
using exercise2;

Solution solution = new Solution();

var timer = new Stopwatch();
timer.Start();
string gcd = solution.GcdOfStrings("abc", "abcabc");
timer.Stop();

System.Console.WriteLine($"Result: {gcd}");
System.Console.WriteLine($"Duration: {timer.ElapsedMilliseconds} ms");

