using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

using Blazor.Fluxor;

namespace blazor_fluxor_todo_app.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFluxor(options => options
		        .UseDependencyInjection(typeof(Startup).Assembly)
                .AddMiddleware<Blazor.Fluxor.ReduxDevTools.ReduxDevToolsMiddleware>()
	        );
            /*
            services.AddFluxor(options => options
                    .UseDependencyInjection(typeof(Startup).Assembly)
                    .AddMiddleware<Blazor.Fluxor.ReduxDevTools.ReduxDevToolsMiddleware>()
                    .AddMiddleware<Blazor.Fluxor.Routing.RoutingMiddleware>()
                );
                */
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
