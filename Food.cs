using System;
namespace Recipes
{
	public class Food: FoodDemo
	{
        private string name; // fields will be derived
        private int price;
        private int weight;

        public string FoodName
        {
            get { return this.name; }
            set {name = value;}
        }
        public int FoodPrice
        {
            get {return this.price;}
            set {price = value;}
        }

        public int FoodWeight
        {
            get{ return this.weight;}
            set{ weight = value;}
        }


        public Food()
        {
            Console.WriteLine("Default food is created");
        }

        public Food(string name, int price, int weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public virtual void Eating() // to be overrided by derived classes
        {
            Console.WriteLine("Eating food ");
        }

        public override void ShowFood()
        {
            Console.WriteLine("Showing a " + weight + "g " + name +" with price " + price);
        }

    }
}