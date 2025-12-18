namespace tsükkel_ja_masiiv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kasutajanimi;
            string parool;


            do
            {
                Console.Write("Sisesta kasutajanimi: ");
                kasutajanimi = Console.ReadLine();

                Console.Write("Sisesta parool: ");
                parool = Console.ReadLine();

                if (kasutajanimi != "nimi" && parool != "tsau1234")
                {
                    Console.WriteLine("Vale kasutajanimi või parool!");
                }

            } while (kasutajanimi != "admin" && parool != "tere123");

            Console.WriteLine("Sisselogimine õnnestus!");


            int[] number = new int[3];


            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. number: ");
                number[i] = int.Parse(Console.ReadLine());
            }

            int min = number[0];
            int max = number[0];
            int sum = 0;


            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < min)
                    min = number[i];

                if (number[i] > max)
                    max = number[i];

                sum += number[i];
            }

            double average = (double)sum / number.Length;


            Console.WriteLine("Tulemused:");
            Console.WriteLine("Minimaalne: " + min);
            Console.WriteLine("Maksimaalne: " + max);
            Console.WriteLine("Keskmine: " + average);

            Console.WriteLine("Massiivi väärtused:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }




        }

    }
}
