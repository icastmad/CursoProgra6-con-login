using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;

namespace WebApiRest
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {
            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<IUsuariosService, UsuariosService>();
            services.AddTransient<IClientesServices, ClientesServices>();
            services.AddTransient<IAgenciaService, AgenciaService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            services.AddTransient<IMarcaVehiculoService, MarcaVehiculoService>();



            return services;
        }
    }
}
