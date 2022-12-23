namespace Bankomat;
class Program
{
    static void Main(string[] args)
    {
        Card card1 = new Card("Gohar", "Ghazaryan", 1234);
        Card.InsertCard(card1);
        



        Console.ReadKey();
        


    }
}

