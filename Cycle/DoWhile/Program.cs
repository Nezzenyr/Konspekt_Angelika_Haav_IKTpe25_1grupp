using System;
using System.ComponentModel.Design;
using System.Transactions;

namespace project
{
    class Program
    {
        static void Main()

        {
            //string kasutajaNimi = "";


            //do
            //{
            //    Console.WriteLine("Sisesta kasutajanimi:");
            //    kasutajaNimi = Console.ReadLine();
            //} while (kasutajaNimi != "user");


            // if (kasutajaNimi == "user")

            ////{
            ////    int ruuduSuurus = 0;
            //    do
            //{
            //    console.writeline("sisesta ruudu suurus tehad?");
            //    ruudusuurus = int.parse(console.readline());
            //} while (ruudusuurus <= 1 || ruudusuurus >= 20000) ;
            //char reakujund = '*';
            //string üksrida = "";
            //int tsüklimuutuja = ruudusuurus;

            //do
            //{
            //    üksrida = üksrida + "_" + reakujund;
            //    tsüklimuutuja = tsüklimuutuja - 1;
            //} while (tsüklimuutuja != 0);

            //tsüklimuutuja = ruudusuurus;
            //do
            //{
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    } while (tsükliMuutuja != 0);
            //    Console.WriteLine($"Palun, sin on sinu ruut {ruuduSuurus}x{ruuduSuurus}");
            //}
            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust!!!!!!!!!!!!!!OMFGZEROONE!!!!!!!!!!!!!!!!!!!");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahindlust. c: yay");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }

            else if (ostusumma < 21 && ostusumma > 0)
            {
                Console.WriteLine("Kahjuks allahindlust ei ole.");
            }
            else
            {
                Console.WriteLine("Vigane sisestus.");
            }


            if (true) { } //ksitsud sõuna if kutsub esile tingimusele, mille tingimus on sulgude vahel, ning millile  järgenb
                          //koodiplokk tingimusi täitumisel teostatavata koodiaga
            else if (true) { } //else if kutsub esile täiendava tingimuse, mis kontrollitakse siis, kui eelnev if tingimus on väär
            else { } //else kutsub esile koodiploki, mis teostatakse siis, kui ükski eelnevatest tingimustest ei ole täidetud
                     //täidakse kõijide teiste "if" ja "else if" tingimuste läbikukkumisel

            //loogilised tehtud
            // && -> "and" loogiline tehe, mida kasutajatakse tingimisel, ning annab positivne vastuse (true) juhul , kui mõlemad tingimused on tõesed
            // || -> "or" loogiline tehe, mida kasutatakse tingimisel, ning annab positiivne vastuse (true) juhul, kui vähemalt üks tingimus on tõene
            // vähemalt üks tingimus peab olema tõene, et kogu tingimus oleks tõene
            // ! -> "not" loogiline tehe, mida kasutatakse tingimisel, ning mis pöörab tingimuse väärtuse ümber. Tullemus mis muidugi tagastaks (true), 
            // hüüumärgi abil tgastab (false), ja vastupidi - tulemu mis muidu tagastaks (false), tagastab (true)

            /* Võrdlusoperaatorid
             * == võrdne
             * != mitte võrdne
             * > suurem kui
             * < väiksem kui
             * >= suurem või võrdne kui
             * <= väiksem või võrdne kui
             */
            /* omistusooperaatorid ja kiirtehted */

            int thing = 1; // = -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
            thing += 1;  // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                         //      asendab tehet "thing = thing + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
            thing -= 1;  // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva arvu.
                         //      asendab tehet "thing = thing - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "=".
            thing *= 2;  // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool oleva arvu kord.
                         //      asendab tehet "thing = thing * 2". on kombinatsioon matemaatilisest tehtest "*" ja omistamisest "=".
            thing /= 2;  // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva arvu osadeks. asendab tehet "thing = thing / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest "=".
            thing++;    // ++ -> on spetsiifiliselt ühe juurde liitmiseks kiirtehe.
            thing--;    // -- -> on spetsiifiliselt ühe maha lahutamiseks kiirtehe.

            /* Tsüklid */
            // 1. do-while
            do // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärast seda on koodiplokk {} ning ütleb et tee seda koodi
            {
            }
            while (true); // niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.


        }
    }
}