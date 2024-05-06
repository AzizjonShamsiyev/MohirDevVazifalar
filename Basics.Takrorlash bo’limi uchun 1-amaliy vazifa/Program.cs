
static void Task1()
{
    int i = 1;
    int sum = 0;
    while (i <= 1000)
    {
        if (i % 2 != 0)
        {
            sum += i;
        }
        i++;
    }
    Console.WriteLine(sum);
}

static void Task2()
{ 
    int[] array = { 2,3,-24,435,63,-32,1,22 };
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine(min * max);
}

static void Task3()
{
    Console.Write("Kiriting : ");
    int x = Convert.ToInt32(Console.ReadLine());
    long factorial = 1;
    for (int i = 1; i <= x; i++)
    {
        factorial *= i;
    }
    Console.WriteLine(x + " => " + factorial);

}