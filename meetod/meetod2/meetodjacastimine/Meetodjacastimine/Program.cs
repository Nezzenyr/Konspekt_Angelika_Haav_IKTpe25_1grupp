namespace Meetodjacastimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arv);
            double arvdouble = 279346559d;
            int arvint = 0;
            arvint = (int)arvdouble;

            double uusdouble = arvint;


            string pikkusm = "";
            Console.WriteLine("Sisesta oma pikkus");
            pikkusm = Console.ReadLine();
            float pikkusFm = float.Parse(pikkusm);
            int pikkuscm = (int)pikkusFm;
            Console.WriteLine($"Sinu pikkus sentimeetrites on : {pikkuscm}");
        }
    }
}
