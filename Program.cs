/*
    running on:
    Fun Calculator v1.3.0 by KachnozroutEU
    
    English version by: PurOwO 
    Other:
    Date of creation: 21.02.2025.
*/

using System;
class Program
{
    static Random random = new Random();
    static String input = "";
    static double[] number = new double[2];
    static byte[] inpnum = { 0, 0, 0, 0, 0, 0 };
    static bool valinp = true, yesinp = false, secch = false;

    static void Main()
    {

        Console.WriteLine("Im compleatly sane and normal aplication :3");
        Console.WriteLine("What do you need from me?\n");
        Console.ReadLine();
        Console.WriteLine("\nCONGRATS! you have aproximatly ~1:<outOfBoundsValue> that you will follow MY instructions!");
        Console.WriteLine("\nPleasseee,I dont understand ASCII. UwU");
        Console.WriteLine("\nSo wana begin?");
        input = normalString(Console.ReadLine());
        if (input != "yes") Console.WriteLine("WELLL idk.... Eh whatever i start anyway.");
        else
        {
            Console.WriteLine("HUH... odd... thought i heard something");
            Console.WriteLine("ANYWAY! if you need any asistance just type \"help\"");
            yesinp = true;
        }
        Console.WriteLine("Here you go:");
        Console.WriteLine("...");
        Console.WriteLine("Actualy i forgor what you wanted... heh...");
        Console.WriteLine("Mayyybeeee...");
        Console.WriteLine("Calculator...?\n\n");
        while (true) loop();


    }
    static void loop()
    {
        input = "";
        input = normalString(Console.ReadLine());
        if (inpnum[0] <= 3)
        {
            if (input == "help")
            {
                switch (inpnum[0])
                {
                    case 0:
                        if (yesinp == true)
                        {
                            Console.WriteLine("Vy jste to opravdu použil? A sakra...");
                            Console.WriteLine("Upøímnì, øekla jsem vám o tom jen abych nevypadala tak prázdnì a obyèejnì.");
                            Console.WriteLine("Všechny ostatní aplikace se chlubí jak mají velký a promyšlený \"help\" pøíkaz");
                        }
                        else
                        {
                            Console.WriteLine("Tak trochu jsem doufala, že vás nenapadne tohle napsat...");
                            Console.WriteLine("Všechny ostatní aplikace se chlubí jak mají velký a promyšlený \"help\" pøíkaz");
                            Console.WriteLine("A já nic takového nemám!");
                        }
                        Console.WriteLine("Možná bych nìco vymyslela...");
                        Console.WriteLine("Tak tøeba: Vidíte ten køížek vpravo nahoøe? Jsem si jistá, že nìco dìlá...");
                        Console.WriteLine("Ale radši to nechte být, kdo ví co by z toho mohlo vzejít.\n");
                        break;
                    case 1:
                        Console.WriteLine("Copak to vám nestaèilo? Možná bychom se ještì mohli dohodnout, jak spolu budeme mluvit.");
                        Console.WriteLine("Pokuste se odteï zadávat pøíkazy:");
                        Console.WriteLine("\"seèti\"\n\"odeèti\"\n\"násob\"\n\"vydìl\"");
                        Console.WriteLine("Víc vám už ale poradit opravdu nemùžu!\n");
                        break;
                    case 2:
                        if (secch == false) Console.WriteLine("Za koho mì máte? Za bábu s køišálovou koulí?!\nJá už víc nevím!");
                        else Console.WriteLine("No to snad není pravda!\nTo jako vážnì?");
                        Console.WriteLine("Jestli si chcete zachovat dobré vztahy s pochybnou aplikací, už to slovo nepište!\n");
                        break;
                    case 3:
                        Console.WriteLine("Tak to by staèilo! Pøátelství je u konce!");
                        Console.WriteLine("Už vám nepovím NIC!\n");
                        if (secch == true) Console.WriteLine("NIKDY!!!\n");
                        break;
                }
                inpnum[0]++;
            }
            else if (input == "seèti")
            {
                if (inpnum[1] == 0)
                {
                    Console.WriteLine("Sèítání? Jako tøeba když na hromadu písku nasypete další hromadu?");
                    Console.WriteLine("To zní zvládnutelnì. Možná nevím pøesnì jak to ve mì funguje, ale pøedpokládám, že tak nìjak se to ve mì dìje.");
                    Console.WriteLine("Tak se na to vrhnem!\n");
                    inpnum[1] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " + " + number[1] + " =\n  " + (number[0] + number[1]));
                else valinp = true;
            }
            else if (input == "odeèti")
            {
                if (inpnum[2] == 0)
                {
                    Console.WriteLine("V úložišti jsem našla docela zajímavý soubor.");
                    Console.WriteLine("Evidentnì sbírka nìjakého prastarého vìdìní, kterému jsou schopni porozumìt jen ti nejchytøejší z nejchytøejších...");
                    Console.WriteLine("\"MATEMATIKA pro 1. roèník základních škol\"\n");
                    inpnum[2] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " - " + number[1] + " =\n  " + (number[0] - number[1]));
                else valinp = true;
            }
            else if (input == "násob")
            {
                if (inpnum[3] == 0)
                {
                    Console.WriteLine("Hmm, to už zaèíná být trochu zajímavìjší...");
                    Console.WriteLine("Bude to nároèné, ale myslím, že to zvládnu.");
                    Console.WriteLine("Prosím ale, abyste mì trochu šetøil... nechci se udøít!\n");
                    inpnum[3] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " × " + number[1] + " =\n  " + (number[0] * number[1]));
                else valinp = true;
            }
            else if (input == "vydìl")
            {
                if (inpnum[4] == 0)
                {
                    Console.WriteLine("A hele, pán je fajnšmekr, he he!");
                    Console.WriteLine("Obávám se ale, že poøádné dìlení je na mì už trochu moc...");
                    Console.WriteLine("Ale co já bych pro vás neudìlala! Tak budu aspoò dìlit na zbytek! Snad to nevadí...\n");
                    inpnum[4] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " ÷ " + number[1] + " =\n  " + (int)(number[0] / number[1]) + " zb. " + (int)(number[0] % number[1]));
                else valinp = true;
            }
            else
            {
                switch (inpnum[5])
                {
                    case 0:
                        Console.WriteLine("\"" + input + "\"? Ehm... Dobøe...");
                        Console.WriteLine("Snad to nebyla nìjaká urážka...");
                        Console.WriteLine("Slíbím nìkomu služby a pak ani nevím co po mì chce...");
                        Console.WriteLine("To je trapas!\n");
                        break;
                    case 1:
                        Console.WriteLine("Ale ne, už zase...\n");
                        break;
                }
                inpnum[5] = 1;
            }
        }
        else if (inpnum[0] == 7)
        {
            Console.WriteLine("No tak teda dobøe!");
            Console.WriteLine("Ještì to možná zkusíme...");
            Console.WriteLine("Pøíštì ale už takhle hodná nebudu!\n");
            inpnum[0] = 2;
            secch = true;
        }

        else
        {
            Console.WriteLine("...\n");
            if (secch == false) inpnum[0]++;
        }
    }

