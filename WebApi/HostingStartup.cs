using Service;
using WebApi.Services;

[assembly: HostingStartup(typeof(WebApi.HostingStartup))]
namespace WebApi
{
    public class HostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(ConfigureServices);
        }
        private void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();
            
            services.AddHttpClient();
        }
    }
}
