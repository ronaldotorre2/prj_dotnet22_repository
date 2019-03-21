using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGC.Domain.Interfaces;
using SGC.Infra.Database;
using SGC.Infra.Repositories;

namespace sgc.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["ConnectionStrings:ConnectionMSSql"];
            services.AddDbContext<SGCDataContext>(opt => opt.UseSqlServer(connection));
            
            services.AddCors();
            services.AddMvc();

            services.AddResponseCompression();

            services.AddScoped<SGCDataContext, SGCDataContext>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseResponseCompression();
        }
    }
}