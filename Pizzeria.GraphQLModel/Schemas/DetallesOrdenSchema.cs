using GraphQL;
using Pizzeria.GraphQLModels.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.GraphQLModels.Schemas
{
    public class DetallesOrdenSchema: GraphQL.Types.Schema
    {
        public DetallesOrdenSchema(IServiceProvider services):base()
        {
            Query = (ConsultaDetallesOrden)services.GetService(typeof(ConsultaDetallesOrden));
        }
    }
}
