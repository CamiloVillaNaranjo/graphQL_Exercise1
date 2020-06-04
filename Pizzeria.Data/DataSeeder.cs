using Pizzeria.Data.Entities;
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
                    new DetallePizzas("Pizza Napolitana", Enums.Ingredientes.ExtraCheese| Enums.Ingredientes.Onions,Enums.Sizes.Large,18,1),
                    new DetallePizzas("Pizza Griega",Enums.Ingredientes.Mushrooms | Enums.Ingredientes.Peperoni | Enums.Ingredientes.Bacon, Enums.Sizes.xLarge, 12,2),
                    new DetallePizzas("Pizza Thin-Crusty", Enums.Ingredientes.Peperoni | Enums.Ingredientes.ExtraCheese,Enums.Sizes.Medium,21,3)
                });

                dbContext.SaveChanges();
            }

        }
    }
}
