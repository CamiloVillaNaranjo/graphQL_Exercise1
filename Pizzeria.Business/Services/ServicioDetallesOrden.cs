using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Data.Entities;
using Pizzeria.Data.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Business.Services
{
    public interface IServicioDetallesOrden
    {
        Task<IEnumerable<DetalleOrdenes>> GetAllOrdenesNuevasAsync();
        Task<DetalleOrdenes> GetDetalleOrdenById(int idDetalleOrden);
    }

    public class ServicioDetallesOrden : IServicioDetallesOrden
    {
        private readonly PizzaDbContext _dbContext;

        public ServicioDetallesOrden(PizzaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<DetalleOrdenes>> GetAllOrdenesNuevasAsync()
        {
            return await _dbContext.DetalleOrdenes.Where(o=>o.EstadoOrden == EstadoOrden.Created).ToListAsync();
        }

        public async Task<DetalleOrdenes> GetDetalleOrdenById(int idDetalleOrden)
        {
            return await _dbContext.DetalleOrdenes.FindAsync(idDetalleOrden);
        }
    }
}
