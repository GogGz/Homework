using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Recipes
{
	public class Pizza: Food, IRecipe
    {
        int diametr; // new field

        public Pizza(string name, int price, int weight, int diametr) : base(name, price, weight) //base constructor + new field
        {

            this.diametr = diametr;
            Console.WriteLine("Creating " + name + " Pizza of size " + diametr + " cm");

        }

        void IRecipe.Preparing()
        {
            Console.WriteLine("Preparing dough, tomatoe, cheese and basilic");
        }
        void IRecipe.Making()
        {
            Console.WriteLine("Baking at oven over 250'C");
        }

        public override void Eating()
        {
            Console.WriteLine("Eating italian food");
        }



    }
}

