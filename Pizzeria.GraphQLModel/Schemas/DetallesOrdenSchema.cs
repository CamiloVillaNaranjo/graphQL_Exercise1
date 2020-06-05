using GraphQL;
using GraphQL.Types;
using Pizzeria.GraphQLModels.Queries;
using System;

namespace Pizzeria.GraphQLModels.Schemas
{
    public class DetallesOrdenSchema : Schema
    {
        public DetallesOrdenSchema(IServiceProvider sp)
        {
            Query = (PizzaOrderQuery)sp.GetService(typeof(PizzaOrderQuery));
        }
    }
}
