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

                //vüimalikud komposititandmetüübid:
                // [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid sama ttüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega.
                //       Massiivne saab olla ükskõik millist lihtandmetüüpi massiive.




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


                Console.WriteLine("Sisesta ostusumma");    //Küsi kasutajast sisestada ostusumma kasutades Console.WriteLine.

                double ostusumma = double.Parse(Console.ReadLine()); //Loe kasutajana sisestatud ostusumma ja sisesta seda ostusumma-sse kasutades double.Parse(Console.ReadLine());
                if (ostusumma > 100)                                 

                {
                    Console.WriteLine("Saad 20% allahindlust!");     //Kontrolli kas ostusumma on suurem kui 100, kui on siis kuva kasutajale tekst "Saad 20% allahindlust!" kasutades
                                                                     //Console.WriteLine

                }
                else if (ostusumma > 50 && ostusumma < 101)                
                {
                    Console.WriteLine("Saad 10% allahindlust!");     //Kontrolli kas ostusumma on suurem kui 50 ja väiksem kui 101, kui on siis kuva kasutajale tekst "Saad 10% allahindlust!"
                                                                     //kasutades Console.WriteLine

                }
                else if (ostusumma > 21 && ostusumma < 51)           //Kontrolli kas ostusumma on suurem kui 21 ja väiksem kui 51, kui on siis kuva kasutajale tekst "saad 5% allahindlust!"
                                                                     //kasutades Console.WriteLine
                {
                    Console.WriteLine("Saad 5% allahindlust!");

                }
                else if (ostusumma < 21)                             //Kontrolli kas ostusumma on väiksem kui 21, kui on siis kuva kasutajale tekst "Allahindlust ei saa" kasutades Console.WriteLine
                { 
                    Console.WriteLine("Allahindlust ei saa");

                }
                else if (ostusumma < 1)                              //Kontrolli kas ostusumma on väiksem kui 1, kui on siis kuva kasutajale tekst "sisestatud vigane arv" kasutades
                                                                     //Console.WriteLine
                { 
                    Console.WriteLine("sisestatud vigane arv");

                }
            }

            //string kasutajanimi = "";
            //do
            // {
            //    Console.WriteLine("Palun sisesta oma kasutajanimi");
            //    kasutajanimi = Console.ReadLine();
            // }
            //  while (kasutajanimi != "user1");
            // if (kasutajanimi == "user1")
            //  {


            //    int RuuduSuurus = 0;
            //    do
            //    {

            //       Console.WriteLine("Kui suurt ruutu tahad?");
            //       RuuduSuurus = int.Parse(Console.ReadLine());
            //   } while (RuuduSuurus < 0 && RuuduSuurus > 20);
            //  char reaKujund = 'Z';
            //  string üksRida = "";
            //  int tsükliMuutuja = RuuduSuurus;
            //  {
            //      üksRida += reaKujund;
            //     tsükliMuutuja += 1;
            //  }
            //  while (tsükliMuutuja != 0) ;
            //  tsükliMuutuja -= RuuduSuurus;
            //  do
            //  {
            //    Console.WriteLine(üksRida);
            //     tsükliMuutuja -= 1;
            //  } while (tsükliMuutuja != 0);
            //   }
            //  Console.WriteLine($"Palun, siin on sinu ruut suurusega");

            if (true) {} //kaitstud sõna if kutsub esile tingimuslause, mille tingumus on sulgude vahel ning millele järgneb
            //koodiplokk tingimuse täitumisel, teostatava koodiga
            else if (!true) {} //kaitstud sõnad else ja if (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
            //on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
            //ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood.
            else {} //kaitstatud sõna else kutsub esile  järeletingimuse, millele peab eelnema kas if või else if, ning mille koodi-
                    //plokki sisu täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.
            int option = 3;
            switch (option) //switch on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if else-if asemel kasutada
                //sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel
                //ei ole tingimus ise, vaid kõigest kontrollitav muutja, või omakorda sulgude vahel muu tingimus.
                //pärast lülitusvalikut tuleb koodiplokk
                //koodiploki sees on erinevad juht,id, juhtmit kontrollitakse kaitsted sõna "case" abil. antud juhul
                //kontrollitakse, kas kuutujas on väärtus 1, millele järgned koolon " : "
                //peale koolonit kirjeldatakse tehtav tegevus
                //ja kui tegevus on täidetud, väljutakse kogi switchi tegevusest kaitstud sõna "break"iga. Pealse "break"i
                //on lause lõppumärk " ; "


            {
                case 1:
                    break;
                    case 2:
                    break;
                    case 3:
                        //juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt, ja üks mida tehakse igal muul juhul.
                        //kasutatud sõna "default" avab juhtumi kui muutujas ei ole mitte ühtegi muud "case" juhtumi tingimust.
                        //
                default:
                    break;
            }

            //*Sõne tööriistad jm tekstiga seotud*
            string alfa = "a\nb";       // \n -> tekitab ühe sõne sisse reamurde, sõne kus on üks "\n" omab kahte rida.
            string beta = $"{alfa} b"; // $ -> lubab kasutada mutujaid logeliste sulgude vahel otse teksti sees

            //* loogilised tehted *//
            //&& -> "and" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
            //mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
            //|| -> "or" loogiline tehe, mida kasutatakse tingumuste kirjutamisel, ning annab positiivse (true) siis kui
            //vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
            //! -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis miudi8 tagastaks true, hüümärgi
            //puhul tagastal false, ja vastupidi - tulemus mis muidu tagastaks false, hüümärgi puhul tagastab true

            //*võrdlusoperaatorid*//

            // == -> on võrdne. Võrdlusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt. Võrdlusmärkide teisel pool oleva
            //objektiga. ei ola sama nagu üks võrdlusmärk. üks võrdlusmärk omistab, kaks võrdleb.
            //!= -> ei ole võrdne. Võrdlusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
            //Võrdlusoperaator on kombinatsioon "on võrdne" operaatorist, ja loogilisest tehtest "not".
            // > -> on suurem kui. Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt.
            // < -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
            // >= -> on väiksen kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
            //kui paremalolev objekt. Operaator on kombinatsioon "on võrdne" ka "on väiksem kui" operaatoritest.
            //<= ->on väiksen kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
            //kui paremalolev objekt. Operaator on kombinatsioon "on võrdne" ka "on väiksem kui" operaatoritest.

            //omistusoperaatorid ja kiirtehted//

            int arv = 1; //= ->  üksik võrdusmärk omistab muutujale väärtuse.
            arv += 1; // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
            //asendab tehel "arv = arv + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest ("=")
            arv -= 1; //-= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse.
            //asendab tehet "arv = arv - 1". on kombinatsioon matemaatilisest tehest "+" ja omistamisest ("=")
            arv *= 2; //võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva arvu kordi.
            //asendab tehet "arv = arv * 2". on kombinatsioon matemaatilisest tehest "*" ja ("=")
            arv = arv / 2; // /= -> võrdusmärk mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleja arvu osadeks.
            //asendab tehet "arv = arv / 2". on kombinatsioon matemaatilisest tehtest "/" ja omamisest ("=")

            //*tsüklid*//
            //1. do-while
            do //"do" on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi.
            {

            } while (true); //niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud.
           
            //2. while
            int i = 1;
            while (i < 5); //"while" pn kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab tihtipeale välist tsüklimuutujat
            //antud juhul on selleks i. tsükli tingimus, mis peale "while" sõna on, sulgude vahel, kontrollibki tingimuse abil, selle
            //muutuja olekut. Siin kontrollitakse, et tsükkel ei oleks suurem kui 5, kui ta on, siis tsükkli töö lõppeb.

            //koodiplokk kus midagi tehakse
            i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud juhul liidetakse 1 juurde

            //3. For
            int kogus = 6;                 //muutuja mida tsükkel kasutab töötlemiseks mingisugusel kujul
            for (int k = 0; k < kogus; k++) //kaitstud sõna "for"alu8stab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö jaoks
            {                               //vajalik info. esimene parameeter tekitab tsükli töö jaoks muutuja, teine parameeter on tingimuslause
                Console.WriteLine(k);       //mis kontrollib tingimuse täitlikust "k < kogus;" ning kolmas inkrementeerib tekitatud muutujat. "k++;"
            }                               //pane tähele et iga sulgude vahel oleva osa järel on  lauselõpumärk. Tsükli tööd kontrolliv tingimuslause
                                            //koosneb kolmest reast, mille ühest, nagu white, või do-white puhul. koodiplokk kus tehakse mingi tegevus
                                            //antud juhul on tegevuseks muutuja "k" arvu väljakuvamine.

            //4.foreachint
            int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiv mida foreach kasutab või töötleb mingil kujul.
             foreach (var arvInLoend in arvuLoend)      //
            {                                           //
                                                        //
            }                                           //



            //Castimine //
            //Castimine on viis, kuidas ühest andmetüübist teist saada. Castimist on kahte eri liiki, automaatne ja manuaalne.
            //Automaatle castmine toimub siis, kui teisendatakse väiksemast andmetüübist suuremasse.
            //Manuaalne castmine toimub siis, kui teisendatakse saada suuremast andmetüübist väiksemat.
            // Castitakse nii, et teisendatava muutuja ette, pannakse sulud koos soovitud andmetüübiga






































        }
    }
}
