using GraphQL.Types;
using Pizzeria.Business.Services;
using Pizzeria.Data.Entities;
using Pizzeria.GraphQLModels.Enums;

namespace Pizzeria.GraphQLModels.Types
{
    public class TipoDetallesOrden : ObjectGraphType<DetalleOrdenes>
    {
        public TipoDetallesOrden(IServicioDetallesPizza servicioDetallesPizza)
        {
            Name = nameof(TipoDetallesOrden);

            Field(x => x.Id);
            Field(x => x.Direccion1);
            Field(x => x.Direccion2);
            Field(x => x.MovilNo);
            Field(x => x.Monto);
            Field(x => x.Fecha);

            Field<EstadoOrdenEnumType>(
                name: "estadoOrden",
                resolve: context => context.Source.EstadoOrden.ToString());

            Field<ListGraphType<TipoDetallesPizza>>(
                 name: "pizzasPorOrden",
                 resolve: context => servicioDetallesPizza.GetAllDetallePizzasByOrder(context.Source.Id));
        }
    }
}
