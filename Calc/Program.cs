Console.Write("1-son : ");
double a = double.Parse(Console.ReadLine());
Console.Write("Operator(+,-,*,/) : ");
var op = Console.ReadLine();
Console.Write("2-son : ");
double b =  double.Parse(Console.ReadLine());

switch(op)
{
    case "+":
        Console.WriteLine($"c = {a+b}");
        break;

    case "-":
        Console.WriteLine($"c = {a - b}");
        break;

    case "*":
        Console.WriteLine($"c = {a * b}");
        break;

    case "/":
        Console.WriteLine($"c = {a / b}");
        break;
    default:
        Console.WriteLine("Operator xato!");
        break;
}