using System.ComponentModel.Design;

namespace konspekt
{
    internal class program
    {
        static void main(string[] args)
        {

            //1. tuvasta sinu võrdluses tühja stringiga string andmetüüp
            Console.WriteLine("tere kasutaja, kuidas on su nimi?");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("sa ei sisestanud oma nime, D:");
            }
            else if (nimi != "")
            {
                Console.WriteLine("tere " + nimi + " !:D");
            }
            else
            {
                Console.WriteLine("tundmatu sisestus");
            }
            //2. vahemikud
            Console.WriteLine(nimi + ", mis on sinu vanus?");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud ifide abil
            if (kasutajavanus > 0)
            {
                if (kasutajavanus < 18)
                {
                    Console.WriteLine("enerksi ei saa, oled alakas, monsterist ilma d:");
                }
                else
                {
                    Console.WriteLine("yippe! saad monsut osta :d");
                }
            }


            //2.2 mitu tingimust kasutades loogilist tehet "and"
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("enerksi ei saa, oled alakas, monsterist ilma");
            }
            else
            {
                Console.WriteLine("yippe! saad monsut osta");
            }


            //2.3 mitu vahemikku if else-if abil. andmetüüp double/float/decimal
            Console.WriteLine($"sisesta oma pikkus ka {nimi}!");
            double kasutajapikkus = double.Parse(Console.ReadLine());

            if (kasutajapikkus < 1.00d)
            {
                Console.WriteLine("oled juntsu");
            }
            else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
            {
                Console.WriteLine("oled peaaegu allameetrimees");
            }
            else if (kasutajapikkus < 1.50d && kasutajapikkus >= 1.25d)
            {
                Console.WriteLine("oioi, päkapikk enam ei olegi, " + nimi);
            }
            else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.50d)
            {
                Console.WriteLine(nimi + ", oled enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)
            {
                Console.WriteLine(nimi + ", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
            }
            else
            {
                Console.WriteLine("täielik tulnukas! kuidas pilved välja näevad lähedalt?");
            }

            //
            int arv1 = 0;
            int arv2 = 0;
            Console.WriteLine("tere, palun sisesta esimene arv");
            arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("tere, palun sisesta teine arv");
            arv2 = int.Parse(Console.ReadLine());
            int liitmine = arv1 + arv2;
            Console.WriteLine("missugust tehet soovid teha? kirjuta kas: + - * /");
            string tehtetüüp = Console.ReadLine();
            int tehe = 0;
            if (tehtetüüp == "+"  /*tingimus siia*/)
            {
                tehe = arv1 + arv2;
            }
            if (tehtetüüp == "-"    /*tingimus siia*/)
            {
                tehe = arv1 - arv2;
            }
            if (tehtetüüp == "*"   /*tingimus siia*/)
            {
                tehe = arv1 * arv2;
            }
            if (tehtetüüp == "/"   /*tingimus siia*/)
            {
                tehe = arv1 / arv2;
            }
            if (tehtetüüp == "^")
            {
                tehe = (int)Math.Pow(arv1, arv2);
            }
            Console.WriteLine($" {tehtetüüp} tehte tulemus: {tehe}");
            //4 parool, if ja string andmetüüp
            Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
            string password = Console.ReadLine();
            if (password == "simsalabim")
            {
                            Console.WriteLine("YES, parool on õige, oled sisse lubatud");
            }
            else if (password == "saatana"  || password == "1234")
            {
                Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
            }
            else
            {
                Console.WriteLine("Parool on vale");
            }
            //5 värvituvastus
            Console.WriteLine("Mis on sinu lemmikvärv?");
            string favColour = Console.ReadLine();
            if (favColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (favColour == "Oranz") {

                Console.WriteLine("Kahjuks ei ole oranz saadaval"); 
            }

            else if (favColour == "Kollane")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            } 
            else if (favColour == "Roheline")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            } 
            else if (favColour == "Sinine")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (favColour == "Lilla")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            else
            {
                Console.WriteLine("Ei tea seda värvi");
            }
            Console.WriteLine("The colour has changed :D");

            Console.WriteLine("Kas sa tahad ära mõõta pappkasti või õlitünni?");
            string mõõta = Console.ReadLine();
            if (mõõta == "pappkasti")
            {
                Console.WriteLine("Kas kast on kuubiku kujuline või risttahuka kujuline?");
                string kast = Console.ReadLine();
                if (kast == "kuubik")
                {

                }
                else if (kast == "risttahukas")
                        {

                        }
            }
            else if (mõõta == "õlitünni")
            {
                Console.WriteLine("kas sa tead põhja raadiust või põhja läbimõõtu?");

            }





















































        }   //Kolija kalkulaator
    }         
}             
