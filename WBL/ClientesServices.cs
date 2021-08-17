using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BD;


namespace WBL
{
    public interface IClientesServices
    {
        Task<DBEntity> Create(ClientesEntity entity);
        Task<DBEntity> Delete(ClientesEntity entity);
        Task<IEnumerable<ClientesEntity>> Get();
        Task<ClientesEntity> GetById(ClientesEntity entity);
        Task<DBEntity> Update(ClientesEntity entity);
    }

    public class ClientesServices : IClientesServices
    {
        private readonly IDataAccess sql;
        public ClientesServices(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<ClientesEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ClientesEntity, AgenciaEntity>("ClientesObtener", "ClientesId, AgenciaId");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public async Task<ClientesEntity> GetById(ClientesEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ClientesEntity>("ClientesObtener", new
                {

                    entity.ClientesId

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public async Task<DBEntity> Create(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ClientesInsertar", new
                {

                    entity.NombreCompleto,
                    entity.Direccion,
                    entity.Telefono,
                    entity.AgenciaId,
                    entity.Estado,


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Update(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ClientesActualizar", new
                {
                    entity.ClientesId,
                    entity.NombreCompleto,
                    entity.Direccion,
                    entity.Telefono,
                    entity.AgenciaId,
                    entity.Estado,


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Delete(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ClientesEliminar", new
                {
                    entity.ClientesId,


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }

}


