namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] konsoolid = { "Audi", "BMW", "Mercedes", "Volvo", "Lada" };

            //List<string> mängud = new List<string>();

            //            foreach (var konsol in konsoolid)
            //            {
            //                Console.WriteLine(konsol);
            //            }
            //            for (int i = 0; i < konsoolid.Length; i++)
            //            {
            //                Console.WriteLine(konsoolid[i]);
            //            }
            //string currentEntry = "";// ajutine muutuja mis hoiab tekstitüüpi andmeid, hetkel tühi
            //while (currentEntry == "")//while tsükkel mis toiib niikaua kunicurrentetry on tühi
            //{
            //    Console.WriteLine("Sisesta mäng Vvõi kirjuta \"ei taha\" kui soovid esitust lõpetada ");
            //    //esitam kasutajale sõnumi 
            //    currentEntry = Console.ReadLine();
            //    //panem ajutisse muutujasse onfo kasutalelt
            //    if (currentEntry == "ei taha")//kui kasutaja kirjutas "ei taha", teeme ifi sisu
            //    {
            //        break;//break katkestab kogu tsükli, peatades sisestamise
            //    }
            //    //mängud[i] = currentEntry;
            //    mängud.Add(currentEntry);//lisame lonidele otsa kasutaja sisestatud info
            //    currentEntry = "";//omistame muutujasse currententry uuesti tühja sisetuse, et tsükkel jätkus.
            //}
            //Console.WriteLine("\n\n\n ");

            //foreach (var mäng in mängud)
            //{
            //    Console.WriteLine(mäng);
            //}
            Console.WriteLine("Mis on su lemmikvärvid? Sisesta palun ükshaaval \nKui rohkem värve ei ole, \"rohkem pole\"");
            List<string> kasutajaVärvid = new List<string>();

            string sisestus = "";
            do
            {
                Console.WriteLine("Sisesta 1 värv korraga:");
                sisestus = Console.ReadLine();

                if (sisestus != "rohkem pole")
                {
                    kasutajaVärvid.Add(sisestus);
                }

            } while (sisestus != "rohkem pole");

            foreach (var värv in kasutajaVärvid)
            {
                switch (värv)
                {
                    //punane, oranz, kollane, roheline, helisinine, tumeroheline, tumesinine, lilla,
                    //roosa, pruun, musst, valge, hall, värvi-ei-tunta
                    //roosa & oranz - neid värve ei ole, tagasta sõnum mis on värvisepetsiifiline
                    case "punane":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- P U N A N E -*-*-");
                        break;
                  
                    case "oranz":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("ORANZ EI OLE((((");
                        break;
                    case "kollane":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- KOLANE  -*-*-");
                        break;
                    case "roheline":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- ROHELINE -*-*-");
                        break;
                    case "sinine":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- helesinine  -*-*-");
                        break;
                    case "tumeroheline":
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- tumeroheline -*-*-");
                        break;
                    case "lilla":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- lilla -*-*-");
                        break;
                    case "roosa":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- roosa -*-*-");
                        break;
                    case "pruun":
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- pruun -*-*-");
                        break;
                    case "musst":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- musst -*-*-");
                        break;
                    case "valge":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- valge -*-*-");
                        break;
                    case "hall":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-*-*- hall -*-*-");
                        break;      
                        
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"slkfns{värv}");
                        break;

                }
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //5 värvitu vastus värvidele: punane oranz kollane roheline 
            // helesinine tumesinine lilla roosa pruun must ja valge

            //    Console.WriteLine("Mis on sinu lemmikvärv?");
            //    string favColour = Console.ReadLine();

            //    if (favColour == "punane")
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //    }
            //    else if (favColour == "oranz")
            //    {
            //        Console.WriteLine("Kahjuks ei ole oranz saadaval");
            //    }
            //    else if (favColour == "kollane")
            //    {
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //    }
            //    else if (favColour == "roheline")
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkGreen;
            //    }
            //    else if (favColour == "helesinine")
            //    {
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //    }
            //    else if (favColour == "tumesinine")
            //    {
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //    }
            //    else if (favColour == "lilla")
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkCyan;
            //    }
            //}
        }
    }
}

    

