namespace Recipes;
class Program
{
    static void Main(string[] args)
    {

        Pizza Margarita = new Pizza ("Margarita", 3000,300,20);
        Pizza Quatro = new Pizza("Quatro Formagi", 4000, 300,30);
        Margarita.ShowFood();


        Shawrma MyShaurma = new Shawrma("big");
        MyShaurma.FoodName = "Pork Shawrma";
        MyShaurma.FoodPrice = 500;
        MyShaurma.FoodWeight = 200;
        MyShaurma.ShowFood();

        Qrchik AndurQrchik = new Qrchik();
        AndurQrchik.Eating();
        AndurQrchik.ShowFood();

        Hotdog MyHotdog = new Hotdog("Hamov hotdog", 600, 150, "Chicken" );
        MyHotdog.Eating();
        MyHotdog.ShowFood();

       if( MyHotdog is Food)
            Console.WriteLine("Hotdog is food");
       else Console.WriteLine("Hotdog is not food");

       






        Console.ReadKey();
    }
}

