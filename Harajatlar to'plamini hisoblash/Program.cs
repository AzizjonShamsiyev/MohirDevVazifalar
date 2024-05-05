Console.Write("To'plamni kiriting (150,230,80,...) : ");
var nums = Console.ReadLine().Split(',');
int summ = 0;
foreach (var num in nums)
    summ += Convert.ToInt32(num);

Console.WriteLine(summ);