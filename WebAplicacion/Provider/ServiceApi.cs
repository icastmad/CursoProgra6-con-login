using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAplicacion
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client, HttpClient vehiculo)
        {
            this.client = client;

        }

        #region Clientes
        public async Task<IEnumerable<ClientesEntity>> ClientesGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Clientes");

            return result;

        }

        public async Task<ClientesEntity> ClientesGetById(int id)
        {
            var result = await client.ServicioGetAsync<ClientesEntity>("api/Clientes/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        public async Task<IEnumerable<AgenciaEntity>> AgenciaGetLista()
        {
            var result = await client.ServicioGetAsync < IEnumerable<AgenciaEntity >> ("api/Agencia/Lista");

            return result;

        }

        #endregion

       #region Vehiculo
        public async Task<IEnumerable<VehiculoEntity>> VehiculoGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<VehiculoEntity>>("api/Vehiculo");

            return result;

        }

        public async Task<VehiculoEntity> VehiculoGetById(int id)
        {
            var result = await client.ServicioGetAsync<VehiculoEntity>("api/Vehiculo/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        public async Task<IEnumerable<MarcaVehiculoEntity>> MarcaVehiculoGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<MarcaVehiculoEntity>>("api/MarcaVehiculo/Lista");

            return result;

        }

        #endregion

        #region Usuarios

        public async Task<UsuariosEntity> UsuarioLogin(UsuariosEntity entity)
        {
            var result = await client.ServicioPostAsync<UsuariosEntity>("api/Usuarios/Login", entity);

            return result;

        }
        #endregion
    }
}
