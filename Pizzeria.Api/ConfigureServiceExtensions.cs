using GraphQL;
using GraphQL.Server;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Business.Services;
using Pizzeria.GraphQLModels.Types;
using Pizzeria.GraphQLModels.Enums;
using Pizzeria.GraphQLModels.Schemas;
using Pizzeria.GraphQLModels.Queries;

namespace Pizzeria.Api
{
    public static class ConfigureServiceExtensions
    {
        
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IServicioDetallesPizza, ServicioDetallesPizza>();
            services.AddTransient<IServicioDetallesOrden, ServicioDetallesOrden>();
        }

        public static void AddCustomGraphQLServices(this IServiceCollection services)
        {
            services.AddSingleton<IDependencyResolver>(c => new FuncDependencyResolver(type => c.GetRequiredService(type)));

            services.AddGraphQL((options) => {
                options.EnableMetrics = true;
                options.ExposeExceptions = false;
            })
            .AddWebSockets()
            .AddDataLoader()
            .AddGraphTypes(ServiceLifetime.Transient);
        }

        public static void AddCustomGraphQLTypes(this IServiceCollection services)
        {
            services.AddSingleton<TipoDetallesOrden>();
            services.AddSingleton<TipoDetallesPizza>();

            services.AddSingleton<EstadoOrdenEnumType>();
            services.AddSingleton<IngredientesEnumType>();

            services.AddSingleton<PizzaOrderQuery>();
            services.AddSingleton<DetallesOrdenSchema>();
        }
    }
}
