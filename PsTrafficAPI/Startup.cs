using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace PsTrafficAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*
             Swagger Gen is a component that knows how to look at the application model from the dotnet core metadata of the project and produce the document that describes the API
             */
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("course-v1", new Swashbuckle.AspNetCore.Swagger.Info {
                    Title = "Azure cloud course",
                    Version = "1.0.0"
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            /*
             * middleware by default listens to a request /swagger/[document name which we mention in the service]/swagger.json
             */
            app.UseSwagger();
            /*
             Swagger UI provides a interface that is based on the document we mentioned which is course-v1. By default the Swagger UI will listen to the endpoint with /swagger
             */
            app.UseSwaggerUI(options=> {
                options.SwaggerEndpoint("/swagger/course-v1/swagger.json","Azure cloud course");
            });

        }
    }
}
