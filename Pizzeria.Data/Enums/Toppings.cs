using System;

namespace Pizzeria.Data.Enums
{
    [Flags]
    public enum Ingredientes
    {
        NONE = 0,
        Peperoni = 1,
        Mushrooms = 2,
        Onions = 3,
        Sausage = 4,
        Bacon = 5,
        ExtraCheese = 6,
        BlackOlives = 7
    }
}
