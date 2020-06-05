using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Business.Services
{
    public interface IServicioDetallesPizza
    {
        Task<DetallePizzas> GetDetallePizzasAsync(int idDetallePizza);
        IEnumerable<DetallePizzas> GetAllDetallePizzasByOrder(int idOrden);
    }

    public class ServicioDetallesPizza : IServicioDetallesPizza
    {
        private readonly PizzaDbContext _dbContext;

        public ServicioDetallesPizza(PizzaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<DetallePizzas> GetDetallePizzasAsync(int idDetallePizza)
        {
            return await _dbContext.DetallePizzas.FindAsync(idDetallePizza);
        }

        public IEnumerable<DetallePizzas> GetAllDetallePizzasByOrder(int idOrden)
        {
            return _dbContext.DetallePizzas.Where(p => p.IdDetalleOrdenes == idOrden).ToList();
        }
    }
}
