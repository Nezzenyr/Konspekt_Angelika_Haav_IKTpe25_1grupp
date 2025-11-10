namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis kujundi pindala sa tahad leida?");
            string kujund = Console.ReadLine();
            double tehe = 0;
            if (kujund == "ruut")
            {
                Console.WriteLine("Sisesta külje pikkus");
                int pikkus = int.Parse(Console.ReadLine());
                tehe = pikkus * 2;
            }
            else if (kujund == "kolmnurk")
            {
                Console.WriteLine("Sisesta  külje pikkus");
                int pikkus1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta kolmnurga kõrgus");
                double pikkus = int.Parse(Console.ReadLine());
                tehe = (pikkus1 * pikkus1) / 2;
            }
            else if (kujund == "ring")
            {
                Console.WriteLine("Kas sa tead enda toa raadiust või läbimõõtu?");
                string rord = Console.ReadLine();

                if (rord == "raadius")
                {
                    Console.WriteLine("Sisesta oma toa raadiuse suurust");
                    int raadius = int.Parse(Console.ReadLine());
                    tehe = Math.PI * (raadius * raadius);
                }
                else if (rord == "läbimõõt")
                {


                    Console.WriteLine("Sisesta oma toa läbimõõtu");
                    int läbimõõt = int.Parse(Console.ReadLine()) / 2;
                    tehe = Math.PI * (läbimõõt * läbimõõt);
                }


            }



            Console.WriteLine($"Sinu toa pindala on{tehe}");




        }
    }
}
