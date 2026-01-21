using System.Security.Cryptography.X509Certificates;

namespace meetod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Public static string ReadAnswer()
            {
                string sisend "";
                while (sisend == "")
                {
                    sisend = Console.ReadLine();
                }
                return sisend;
            }

        }
    }    public static List<string> GetMovies()
        {
            Console.WriteLine("Mis on su lemmikfilmid, sisesta ükshaaval, kui sisestada rohkem ei taha \n sisesta \"Ei ole"\");
            string sisestus "";
            List<string> siinPnFilmid = new List<string>();
            while (sisestus != "ei ole")
            {
                Console.WriteLine("järgmine film:");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    sisestus.add(sisestus);
                }
            }
                 return siinPnFilmid;

            public static List<string> DoYouLikeThisMovie(List<string> collection, string movieToAdd)
        {





        }
           
        }
}
