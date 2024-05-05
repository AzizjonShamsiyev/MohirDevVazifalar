Console.Write("Son kiriting : ");
int son = int.Parse(Console.ReadLine());
bool a = true;
for (int i = 2; i <= Math.Sqrt(son); i++)
{
    if ((double)son / i == (int)son / i)
    {
        a = false;
        break;
    }
}

if (a)
    Console.WriteLine("Tup");
else
    Console.WriteLine("Tup emas");