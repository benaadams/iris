using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public void ConfigureServices(IServiceCollection services)
        => services.AddMvcCore();

    public void Configure(IApplicationBuilder app)
        => app.UseMvc();
        
    static void Main(string[] args)
        => WebHost.CreateDefaultBuilder(args)
           .UseStartup<Program>()
           .Build().Run();
}
