using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserCenter.IService;
using UserCenter.OpenApi.Filter;
using UserCenter.Service.Service;

namespace UserCenter.OpenApi
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
            services.AddCors(option => 
            {
                option.AddPolicy("any", builder => {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
                });
            });
            services.AddMvc(option => {
                option.Filters.Add(typeof(UCAuthorizationFilter));
                option.Filters.Add(typeof(UCExceptionFilter));
            });
            //services.AddScoped<IAuthorizationFilter, UCAuthorizationFilter>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAppInfoService, AppInfoService>();
            services.AddScoped<IGroupService, GroupService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes=> {
                routes.MapRoute(
                    name:"Default",
                    template: "Api/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
