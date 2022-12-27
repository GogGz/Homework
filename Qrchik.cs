using System;
namespace Recipes
{
	public class Qrchik : Food, IRecipe
    {
        public Qrchik()
        {
            Console.WriteLine("Creating qrchik");
        }
       
        void IRecipe.Preparing()
        {
            Console.WriteLine("Preparing cottage, tomatoe and water");
        }
        void IRecipe.Making()
        {
            Console.WriteLine("Making awful soup with all ingredients");
        }

        public override void Eating()
        {
            Console.WriteLine("Eating disgusting food ");
        }

    }
}

