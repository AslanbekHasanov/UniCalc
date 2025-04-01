
bool isContinue = true;

while(isContinue is true)
{
    Console.Clear();
    Console.WriteLine("=== Xush kelibsiz ===");
    Console.WriteLine("1.Kalkulyator.");
    Console.WriteLine("2.Valyuta ayri boshlash.");
    Console.WriteLine("3.Yosh hisoblagich");

    Console.Write("Commanda nomerini kiriting(1, 2 ..)");
    int command = Convert.ToInt32(Console.ReadLine());

    if (command == 1)
    {
        Console.Clear();
        Console.WriteLine("==== Kalkulyatorga ====");
        //Kalkuliyotor ishlashi kerak
        Console.Write("son1: ");
        double son1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("amal: ");
        string amal = Console.ReadLine();
        Console.Write("son2: ");
        double son2 = Convert.ToDouble(Console.ReadLine());
        double natija = 0;

        if (amal == "+")
        {
            natija = son1 + son2;
        }
        else if (amal == "-")
        {
            natija = son1 - son2;
        }
        else if (amal == "*")
        {
            natija = son1 * son2;
        }
        else if (amal == "/")
        {
            natija = son1 / son2;
        }
        else
        {
            Console.WriteLine("Noto'g'ri amal kiritildi!");
        }
        Console.WriteLine("Natija: " + natija);

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    else if (command == 2)
    {
        //Valyuta ayri boshlashi kerak
        Console.Clear();
        Console.WriteLine("=== Valyuta ayri boshlandi!=== ");
        Console.WriteLine("1. UZS -> USD");
        Console.WriteLine("2. USD -> UZS");
        Console.Write("Commanda nomerini kiriting(1, 2 ..)");
        int valyutaCommand = Convert.ToInt32(Console.ReadLine());

        if (valyutaCommand == 1)
        {
            Console.Write("UZS: ");
            double uzs = Convert.ToDouble(Console.ReadLine());
            double usd = uzs / 12943.45;
            Console.WriteLine("USD: " + Math.Floor(usd) + " $");
        }
        else if (valyutaCommand == 2)
        {
            Console.Write("USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            double uzs = usd * 12943.45;
            Console.WriteLine("UZS: " + Math.Floor(uzs) + " so'm");
        }
        else
        {
            Console.WriteLine("Noto'g'ri command kiritildi!");
        }

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    else if (command == 3)
    {
        //Yosh hisoblagich ishlashi kerak
        Console.Clear();
        Console.WriteLine("=== Yosh hisoblagich ===");
        Console.Write("Tug'ilgan yilingizni kiriting: ");
        int yil = Convert.ToInt32(Console.ReadLine());
        int yosh = DateTime.Now.Year - yil;
        Console.WriteLine("Siz " + yosh + " yoshdasiz");

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    //command = 4
    //Geometriya hisob-kitoblari
    //Aylana, uchburchak, to‘rtburchak va boshqa shakllarning yuzasi va perimetrini hisoblash.
    else
    {
        Console.WriteLine("Noto'g'ri command kiritildi!");

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
}

Console.WriteLine("Dastur o'z ishini yakunladi!");








