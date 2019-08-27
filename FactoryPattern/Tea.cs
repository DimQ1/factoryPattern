using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Tea : IDrink
    {
        public Tea(string[] ingredients)
        {

        }

        public void Making()
        {
            throw new NotImplementedException();
        }

        public int Price()
        {
            return 5;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
