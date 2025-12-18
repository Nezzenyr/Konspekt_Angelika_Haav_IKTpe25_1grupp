namespace TsükliteKordamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. külalised sünnipäeval

            /* dowhile
            küsi kasutajalt tema eesnime, tsükkel peab toimima niikaua kuni kasutaja on sisestanud midagi, et sisestus tühi "" ei oleks.
            */
            Console.WriteLine("Tere. Kirjuta sinu numi?");
            string nimi = "";
            do

            {
                Console.WriteLine("Sinu nimi on:");
                nimi = Console.ReadLine();
            } while (nimi == "");

            /* while
            siis küsi kasutajalt tema sünnikuupäeva kolme while tsükliga, kõigepealt päev, arvuna, siis kuu, nimena, ning siis aasta, arvuna
            päeva küsimise juures tuleb jälgida et kuupäev oleks vahemikus 1-31,
            kuu küsimise juures peab uuesti küsima, kui nimetus ei esine programmis (kas switch-case, if-elseif, või .Contains() abiga)
            aasta juures ei tohi olla sünniaasta 19ndas sajandis (18xx) ega tulevikus. (tekib ka vahemik)
            */
            int sünnipäev = 0;
            Console.WriteLine("Mis on sinu sünnipäev");
            while (sünnipäev < 31 || sünnipäev > 1)
            {

            }


            /* for
            küsi kasutajalt tema sünnipäevale küllatulijaid uude listi for tsükliga, iga tsükkel sisestab uue inimesenime, kuni kasutaja ütleb "kõik"
            */

            /* foreach
            küsi kasutajalt kas on mõni külaline keda ta siiski näha ei tahaks? ning võrdle foreach tsüklis kõik külalised kasutaja sisestatuga.
            eemalda see külaline kui ta nimekirjas on, kui külalist nimekirjast ei leita, siis ütle "sellist inimest sa pole kutsunudki"
            */


            //==========================================================================
            /* 2. Üldine ülesanne
            kirjuta programm mis küsib kasutajalt tema lemmikvärvi, ning joonistab talle tema lemmimkvärvi ruudu, mille sisse kirjutad vastava värvi ainult keskmisele reale. Kasutada võib vabalt valitud tsüklitüüpi
            */
            


        }
    }
}
