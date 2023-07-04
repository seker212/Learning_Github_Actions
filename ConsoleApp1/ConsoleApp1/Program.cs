// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var rng = new Random();
var nr = new[] { rng.NextInt64(), rng.NextInt64(), rng.NextInt64() };
Console.WriteLine(ToStr(nr.AsEnumerable()));

string ToStr<T>(IEnumerable<T> list)
    => $"[{string.Join(',', list)}]";