using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;


namespace P0004.Construction
{
    class Program
    {
        static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            //builder.Services.AddRazorPages();
            builder.Services.AddRazorPages(razorPagesOptions =>
            {
                // Works. But NOTHING OTHER THAN THIS WORKS!
                razorPagesOptions.RootDirectory = "/Routes/Pages";
                //razorPagesOptions.Conventions.AddFolderRouteModelConvention("/Routes/Pages", model => {

                //});
            });
            //builder.Services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    options.PageViewLocationFormats.Add("/Routes/Pages/{0}.cshtml");
            //});
            //builder.Services.AddRazorPages().AddRazorOptions(options =>
            //{
            //    //options.ViewLocationFormats.Add("/Routes/Pages/{0}.cshtml");
            //    //options.PageViewLocationFormats.Add("/Routes/Pages/{0}.cshtml");
            //    options.PageViewLocationFormats.Clear();
            //    options.PageViewLocationFormats.Add("/Routes/Pages/{0}.cshtml");
            //});
            //builder.Services.AddRazorPages().AddMvcOptions.AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.
            //});
            //builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.AddFolderRouteModelConvention("/Routes/Pages", model =>
            //    {
            //        Console.WriteLine();
            //    });
            //});

            var app = builder.Build();

            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
