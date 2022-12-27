using System;
namespace Recipes
{
	public class Hotdog : Food, IRecipe
    {
        string meat_type;

        public string MeatType
        {
            get { return meat_type; }
            set { meat_type = value; }
        }

        public Hotdog(string name, int price, int weight, string meat_type) : base(name, price, weight) // adding meat type
        {
            this.meat_type = meat_type;
            Console.WriteLine("Creating hotdog with " + meat_type + " meat sausage");
        }

        void IRecipe.Preparing()
        {
            Console.WriteLine("Preparing bread, sausage, cheese and souces");
        }
        void IRecipe.Making()
        {
            Console.WriteLine("Toasting made hotdog");
        }

        public override void Eating()
        {
            Console.WriteLine("Eating junk food ");
        }

    }
}

