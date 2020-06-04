using System;
using System.Collections.Generic;
using GraphQL.Types;
using Pizzeria.Data.Enums;

namespace Pizzeria.GraphQLModels.Enums
{
    public class IngredientesEnumType: EnumerationGraphType<Ingredientes>
    {
        public IngredientesEnumType()
        {
            Name = nameof(IngredientesEnumType);
        }
    }
}
