using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pizzeria.Data;
using Pizzeria.GraphQLModels.Schemas;

namespace Pizzeria.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // For Async IO Operations
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddControllers();

            services.AddDbContext<PizzaDbContext>(optionsAction: options => options.UseSqlServer(Configuration["ConnectionStrings:PizzaOrderDb"]),
                contextLifetime: ServiceLifetime.Singleton);

            services.AddCustomServices();
            services.AddCustomGraphQLServices();
            services.AddCustomGraphQLTypes();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PizzaDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            dbContext.EnsureDataSeeding();

            app.UseWebSockets();

            app.UseGraphQL<DetallesOrdenSchema>();

            app.UseGraphQLWebSockets<DetallesOrdenSchema>();

            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
