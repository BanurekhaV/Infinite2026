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

            app.MapGet("/", async context =>
            {
                int Number1 = 10, Number2 = 0;
                int Result = Number1 / Number2;
                await context.Response.WriteAsync($"Result : {Result}");
            });

           app.Run();
        }
    }
}
