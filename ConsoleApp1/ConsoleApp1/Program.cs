// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var rng = new Random();
var nr = new[] { rng.NextDouble(), rng.NextDouble(), rng.NextDouble() }.Select(x => x.ToString());
Console.WriteLine(ToStr(nr.AsEnumerable()));

string ToStr<T>(IEnumerable<T> list)
    => $"[{string.Join(',', list)}]";