int son, m, res = 0, r;
Console.Write("Kiriting :");
son = Convert.ToInt32(Console.ReadLine());
m = son;
while (m != 0)
{
    r = m % 10;
    res = res + (r * r * r);
    m = m / 10;
}
if (res == son)
    Console.WriteLine("Armstrong soni");
else
    Console.WriteLine("Armstrong soni emas");