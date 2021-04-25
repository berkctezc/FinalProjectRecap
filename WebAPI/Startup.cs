using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebAPI
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
            services.AddControllers();
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //private static void SingletonTest(IServiceCollection services)
        //{
        //    services.AddSingleton<ICarService, CarManager>();
        //    services.AddSingleton<ICarDal, EfCarDal>();
        //    services.AddSingleton<IBrandService, BrandManager>();
        //    services.AddSingleton<IBrandDal, EfBrandDal>();
        //    services.AddSingleton<IColorService, ColorManager>();
        //    services.AddSingleton<IColorDal, EfColorDal>();
        //    services.AddSingleton<ICustomerService, CustomerManager>();
        //    services.AddSingleton<ICustomerDal, EfCustomerDal>();
        //    services.AddSingleton<IRentalService, RentalManager>();
        //    services.AddSingleton<IRentalDal, EfRentalDal>();
        //    services.AddSingleton<IUserService, UserManager>();
        //    services.AddSingleton<IUserDal, EfUserDal>();
        //}
    }
}