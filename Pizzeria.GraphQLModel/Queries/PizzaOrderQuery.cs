using GraphQL.Types;
using Pizzeria.Business.Services;
using Pizzeria.GraphQLModels.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.GraphQLModels.Queries
{
    public class PizzaOrderQuery: ObjectGraphType
    {
        public PizzaOrderQuery(IServicioDetallesOrden servicioDetallesOrden, IServicioDetallesPizza servicioDetallesPizza)
        {
            Name = nameof(PizzaOrderQuery);
            

            FieldAsync<ListGraphType<TipoDetallesOrden>>(
                name: "ordenesNuevas",
                resolve: async context=> await servicioDetallesOrden.GetAllOrdenesNuevasAsync());

            FieldAsync<TipoDetallesPizza>(
                name: "detallesPizza",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>{ Name = "id" }),
                resolve: async context => await servicioDetallesPizza.GetDetallePizzasAsync(context.GetArgument<int>("id")));

            FieldAsync<TipoDetallesOrden>(
                name: "detalleOrden",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name="id"}),
                resolve: async context => await servicioDetallesOrden.GetDetalleOrdenById(context.GetArgument<int>("id")));
        }
    }
}
