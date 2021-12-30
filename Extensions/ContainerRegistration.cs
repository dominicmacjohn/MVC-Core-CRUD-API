using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MVC_Core_CRUD_API.Repositories;

namespace MVC_Core_CRUD_API.Extensions
{
    public static class ContainerRegistration
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IItemRepository, ItemRepository>();
        }
    }
}
