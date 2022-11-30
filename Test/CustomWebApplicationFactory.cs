using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace E2E;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            // extend service collection
        });

        builder.ConfigureTestServices(services =>
        {
            // extend service collection
        });

        // builder.Configure(app =>
        // {
        //     // extend application builder
        // });
    }
}
