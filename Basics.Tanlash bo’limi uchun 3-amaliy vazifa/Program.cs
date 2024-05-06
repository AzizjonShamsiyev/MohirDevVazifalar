// Palindrome Tekshiruvi
Console.Write("So'zni kiriting: ");
string soz = Console.ReadLine();
string teskariSoz = new string(soz.Reverse().ToArray());
Console.WriteLine(soz == teskariSoz ? "Palindrom" : "Palindrom emas");

// Temperatura o'girish
Console.Write("Graduslar (Selsiyus) bo'yicha temperaturani kiriting: ");
double selsiyus = double.Parse(Console.ReadLine());
double fahrenheit = selsiyus * 9 / 5 + 32;
double kelvin = selsiyus + 273.15;
Console.WriteLine($"Selsiyus: {selsiyus}, Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");

// Sonlarni tartiblash
Console.Write("Sonlarni kiriting (vergul bilan ajratilgan): ");
List<int> sonlar = Console.ReadLine().Split(',').Select(int.Parse).ToList();
sonlar.Sort();
Console.WriteLine("Tartiblangan qator: " + string.Join(", ", sonlar));
sonlar.Reverse();
Console.WriteLine("Teskari tartib: " + string.Join(", ", sonlar));

// Berilgan matnning simvol sanasini hisoblash
Console.Write("Matnni kiriting: ");
string matn = Console.ReadLine();
var simvolSanasi = new Dictionary<char, int>();
foreach (char simvol in matn)
{
    if (simvolSanasi.ContainsKey(simvol))
    {
        simvolSanasi[simvol]++;
    }
    else
    {
        simvolSanasi[simvol] = 1;
    }
}
foreach (KeyValuePair<char, int> item in simvolSanasi)
{
    Console.WriteLine($"'{item.Key}': {item.Value} martta");
}