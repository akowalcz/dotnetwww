using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace webapp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                string dbName = Environment.GetEnvironmentVariable("DBName");
                string dbUser = Environment.GetEnvironmentVariable("DBUser");
                string dbPass = Environment.GetEnvironmentVariable("dbpasswd");
                
                
                await context.Response.WriteAsync("Hello World From .Net Core container Jun 19 at 11:32! running on: ");
                
                
            
                
                await context.Response.WriteAsync("\nDatabase name: " + dbName  + "\nUser name: "  + dbUser + "\nDB passwd: " + dbPass);
            });
        }
    }
}
