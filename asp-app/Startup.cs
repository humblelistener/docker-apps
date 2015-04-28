using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace aspApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {

            app.UseErrorPage();

            app.UseServices(services =>
            {
                services.AddMvc();
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=User}");
            });
        }
    }
}