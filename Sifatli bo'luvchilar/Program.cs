using System;

class Program
{
    static void Main()
    {
        Console.Write("Iltimos, sonni kiriting: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sifatli bo'luvchilar soni: " + PrimeDivisorsCount(num));
    }

    static int PrimeDivisorsCount(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
        }
        return count;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
