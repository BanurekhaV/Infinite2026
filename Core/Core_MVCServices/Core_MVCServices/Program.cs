namespace Core_MVCServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Adding MVC Services to the container
            builder.Services.AddMvc();
         

           
            var app = builder.Build();

            //enable routing middleware to match the incoming request to endpoints defined
            app.UseRouting();

            //1. To map the default controller (convention, home/index)
            // app.MapDefaultControllerRoute();

            //2. 
            app.MapControllerRoute(
                name: "default", // name of the route
                pattern: "{controller=Home}/{action=Index}/{id?}"); // url pattern for the route

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
