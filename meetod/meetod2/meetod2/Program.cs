namespace meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();
            string kasutajaNimi = "";
            kasutajaNimi = nimeKüsimine(kasutajaNimi);
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            float eelarve = 0.00f;
            bool kaskasutajanõustub = false;
            while (kaskasutajanõustub != true)
            {
                Console.WriteLine($"Praegune eelarve on {eelarve}, kas see on õige?");
                Console.WriteLine("Vasta kas jah või ei:");
                string mistaütles = Console.ReadLine();
            }
            if (mistaütles = "jah")
            {
                kasutajanõustub = true;

            }
            SinuEelarvePäevas(eelarve, kasutajaNimi);

        }

        private static string nimeKüsimine(string kasutajaNimi)
        {
            while (kasutajaNimi == " ")
            {
                Tervitus();
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                kasutajaNimi = Console.ReadLine();
            }

            return kasutajaNimi;
        }

        public static void Tervitus();
 }      Console.WriteLine("'ommik");
        public static int SinuEelarvePäevas(float eelarve, string kasutajanimi)
    {
        double eelarvepäevas = eelarve / 7;
        return (int)eelarvepäevas;
    }

    } 