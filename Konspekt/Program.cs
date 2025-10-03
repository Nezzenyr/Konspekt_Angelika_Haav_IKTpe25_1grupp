using System.ComponentModel.Design;
using System.Transactions;

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
            else if (password == "saatana" || password == "1234")
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
            else if (favColour == "Oranz")
            {

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
//                # Kolija kalkulaator - Kirjuta programm mis:
//# - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            Console.WriteLine("Kas sa tahad ära mõõta pappkasti või õlitünni?");
            string mida = Console.ReadLine();
            //# - olenevalt kasutaja sisestusest küsib ta:
            if (mida == "õlitünni")
            {
                //# - - tünni jaoks:
                //# - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
                Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
                string rvõid = Console.ReadLine();
                Console.WriteLine("Sisesta see mõõt");
                double mõõt = double.Parse(Console.ReadLine());
                if (rvõid == "d")
                {
                    mõõt = mõõt / 2;
                }
                else if (rvõid != "r")
                {
                    Console.WriteLine("Sisend ei ole tuntav");
                }
                //# - - - tünni kõrgust
                Console.WriteLine("Kui kõrge on su tunn");
                int kõrgus = int.Parse(Console.ReadLine());
                //# - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
                Console.WriteLine("Kui paks on tünni kaas?");
                int kaanepaksus = int.Parse(Console.ReadLine());
                //# - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
                double tünnipõhiS = Math.PI * (mõõt * mõõt);
                double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
                double küljepindala = tünnipõhiS * kõrgus;
                double kogupindala = (tünnipõhiS * 2) + küljepindala;
                Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on {kogupindala}");
            }
            else if (mida == "kast")
            {
                //# - - kasti jaoks:
                //# - - - Kas kast on kuubiku kujuline või risttahuka kujuline
                Console.WriteLine("Kas su kast on kuubik´(k) või risttahukas (r)?");
                string kastitüüp = Console.ReadLine();
                if (kastitüüp == "k")
                {
                    Console.WriteLine("Sisesta kasti küljepikkus:");
                    double külgA = double.Parse(Console.ReadLine());
                    double kuubik = Math.Pow(külgA, 3);
                    double küljepindala = (külgA * külgA) * 6;
                    double diagonaal = külgA * Math.Sqrt(3);
                    Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on {diagonaal}");
                }

                //# - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust

                //# - - - - kui on risttahukas siis küsib kasutajalt:
                else if (kastitüüp == "r")
                { //# - - - - - pikima külje pikkust,
                    Console.WriteLine("Mis on sinu kasti kõige pikim külg?");
                    double pikkülg = double.Parse(Console.ReadLine());
                    //# - - - - - lühima külje pikkust
                    Console.WriteLine("Mis on sinu kasti kõige lühim külg?");
                    double lühikekülg = double.Parse(Console.ReadLine());
                    //# - - - - - kasti kõrgust
                    Console.WriteLine("Mis on sinu kasti kõrgus?");
                    double kõrgus = double.Parse(Console.ReadLine());
                    double V = pikkülg * lühikekülg * kõrgus;
                    //# - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
                    double kogupindala = 2 * ((pikkülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkülg * kõrgus));
                    double diagonaal = Math.Sqrt((pikkülg * pikkülg) + (lühikekülg * lühikekülg + (kõrgus * kõrgus)));
                    Console.WriteLine($"Sinu kast mahutab {V} \nKasti kogupindala on {kogupindala} \nDiagonaal aga on {diagonaal}");

                }


                Console.WriteLine("banana");
                // Console -> adresseeritav moodul või objekt (roheline)
                //. -> Midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
                // WriteLine -> adresseritav funktsioon objektist Console
                //() -> sulupaar mis omab endas funktioonile vajalikku infot
                //    - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
                // [] -> tähistab massiive
                // {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust
                //    - saab ka kasutada teksti sees muutujate kuvamiseks
                // -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
                //"banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
                // ; -> iga koodilause lõppeb komakooloniga

                int muutuja = 3;

                    //int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
                    //=  -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
                    //3  -> väärtus mis sellele muutujale omistatakse

                //võimalikud andmetüübid:
                    int a = 1; //täisarv
                decimal b = 2.0m; //kümnendusüsteemis olev komakohaga arv
                float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
                double d = 4.0d;//kümnendsüsteemis olev komakohaga arv, sarnane decimaliga.
                    char c1 = 'a'; // üksainus täht või tähemärk
                string s = "tekst"; //inimloetaval kujul tekst
                var x = "abc"; //ebamäärase tüübiga kohalik muutuja.
                var y = 123;
                const int z = 3;//konstant tüüpi muutujaid ei saa muuta, need on read-only


                //põhilised matemaatilised tehted
                int liitmine2= 1 + 1; //liitmine, kaks arvu kokku
                int lahutamine = 1 - 1; //lahutamine, esimene arv maha teisest
                int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
                int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
                double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
                double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

                int arv6 = 0;
                int arv7 = 0;
                Console.WriteLine("tere, palun sisesta esimene arv");
                arv6 = int.Parse(Console.ReadLine());
                Console.WriteLine("tere, palun sisesta teine arv");
                arv7 = int.Parse(Console.ReadLine());
                int liitmine3 = arv6 + arv7;
                Console.WriteLine("missugust tehet soovid teha? kirjuta kas: + - * /");
                string tehtetüüp2 = Console.ReadLine();
                int tehe2 = 0;
                if (tehtetüüp2 == "+"  /*tingimus siia*/)
                {
                    tehe2 = arv6 + arv7;
                }
                if (tehtetüüp2 == "-"    /*tingimus siia*/)
                {
                    tehe2 = arv6 - arv7;
                }
                if (tehtetüüp2 == "*"   /*tingimus siia*/)
                {
                    tehe2 = arv6 * arv7;
                }
                if (tehtetüüp2 == "/"   /*tingimus siia*/)
                {
                    tehe2 = arv6 / arv7;
                }
                if (tehtetüüp2 == "^")
                {
                    tehe2 = (int)Math.Pow(arv6, arv7);
                }
                Console.WriteLine($" {tehtetüüp2} tehte tulemus: {tehe2}");








            }


















































        }
    }
}
