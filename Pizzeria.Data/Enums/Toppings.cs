using System;

namespace Pizzeria.Data.Enums
{
    [Flags]
    public enum Ingredientes
    {
        NONE = 0,
        Pepperoni = 1,
        Mushrooms = 2,
        Onions = 4,
        Sausage = 8,
        Bacon = 16,
        ExtraCheese = 32,
        BlackOlives = 64
    }
}
