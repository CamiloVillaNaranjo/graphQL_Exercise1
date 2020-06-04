using Microsoft.EntityFrameworkCore;
using Pizzeria.Data.Entities;
using System;

namespace Pizzeria.Data
{
    public class PizzaDbContext : DbContext
    {
        //DbPizzaOrders
        public PizzaDbContext()
        {

        }

        public PizzaDbContext(DbContextOptions<PizzaDbContext> options):base(options)
        {

        }

        public DbSet<DetalleOrdenes> DetalleOrdenes { get; set; }
        public DbSet<DetallePizzas> DetallePizzas { get; set; }
    }
}
