using crud_application_test.Data;
using Microsoft.EntityFrameworkCore;

public class Startup
{
    // ...

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        // Configure the database connection
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("UniversityConnectionString")));

        // Other services and configurations...
    }

    // ...
}
