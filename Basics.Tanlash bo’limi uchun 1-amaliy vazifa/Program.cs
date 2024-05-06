Console.Write("So'zni kiriting : ");
var str = Console.ReadLine();
Console.Write("Sonni kiriting : ");
int x = int.Parse(Console.ReadLine());
Task1(ref str, x);
Console.WriteLine(str);

static void Task1(ref string str, int x)
{
    if (x > str.Length)
        str = str.ToUpper();
    else
        str = str.ToLower();
}

Console.WriteLine("------------------------------");
Task2();
static void Task2()
{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    string result;

    if (x > y)
        result = "x is greater than y";
    else if (y > x) result = "x is less than y";
    else if (x == y) result = "x is equal to y";
    else result = "x and y are not comparable";

    Console.WriteLine(result);
}

Console.WriteLine("--------------------------");
Console.Write("Hafta kunini kiriting (O'zbekcha): ");
string haftaKuni = Console.ReadLine();
string res = Task3(haftaKuni);
Console.WriteLine(res);

static string Task3(string haftaKuni)
{
       string tarjima;

        switch (haftaKuni)
        {
            case "Dushanba":
                tarjima = "Monday";
                break;
            case "Seshanba":
                tarjima = "Tuesday";
                break;
            case "Chorshanba":
                tarjima = "Wednesday";
                break;
            case "Payshanba":
                tarjima = "Thursday";
                break;
            case "Juma":
                tarjima = "Friday";
                break;
            case "Shanba":
                tarjima = "Saturday";
                break;
            case "Yakshanba":
                tarjima = "Sunday";
                break;
            default:
                tarjima = "Noto'g'ri kiritilgan hafta kuni";
                break;
        }
        return tarjima; 
}