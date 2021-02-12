using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            #region First Sample

            
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware start");
                await next.Invoke();
                await context.Response.WriteAsync("Middleware end");

            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Sub middleware Run");
            });

            #endregion First Sample

            #region Second Sample

            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Middleware start ");
                next.Invoke();
                await context.Response.WriteAsync("Middleware end ");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware2 start ");
                next.Invoke();
                await context.Response.WriteAsync("Middleware2 end ");
            });
            app.Run(async (context) => {
                await context.Response.WriteAsync("next middleware Running ");
            } );
            #endregion


            #region Middleware Run

            app.Run(async context => {
                await context.Response.WriteAsync("Middleware1 ");
            });
            app.Run (async context => {
                await context.Response.WriteAsync("Middleware2");
            });

            #endregion Middleware Run

            #region Middleware Map

            app.Map("/HandleSample1",app=> {
                app.Run(async context => {
                    await context.Response.WriteAsync("Handle Sample1 working");
                });
            });

            app.Map("/HandleSample2", HandleSample2);

            app.Run(async context => {
                await context.Response.WriteAsync("Finished request Chain");
            });
            #endregion  Middleware Map


            app.Map("/HandleSample1", app => {

                app.Use(async ( context,next)=> {
                    await context.Response.WriteAsync("Middleware start");
                    await next.Invoke();
                    await context.Response.WriteAsync("Middleware end");
                });

                app.Run(async context=> {
                    await context.Response.WriteAsync("Handle Sample 1 working ");
                });
            });

            app.Map("/HandleSample2",HandleSample2);
            app.Run(async context => {

                await context.Response.WriteAsync("Finished request chained");
            });

            /* 

              app.UseEndpoints(endpoints =>
             {
                 endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                 });
             });
             */
        }
        private static void HandleSample2(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async context => {
                await context.Response.WriteAsync("HandleSample2 working");
            });
        }
    }
}
