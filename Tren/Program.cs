//# Kolija kalkulaator - Kirjuta programm mis:
//#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//#    - olenevalt kasutaja sisestusest küsib ta:
//#    - - tünni jaoks:
//#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//#    - - - tünni kõrgust
//#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//#    - - kasti jaoks:
//#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//#    - - - - kui on risttahukas siis küsib kasutajalt:
//#    - - - - - pikima külje pikkust, 
//#    - - - - - lühima külje pikkust ja
//#    - - - - - kasti kõrgust
//#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)

using System;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas sa tahad mõõta pappkasti või õlitünni?");
            string mahutavus = (Console.ReadLine());

            if (mahutavus == "õlitünni")
            {
                Console.WriteLine("Valitud võimsus pappkasti");
            }
            else if (mahutavus == "õlitünni")
            {
                Console.WriteLine("Valitud võimsus õlitünni");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud midagi");

             
            }
            
            Console.WriteLine("Kas teate tünni põhja raadiust (r) või läbimõõtu (d)? Sisestage 'r' või 'd':");
            string rvõid = Console.ReadLine();
            Console.WriteLine("Kui kõrge on selle raadisu/läbimitöö?");
            double kasutajamõõt = double.Parse(Console.ReadLine());
            Console.WriteLine("Kui kõrge on su tüüni ?");
            double kõrgus = double.Parse(Console.ReadLine());
            Console.WriteLine("Kui paks on su tünni kaas?");
            double kaanepaksus = double.Parse(Console.ReadLine());
            double Sp = 0;
            if (rvõid == "R")
            {
            Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            }
            else if (rvõid == "D")
            {
                kasutajamõõt = kasutajamõõt / 2;
                Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
            }
            double V = 0;
            kõrgus = kõrgus - kaanepaksus;
            V = Sp * kõrgus;
            double Sk = 2 * Math.PI * kasutajamõõt * kõrgus;
            double S = Sp + Sk;
            Console.WriteLine($"Sinu tünn mahutab {V}\nTünni küljepimdala on {Sk}\nTünni kogupimadala on {S}");
         

        }
    }
}