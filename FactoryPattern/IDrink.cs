using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IDrink
    {
        int Price();
        int Size();

        void Making();
    }
}
