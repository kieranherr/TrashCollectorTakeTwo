using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TrashCollector.Areas.Identity.IdentityHostingStartup))]
namespace TrashCollector.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}