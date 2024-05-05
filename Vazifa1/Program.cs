double r, s, l;
Console.Write("R = ");
r = double.Parse(Console.ReadLine());
s = Math.PI * Math.Pow(r, 2);
l = 2 * Math.PI * r;
Console.WriteLine($"S = {s}");
Console.WriteLine($"L = {l}");