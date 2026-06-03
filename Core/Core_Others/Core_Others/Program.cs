using Microsoft.Extensions.FileProviders;

namespace Core_Others
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //step 1 create an instance of the WebApplicationOptions class and set the property values
            //especially the webrootpath
            WebApplicationOptions options = new WebApplicationOptions()
            {
                WebRootPath ="MyWebRoot",
                Args= args,
                EnvironmentName ="Production",
            };
            var builder = WebApplication.CreateBuilder(options);
            var app = builder.Build();

            //app.MapGet("/", () => $"EnvironmentName : {app.Environment.EnvironmentName}\n" +
            //$"Applicationname :{app.Environment.ApplicationName}\n" +
            //$"WebRootPath :{app.Environment.WebRootPath}\n" +
            //$"ContentRootPath :{app.Environment.ContentRootPath}");           

            //if we wanted to make the custom.html as the initial page, then we need to set the defaultfilesoptions
            //DefaultFilesOptions defopts = new DefaultFilesOptions();

            //clear any other default filenames if exists
            //defopts.DefaultFileNames.Clear();

            //add the required html file 
            //defopts.DefaultFileNames.Add("MyCustom.html");

            //now apply the changes
            //  app.UseDefaultFiles(defopts);
            // Using FileServer Middleware to take care of DefaultPage, Directory Browsing and static files
            var fileserveroption = new FileServerOptions()
            {
                EnableDirectoryBrowsing = true,
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyWebRoot"))
            };

            //clear the default file names to prevent showing the default page
            fileserveroption.DefaultFilesOptions.DefaultFileNames.Clear();

            app.UseFileServer(fileserveroption);
           // app.UseDirectoryBrowser();
           // app.UseStaticFiles();
            //the below run() will start the application
            app.Run();
        }
    }
}
