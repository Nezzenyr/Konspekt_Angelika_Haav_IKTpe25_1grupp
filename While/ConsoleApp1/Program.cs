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