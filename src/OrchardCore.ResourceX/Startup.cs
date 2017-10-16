using OrchardCore.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ResourceManagement;
using OrchardCore.Environment.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Reflection;

namespace OrchardCore.ResourceX
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IResourceManifestProvider, ResourceManifestX>();
        }
        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {            
            var extensionManager = app.ApplicationServices.GetRequiredService<IExtensionManager>();
            var env = app.ApplicationServices.GetRequiredService<IHostingEnvironment>();

            var extension = extensionManager.GetExtension(Assembly.GetExecutingAssembly().GetName().Name);
            var contentPath = Path.Combine(extension.ExtensionFileInfo.PhysicalPath, "Content");            

            if (Directory.Exists(contentPath))
            {
                var fileProvider = new PhysicalFileProvider(contentPath);
                app.UseStaticFiles(new StaticFileOptions()
                {
                    RequestPath = "/libs",
                    FileProvider = fileProvider
                });
            }
            
        }
    }
}