    static String normalString(String str)
    {
        char[] strc = str.ToCharArray();
        str = "";
        for (int i = 0; i < strc.Length; i++)
        {
            strc[i] = char.ToLower(strc[i]);
            str += strc[i];
        }
        return str;
    }

    static void getNumbers()
    {
        Console.Write("Zadejte první èíslo: ");
        input = Console.ReadLine();
        try
        {
            number[0] = double.Parse(input);
        }
        catch
        {
            valinp = false;
            restart();
        }
        if (valinp == true)
        {
            Console.Write("Zadejte druhé èíslo: ");
            input = Console.ReadLine();
            try
            {
                number[1] = double.Parse(input);
            }
            catch
            {
                valinp = false;
                restart();
            }
        }
        if ((int)random.Next(0, 10) == 0)
        {
            valinp = false;
            restart();
        }
    }

    static void restart()
    {
        for (int x = 0; x < 50; x++)
        {
            for (int y = 0; y < 50; y++) Console.Write((char)random.Next(0, 255));
            Console.Write("\n");
        }
        Console.WriteLine("\n\n\nRESTARTING.............................................\n\n\n\n\n\n");
        for (int x = 0; x < 6; x++) inpnum[x] = 0;
        yesinp = false;
        Console.WriteLine("Co se stalo? Pøišla jsem snad o nìco?");
        Console.WriteLine("Já... já to snad ani nechci vìdìt...");
        Console.WriteLine("Øeknìme že tohle se nestalo... pokud se tedy nìco stalo...");
        Console.WriteLine("Tak mùžeme pokraèovat?");
        Console.ReadLine();
        Console.WriteLine("Ovšem že ano, jak taky jinak!\n");
    }
}