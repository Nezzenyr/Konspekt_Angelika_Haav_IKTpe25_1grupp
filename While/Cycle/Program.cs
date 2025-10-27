using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tere tulemast mobifix paranduseautomaati! Kuidas saan aidata?");
        Console.WriteLine("0 - head aega\n1 - tahan telefoni parandada");
        Console.Write("Palun tee valik, kirjutades vastav arv: ");

        int valik = int.Parse(Console.ReadLine());

        while (valik < 0 || valik > 1)
        {
            Console.Write("Palun tee oma valik, kirjutades vastav arv: ");
            valik = int.Parse(Console.ReadLine());
        }

        if (valik == 0)
        {
            Console.WriteLine("Head aega, tulge teinekord jälle!");
        }
        else
        {
            Console.Write("Palun sisesta oma telefoni mudel, mida parandada soovid: ");
            Console.WriteLine("1-IFöön\n2-xiaomjäu\n4-Scamsung");
            Console.WriteLine("palun tee valik, kirjutades vastav arv:");
            int telefonimudel = 0;
            telefonimudel = int.Parse(Console.ReadLine());
            while (telefonimudel < 1 && telefonimudel > 4)
            {
                telefonimudel = int.Parse(Console.ReadLine());
                Console.Write("Palun tee valik, kirjutades vastav arv: ");
            }
            switch (telefonimudel)
            {
                case 1:
                    Console.WriteLine("Aitäh, oma iFööni tagasi 1 nädal pärast");
                    break;
                case 2:
                    Console.WriteLine("Aitäh, sinu xiamjäu on valmis 2 kuu pärast");
                    break;
                    case 3:
                        Console.WriteLine("Kahjuks me huawei ei teenida");
                    break;
                    case 4:
                        Console.WriteLine("Sinu Samsung on valmis 2 päeva pärast");
                    break;
                default:
                    Console.WriteLine("Ei tuune sellist telefoitootaja");
                    break;

            }

        }
    }
}
