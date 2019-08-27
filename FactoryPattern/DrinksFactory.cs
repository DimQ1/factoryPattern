using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class DrinksFactory
    {
        public static IDrink CreateDrink(string drinkType)
        {
            switch (drinkType)
            {
                case "Mocha":
                    return new Mocha(new string[] { "coffe", "milk", "other stuff" });
                case "Tea":
                    return new Tea(new string[] { "balck tea", "hot woter", "sugar" });
                default:
                    return null;
            }
        }
    }
}
