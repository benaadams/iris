using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class Program
{
    public void Configure(IApplicationBuilder app)
        => app.Run(ctx => ctx.Response.WriteAsync("value"));
        
    static void Main(string[] args)
        => WebHost.CreateDefaultBuilder(args)
           .UseStartup<Program>().Build()
           .Run();
}
