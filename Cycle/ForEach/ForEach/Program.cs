namespace ForEach
{
    internal class Program
    {string[] konsoolid = { "ps1", "nes", "n64" };

        List<string> mängud = new List<string>();
        foreach(string konsool in konsoolid)
        {
            Console.WriteLine(konsool);
        }

        string currentEntry = ""; 

        while (currentEntry == "")
            {
            Console.WriteLine("Sisesta mäng, või kirjuta" \"Ei taha\" kui soovid esitust lõpetada")
            currentEntry = Console.ReadLine();
            
            if (currentEntry == "ei taha")
            {
            break;
            }
}
        mängud.Add(currentEntry);
currentEntry = "";

         Console.WriteLine("Mis on sinu lemikvärvid, sisesta palun ükshaaval \nKui rohkem värve ei ole, kirjuta \"rohkem pole\"");
    }    

}
