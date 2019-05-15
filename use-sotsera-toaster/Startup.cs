using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

using Sotsera.Blazor.Toaster.Core.Models;

namespace use_sotsera_toaster
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddToaster(config =>
            {
                config.PositionClass = Defaults.Classes.Position.TopRight;
                config.HideTransitionDuration = 3000;
                config.MaximumOpacity = 80;
                config.VisibleStateDuration = 10000;
                config.NewestOnTop = false;
                config.ShowCloseIcon = true;
                config.ShowProgressBar =false;
                config.PreventDuplicates = true;
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
