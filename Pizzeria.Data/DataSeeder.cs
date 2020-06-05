using Pizzeria.Data.Entities;
using Pizzeria.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria.Data
{
    public static class DataSeeder
    {
        public static void EnsureDataSeeding(this PizzaDbContext dbContext)
        {
            if (!dbContext.DetalleOrdenes.Any())
            {
                dbContext.DetalleOrdenes.AddRange(new List<DetalleOrdenes>
                {
                    new DetalleOrdenes("CRA 92 #40-54", "Santa Mónica", "3122641423", 2),
                    new DetalleOrdenes("CLL 38A #80-72", "Laureles", "3122641313", 1),
                    new DetalleOrdenes("CLL 37 #63-63", "Conquistadores", "3012200304", 3)
                });

                dbContext.SaveChanges();
            }

            if (!dbContext.DetallePizzas.Any())
            {
                dbContext.DetallePizzas.AddRange(new List<DetallePizzas>
                {
                    new DetallePizzas("Pizza Napolitana", Ingredientes.ExtraCheese| Ingredientes.Onions, Sizes.Large,18,4),
                    new DetallePizzas("Pizza Griega",Ingredientes.Mushrooms | Ingredientes.Pepperoni | Ingredientes.Bacon, Sizes.xLarge, 12,5),
                    new DetallePizzas("Pizza Thin-Crusty", Ingredientes.Pepperoni | Ingredientes.ExtraCheese,Sizes.Medium,21,6)
                });

                dbContext.SaveChanges();
            }

        }
    }
}
