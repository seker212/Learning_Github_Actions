// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var rng = new Random();
var nr = new[] { rng.NextDouble(), rng.NextDouble(), rng.NextDouble() };
Console.WriteLine(ToStr(nr.AsEnumerable()));

string ToStrOld(IEnumerable<double> list)
    => $"[{string.Join(',', list)}]";

string ToStr(IEnumerable<string> list)
    => $"[{string.Join(',', list)}]";