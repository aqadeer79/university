//using crud_application_test.Data;
//using Microsoft.EntityFrameworkCore;
//using Infrastructure.ServiceDiscovery;

//public class Startup
//{
//    // ...

//    public Startup(IConfiguration configuration)
//    {
//        Configuration = configuration;
//    }

//    public IConfiguration Configuration { get; }

//    public void ConfigureServices(IServiceCollection services, IConfigurationBuilder configuration)
//    {
//        // Configure the database connection
//        services.AddDbContext<ApplicationDbContext>(options =>
//            options.UseSqlServer(Configuration.GetConnectionString("UniversityConnectionString")));
//        ConfigureConsul(services);
//    }

//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//    {
//        app.UseRouting();
//        app.UseEndpoints(endpoints =>
//        {
//            endpoints.MapControllers();
//        });
     
//    }

//    private void ConfigureConsul(IServiceCollection services)
//    {
//        var serviceConfig = Configuration.GetServiceConfig();

//        services.RegisterConsulServices(serviceConfig);
//    }
//    // ...
//}
