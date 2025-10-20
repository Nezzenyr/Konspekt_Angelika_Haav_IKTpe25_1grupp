using System;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (short i = 0; i < 10; i++)
            {
                //if(i > 5)
                //    break;
                if (i % 2 == 0)
                    continue;
                Console.WriteLine("El:" + i);
            }

        }
    }
}