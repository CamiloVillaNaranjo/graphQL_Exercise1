using GraphQL.Types;
using Pizzeria.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.GraphQLModels.Types
{
    public class TipoDetallesPizza: ObjectGraphType<DetallePizzas>
    {
        public TipoDetallesPizza()
        {
            Name = nameof(TipoDetallesPizza);

            Field(x => x.Id);
            Field(x => x.Nombre);
            Field(x => x.IdDetalleOrdenes);
            Field(x => x.Precio);

            Field<StringGraphType>(
                name: "Ingredientes",
                resolve: context => context.Source.Ingredientes.ToString());

            Field<StringGraphType>(
                name: "Tamano",
                resolve: context => context.Source.Tamano.ToString());
        }
    }
}
