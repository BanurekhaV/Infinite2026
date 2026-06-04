namespace ExceptionMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //to show the hosting servers information

            //getting generic value from the congiguration
           // string? getVal = builder.Configuration.GetValue<string>("MyCustomKey", "DefaultValue");

            //get the configuration value using the indexer
            string? getval1 = builder.Configuration["MyCustomKey"];

            app.MapGet("/", () => $"{getval1}");

            //app.MapGet("/",() => "Worker process Name : " + 
            //System.Diagnostics.Process.GetCurrentProcess().ProcessName);

            //app.MapGet("/", async context =>
            //{
            //    int Number1 = 10, Number2 = 0;
            //    int Result = Number1 / Number2;
            //    await context.Response.WriteAsync($"Result : {Result}");
            //});

           app.Run();
        }
    }
}
