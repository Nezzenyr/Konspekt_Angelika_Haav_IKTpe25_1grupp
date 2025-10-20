using System.ComponentModel.Design;

Console.WriteLine("Joonistan sulle kolmnurga");
int kolmnurgaSuurus = int.Parse(Console.ReadLine());


int i = 1;
while (i <= kolmnurgaSuurus)
{
    Console.WriteLine("");
    int j = 1;
    while(j <= i)
    {
        Console.Write(j + "█");
        j++;
    }
i++;
}

Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas ma saan aidata?");
Console.WriteLine("0 - headaega\n1 - tahan telefoni parandada");
int kasutajavalik = int.Parse(Console.ReadLine());
while (kasutajavalik <= 0)
{
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
    if (kasutajavalik == 0)
    {
        Console.WriteLine("Headaega, tulge jälle!");
    }
    else 
    {
        Console.WriteLine("Palun sisesta oma telefoni mudel, mida parandada soovid: ");
        Console.WriteLine("1 - iPhone\n2 - Xiaomi\n3 - Huawei\n4 - Samsung");
        Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
        int kasutajaTelefon = int.Parse(Console.ReadLine());
        while (kasutajaTelefon < 1 && kasutajaTelefon > 4)
        {
            kasutajaTelefon = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun tee oma valik, kirjutades vastav arv,");
            switch (kasutajaTelefon)
        {
            case 1:
                Console.WriteLine("Aitäh, oma iPhone saad tagasi 1 nädala pärast");
                break;
            default:
                break;
                case 2:
                Console.WriteLine("Aitäh, sinu Xiaomi on valmis 2 kuu pärast");
                break;
                    case 3:
                Console.WriteLine("Kahjuks me huaweid ei teeninda");
                break;
                     case 4:
                Console.WriteLine("Sinu samsung saab valmis 2 päeva pärast");
                break;
        }
        }Console.WriteLine("Kas soovid mõnda muud mudelit parandada?");
        Console.WriteLine("0 - Jah\n1 - ei");
        int kasutajaTeineValik = 1;
        while (kasutajaTeineValik < 0 && kasutajaTeineValik > 1)
        {
            Console.WriteLine("Palun tee oma valik,");
        }
      
    }
}   