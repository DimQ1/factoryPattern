using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Starbuks!");
            Console.WriteLine("What kind of drink do you want, sir?");
            var drinkKind = Console.ReadLine();
            IDrink drink = DrinksFactory.CreateDrink(drinkKind);

            Console.WriteLine($"Here's your drink, that gonna be {drink.Price()}");
            Console.WriteLine("Thank oyu, sir!");
            Console.ReadKey();
        }
    }
}
