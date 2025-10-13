// See https://aka.ms/new-console-template for more information

string kasutajanimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi");
    kasutajanimi = Console.ReadLine();
}
while (kasutajanimi != "user1");
if (kasutajanimi == "user1")
{


    int RuuduSuurus = 0;
    do
    {

        Console.WriteLine("Kui suurt ruutu tahad?");
        RuuduSuurus = int.Parse(Console.ReadLine());
    } while (RuuduSuurus < 0 && RuuduSuurus > 20);
    char reaKujund = 'Z';
    string üksRida = "";
    int tsükliMuutuja = RuuduSuurus;
    {
        üksRida += reaKujund;
        tsükliMuutuja += 1;
    }
    while (tsükliMuutuja != 0) ;
    tsükliMuutuja -= RuuduSuurus;
    do
    {
        Console.WriteLine(üksRida);
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);
}