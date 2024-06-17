using Microsoft.EntityFrameworkCore;
using Products.Infrastructure;

namespace Products.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            //builder.Services.AddAutoMapper(Assemblies.InfrastructureAssembly);
            builder.Services.AddDbContext<ProductDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("ProductDbConn")));
            //builder.Services.AddScoped<IReadUnitOfWork, ReadUnitOfWork>();
            //builder.Services.AddScoped<IWriteUnitOfWork, WriteUnitOfWork>();
            return builder.Services;
        }
    }
}
