using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Mocha : IDrink
    {
        public Mocha(string[] ingredients)
        {

        }

        public void Making()
        {
            throw new NotImplementedException();
        }

        public int Price()
        {
            return 3;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
