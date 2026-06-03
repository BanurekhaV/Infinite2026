namespace NetCore_FirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();


           // //2. To get the hosting Server Name
           //    app.MapGet("/",() => "Worker Process Name : "+
           //    System.Diagnostics.Process.GetCurrentProcess().ProcessName);

           // //3. configuring a mapget to a resource under the root
           //   app.MapGet("/wishes", () => "Hello and Welcome from the root/wishes endpoint");
            
           ////4. map http get request to a route parameter
           //app.MapGet("/wishes/{name}",(string name) => $"Hello, {name}!");

            // 1. app.MapGet("/", () => "Hello World!");


            //calling inline request delegate method of the httpcontect object
            app.Use(async (context, next)=>
            {
                await context.Response.WriteAsync("First Middleware : Incoming Request");
                await next();
                await context.Response.WriteAsync("First Middleware : Outgoing Response");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("\n Second Middleware : Oncoming Request");
                await next();
                await context.Response.WriteAsync("Middleware second : Outgoing response");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\n Third Middleware : Incoming Request Handles and Response generated \n");
            });
            //app.Run(FirstMiddleWare);

            app.Run();
        }

        private static async Task FirstMiddleWare(HttpContext context)
        {
            await context.Response.WriteAsync("Geeting Response from the First MiddleWare Function");
        }
    }
}
