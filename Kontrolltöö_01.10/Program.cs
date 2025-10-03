using System.Numerics;

namespace Kontrolltöö_01._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on sinu nimi ?");
            string nimi = Console.ReadLine();
            if (nimi == "")
            {
                Console.WriteLine("Nimi ei ole(.");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");
            }
            {
                Console.WriteLine("Mis on sinu sünnipäev?");
                int kasutajavanus = int.Parse(Console.ReadLine());

                if (kasutajavanus < 0)
                {
                    Console.WriteLine("Sul ie saa olla negatiivsest vanus");
                }
                else if (kasutajavanus > 0)
                    Console.WriteLine("Tere " + nimi  + "" + kasutajavanus);
            }
            Console.WriteLine("Palun märkide temperatuur" + "" + nimi + ":");
            double temp = double.Parse(Console.ReadLine());
            if (temp <= 0)
            {
                Console.WriteLine("põrgu jäätus");
            }
            else if (temp <= 10 && temp >= 0)
            {
                Console.WriteLine("päris külm on");
            }
            else if (temp <= 20 && temp >= 11)
            {
                Console.WriteLine(nimi + "normaalne ilm");
            }
            else if (temp <= 30 && temp >= 21)
            {
                Console.WriteLine("kas läheb grillimiseks?");
            }
            else if (temp <= 40 && temp >= 31)
            {
                Console.WriteLine("APPI; GLOBAALNE SOOJENEMINE");
            }
            else
            {
                Console.WriteLine("Vale sisend");
            }
            Console.WriteLine("Kas ta tahab vaarikat, maasikat või apelsini:");
            string favouriteMarja = Console.ReadLine();
            if (favouriteMarja == "vaarikat")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("näe, vaarikasel!");
            }
            if (favouriteMarja == "apelsini")
            {
                Console.WriteLine("Apelsini mul kahjuks ei ole(((");
            }
            if (favouriteMarja == "Yellow")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (favouriteMarja == "maasikat")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("maasikaski on");
            }
            if (favouriteMarja == "")
            {
                Console.WriteLine("Kasutaja ei täpsustanud marja(");
            }
            
        }
    }
}
