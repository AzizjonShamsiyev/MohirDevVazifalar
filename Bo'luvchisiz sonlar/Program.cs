Console.Write("Son : ");
int son = int.Parse(Console.ReadLine());

Console.Write("Bo'luvchilar : ");
for (int i = 2;i<=10;i++)
{
    if (son % i == 0)
        Console.Write(" "+i+",");
}
