using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.GraphQLModels.Enums
{
    public class EstadoOrdenEnumType : EnumerationGraphType
    {
        public EstadoOrdenEnumType()
        {
            Name = "estadoOrden";

            AddValue("Created", "Order Created", 1);
            AddValue("InKitchen", "In Preparation", 2);
            AddValue("OnTheWay", "Is on the way", 3);
            AddValue("Delivered", "Successfull delivered", 4);
            AddValue("Canceled", "Was canceled by user/client", 5);
        }
    }
}
