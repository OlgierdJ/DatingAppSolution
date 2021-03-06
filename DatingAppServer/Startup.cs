using DatingAppLibrary.Interfaces;
using DatingAppServer.DataAccess;
using DatingAppServer.DBConnection;
using DatingAppServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace DatingAppServer
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
            services.AddDbContext<DBDataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                );
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProfileRepository, ProfileRepository>();
            //services.AddTransient<IProfileRepository, ProfileRepository>();
            //services.AddTransient<IPreferenceRepository, PreferenceRepository>();
            //services.AddTransient<ISexualPreferenceRepository, SexualPreferenceRepository>();
            //services.AddTransient<ILikeRepository, LikeRepository>();
            //services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProfileService, ProfileService>();
            services.AddControllers().AddJsonOptions(options=> 
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                //options.JsonSerializerOptions.WriteIndented = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            var dbDataContext = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var serviceScope = dbDataContext.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<DBDataContext>();
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
