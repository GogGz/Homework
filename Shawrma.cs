using System;
namespace Recipes
{
	public class Shawrma: Food, IRecipe
    {
        string size;

        public Shawrma(string size) : base()
        {
            this.size = size;
            Console.WriteLine("Creating Shawrma of size \" " + size + " \"");
        }

        void IRecipe.Preparing()
        {
            Console.WriteLine("Preparing bread, meat, tomatoe, and souces");
        }
        void IRecipe.Making()
        {
            Console.WriteLine("Making shawrma roll with ingredients");
        }

        public override void Eating()
        {
            Console.WriteLine("Eating lebaese food ");
        }

    }
}

