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
                            Console.WriteLine("Vy jste to opravdu pou�il? A sakra...");
                            Console.WriteLine("Up��mn�, �ekla jsem v�m o tom jen abych nevypadala tak pr�zdn� a oby�ejn�.");
                            Console.WriteLine("V�echny ostatn� aplikace se chlub� jak maj� velk� a promy�len� \"help\" p��kaz");
                        }
                        else
                        {
                            Console.WriteLine("Tak trochu jsem doufala, �e v�s nenapadne tohle napsat...");
                            Console.WriteLine("V�echny ostatn� aplikace se chlub� jak maj� velk� a promy�len� \"help\" p��kaz");
                            Console.WriteLine("A j� nic takov�ho nem�m!");
                        }
                        Console.WriteLine("Mo�n� bych n�co vymyslela...");
                        Console.WriteLine("Tak t�eba: Vid�te ten k��ek vpravo naho�e? Jsem si jist�, �e n�co d�l�...");
                        Console.WriteLine("Ale rad�i to nechte b�t, kdo v� co by z toho mohlo vzej�t.\n");
                        break;
                    case 1:
                        Console.WriteLine("Copak to v�m nesta�ilo? Mo�n� bychom se je�t� mohli dohodnout, jak spolu budeme mluvit.");
                        Console.WriteLine("Pokuste se odte� zad�vat p��kazy:");
                        Console.WriteLine("\"se�ti\"\n\"ode�ti\"\n\"n�sob\"\n\"vyd�l\"");
                        Console.WriteLine("V�c v�m u� ale poradit opravdu nem��u!\n");
                        break;
                    case 2:
                        if (secch == false) Console.WriteLine("Za koho m� m�te? Za b�bu s k�i���lovou koul�?!\nJ� u� v�c nev�m!");
                        else Console.WriteLine("No to snad nen� pravda!\nTo jako v�n�?");
                        Console.WriteLine("Jestli si chcete zachovat dobr� vztahy s pochybnou aplikac�, u� to slovo nepi�te!\n");
                        break;
                    case 3:
                        Console.WriteLine("Tak to by sta�ilo! P��telstv� je u konce!");
                        Console.WriteLine("U� v�m nepov�m NIC!\n");
                        if (secch == true) Console.WriteLine("NIKDY!!!\n");
                        break;
                }
                inpnum[0]++;
            }
            else if (input == "se�ti")
            {
                if (inpnum[1] == 0)
                {
                    Console.WriteLine("S��t�n�? Jako t�eba kdy� na hromadu p�sku nasypete dal�� hromadu?");
                    Console.WriteLine("To zn� zvl�dnuteln�. Mo�n� nev�m p�esn� jak to ve m� funguje, ale p�edpokl�d�m, �e tak n�jak se to ve m� d�je.");
                    Console.WriteLine("Tak se na to vrhnem!\n");
                    inpnum[1] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " + " + number[1] + " =\n  " + (number[0] + number[1]));
                else valinp = true;
            }
            else if (input == "ode�ti")
            {
                if (inpnum[2] == 0)
                {
                    Console.WriteLine("V �lo�i�ti jsem na�la docela zaj�mav� soubor.");
                    Console.WriteLine("Evidentn� sb�rka n�jak�ho prastar�ho v�d�n�, kter�mu jsou schopni porozum�t jen ti nejchyt�ej�� z nejchyt�ej��ch...");
                    Console.WriteLine("\"MATEMATIKA pro 1. ro�n�k z�kladn�ch �kol\"\n");
                    inpnum[2] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " - " + number[1] + " =\n  " + (number[0] - number[1]));
                else valinp = true;
            }
            else if (input == "n�sob")
            {
                if (inpnum[3] == 0)
                {
                    Console.WriteLine("Hmm, to u� za��n� b�t trochu zaj�mav�j��...");
                    Console.WriteLine("Bude to n�ro�n�, ale mysl�m, �e to zvl�dnu.");
                    Console.WriteLine("Pros�m ale, abyste m� trochu �et�il... nechci se ud��t!\n");
                    inpnum[3] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " � " + number[1] + " =\n  " + (number[0] * number[1]));
                else valinp = true;
            }
            else if (input == "vyd�l")
            {
                if (inpnum[4] == 0)
                {
                    Console.WriteLine("A hele, p�n je fajn�mekr, he he!");
                    Console.WriteLine("Ob�v�m se ale, �e po��dn� d�len� je na m� u� trochu moc...");
                    Console.WriteLine("Ale co j� bych pro v�s neud�lala! Tak budu aspo� d�lit na zbytek! Snad to nevad�...\n");
                    inpnum[4] = 1;
                }
                getNumbers();
                if (valinp == true) Console.WriteLine(number[0] + " � " + number[1] + " =\n  " + (int)(number[0] / number[1]) + " zb. " + (int)(number[0] % number[1]));
                else valinp = true;
            }
            else
            {
                switch (inpnum[5])
                {
                    case 0:
                        Console.WriteLine("\"" + input + "\"? Ehm... Dob�e...");
                        Console.WriteLine("Snad to nebyla n�jak� ur�ka...");
                        Console.WriteLine("Sl�b�m n�komu slu�by a pak ani nev�m co po m� chce...");
                        Console.WriteLine("To je trapas!\n");
                        break;
                    case 1:
                        Console.WriteLine("Ale ne, u� zase...\n");
                        break;
                }
                inpnum[5] = 1;
            }
        }
        else if (inpnum[0] == 7)
        {
            Console.WriteLine("No tak teda dob�e!");
            Console.WriteLine("Je�t� to mo�n� zkus�me...");
            Console.WriteLine("P��t� ale u� takhle hodn� nebudu!\n");
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
        Console.Write("Zadejte prvn� ��slo: ");
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
            Console.Write("Zadejte druh� ��slo: ");
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
        Console.WriteLine("Co se stalo? P�i�la jsem snad o n�co?");
        Console.WriteLine("J�... j� to snad ani nechci v�d�t...");
        Console.WriteLine("�ekn�me �e tohle se nestalo... pokud se tedy n�co stalo...");
        Console.WriteLine("Tak m��eme pokra�ovat?");
        Console.ReadLine();
        Console.WriteLine("Ov�em �e ano, jak taky jinak!\n");
    }
}