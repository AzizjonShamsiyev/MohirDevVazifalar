using System.Globalization;

Console.Write("Qachon tug'ilgansiz(dd/MM/yyyy) : ");
var t = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
TimeSpan date = DateTime.UtcNow - t;
Console.WriteLine("Yoshingiz : " + date.Days);