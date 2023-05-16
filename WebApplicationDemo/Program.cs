using static System.Net.Mime.MediaTypeNames;

namespace WebApplicationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
             
            app.UseStaticFiles();
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello1");
                await next();
                await context.Response.WriteAsync("Hello2");

            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<html><body>");
                await context.Response.WriteAsync("<div>Inside middleware defined using app.Use</div>");
                await next();
                await context.Response.WriteAsync("</body></html>");
            });

            app.Map("/n", a1 =>
            {
                a1.Run(c => c.Response.WriteAsync("aaaa"));
                });
                   


               
            
            //app.Map("/n", a1 =>
            //{
            //    a1.Use(async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("aaaa");
            //        await next();


            //    });
            //});
            app.Map("/newbranch", a => {
                a.Map("/branch1", brancha => brancha
                    .Run(c => c.Response.WriteAsync("Running from the newbranch/branch1 branch!")));
                a.Map("/branch2", brancha => brancha
                    .Run(c => c.Response.WriteAsync("Running from the newbranch/branch2 branch!")));

                a.Run(c => c.Response.WriteAsync("Running from the newbranch branch!"));
            });


            //app.Run(c => c.Response.WriteAsync("Hello 1"));
            //app.Run(c => c.Response.WriteAsync("Hello 2"));
            app.Map("/maptest", HandleMapTest);
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
        private static void HandleMapTest(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test Successful");
            });
        }

        

        private static void HandleBranch(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Condition is fulfilled");
            });
        }

    }
}