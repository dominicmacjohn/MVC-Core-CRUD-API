using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_Core_CRUD_API.Data;

namespace MVC_Core_CRUD_API.Extensions
{
    public static class DatabaseRegistration
    {

        public static void RegisterInMemoryDatabase(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseInMemoryDatabase("InMem"));
        }
    }
}