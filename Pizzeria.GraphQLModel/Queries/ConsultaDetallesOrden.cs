using GraphQL.Types;
using Pizzeria.Business.Services;
using Pizzeria.GraphQLModels.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.GraphQLModels.Queries
{
    public class ConsultaDetallesOrden: ObjectGraphType
    {
        public ConsultaDetallesOrden(IServicioDetallesOrden detallesOrden)
        {
            Name = nameof(ConsultaDetallesOrden);

            FieldAsync<ListGraphType<TipoDetallesOrden>>(
                name: "ordenesNuevas",
                resolve: async context=> await detallesOrden.GetAllOrdenesNuevasAsync());
        }
    }
}
