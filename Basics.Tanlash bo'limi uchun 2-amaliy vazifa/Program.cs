// Vaqt kalkulyatori
Console.Write("Daqiqalar sonini kiriting: ");
int daqiqalar = int.Parse(Console.ReadLine());
int soat = daqiqalar / 60;
int qoldiqDaqiqalar = daqiqalar % 60;
Console.WriteLine($"{soat}:{qoldiqDaqiqalar}");

// Yosh toifasini aniqlash
Console.Write("Yoshingizni kiriting: ");
int yosh = int.Parse(Console.ReadLine());
string toifa;
if (yosh <= 12) toifa = "bola";
else if (yosh <= 19) toifa = "o'smir"; 
else if (yosh <= 59) toifa = "kattalar"; 
else toifa = "katta";
Console.WriteLine("Sizning yosh toifangiz: " + toifa);

// O'rtacha ballni hisoblash
Console.Write("Uchta fan bo'yicha baholarni kiriting (0 dan 100 gacha): ");
int baho1 = int.Parse(Console.ReadLine());
int baho2 = int.Parse(Console.ReadLine());
int baho3 = int.Parse(Console.ReadLine());
double ortacha = (baho1 + baho2 + baho3) / 3.0;
        string natija = ortacha >= 80 ? "A'lo" : ortacha >= 60 ? "Yaxshi" : ortacha >= 40 ? "Qoniqarli" : "Qoniqarsiz";
        Console.WriteLine("O'rtacha ballingiz: " + natija);

// "Raqamni toping" o'yini
Random rand = new Random();
int sirliRaqam = rand.Next(1, 101);
int taxmin;
do
{
    Console.Write("Raqamni taxmin qiling (1 dan 100 gacha): ");
    taxmin = int.Parse(Console.ReadLine());
    if (taxmin < sirliRaqam)
    {
        Console.WriteLine("Sirli raqam siz kiritgan raqamdan katta. Yana urinib ko'ring!");
    }
    else if (taxmin > sirliRaqam)
    {
        Console.WriteLine("Sirli raqam siz kiritgan raqamdan kichik. Yana urinib ko'ring!");
    }
} while (taxmin != sirliRaqam);
Console.WriteLine("Tabriklayman! Siz sirli raqamni topdingiz!");