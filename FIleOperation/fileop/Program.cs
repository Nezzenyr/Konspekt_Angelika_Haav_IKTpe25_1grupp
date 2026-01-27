using System.Numerics;
using System.Runtime.CompilerServices;

namespace fileop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta siia oma postkasti aadress");

            string filePath = "C:\\Users\\opilane\\source\\repos\\Conspect\\Konspekt_Angelika_Haav_IKTpe25_1grupp\\FIleOperation\\postkastiaadress.txt";
            string aadress = Console.ReadLine();

            File.WriteAllText(filePath, aadress);

            Console.WriteLine("Kõik laulusõnad");

            DisplayThisFile();

            private static void DisplayThisFile()
            {
            string line = "";
            try
            {
                using (StreamReader readThisThing = new StreamReader
             C:\\Users\\opilane\\source\\repos\\Conspect\\Konspekt_Angelika_Haav_IKTpe25_1grupp\\FIleOperation\\MJBJ.txt)
            }
             catch (Exception e)
            {
                Console.WriteLine("Ei saa lugeda sest:" + e.Message);
                throw;

            }














             }
       }
    }
}
