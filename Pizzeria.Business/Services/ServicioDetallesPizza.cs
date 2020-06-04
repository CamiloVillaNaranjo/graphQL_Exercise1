using Pizzeria.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Business.Services
{
    public interface IServicioDetallesPizza
    {

    }

    public class ServicioDetallesPizza : IServicioDetallesPizza
    {
        private readonly PizzaDbContext _dbContext;

        public ServicioDetallesPizza(PizzaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
