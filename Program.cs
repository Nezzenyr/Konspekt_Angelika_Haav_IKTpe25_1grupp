// See https://aka.ms/new-console-template for more information

//Kalulaator 

int arv1 = 0;
int arv2 = 0;
Console.WriteLine("sisesta esimene arv");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta teine arv");
arv2 = int.Parse(Console.ReadLine());
int liitmine = arv1 + arv2;
Console.WriteLine("missugust tehet soovid teha? kirjuta kas: + - * / ^");
string tehtetüüp = Console.ReadLine();
int tehe = 0;
if (tehtetüüp == "+")
{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "-")
{
    tehe = arv1 - arv2;
}
if (tehtetüüp == "*")
{
    tehe = arv1 * arv2;
}
if (tehtetüüp == "/")
{
    tehe = arv1 / arv2;
}
if (tehtetüüp == "^")
{
    tehe = (int)Math.Pow(arv1, arv2);
}
Console.WriteLine($" {tehtetüüp} tehte tulemus: {tehe}");

