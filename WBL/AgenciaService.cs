using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IAgenciaService
    {
        Task<DBEntity> Create(AgenciaEntity entity);
        Task<DBEntity> Delete(AgenciaEntity entity);
        Task<IEnumerable<AgenciaEntity>> Get();
        Task<AgenciaEntity> GetById(AgenciaEntity entity);
        Task<DBEntity> Update(AgenciaEntity entity);
        Task<IEnumerable<AgenciaEntity>> GetLista();
    }

    public class AgenciaService : IAgenciaService
    {
        private readonly IDataAccess sql;

        public AgenciaService(IDataAccess _sql)
        {
            sql = _sql;
        }


        public async Task<IEnumerable<AgenciaEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<AgenciaEntity,
                    CatalogoProvinciaEntity,
                    CatalogoCantonEntity,
                    CatalogoDistritoEntity
                    >("AgenciaObtener", "IdCatalogoProvincia,IdCatalogoCanton,IdCatalogoDistrito");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        public async Task<IEnumerable<AgenciaEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<AgenciaEntity>("AgenciaLista");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        public async Task<AgenciaEntity> GetById(AgenciaEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<AgenciaEntity>("AgenciaObtener", new
                {
                    entity.AgenciaId
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public async Task<DBEntity> Create(AgenciaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("AgenciaInsertar", new
                {
                    entity.Nombre,
                    entity.IdCatalogoProvincia,
                    entity.IdCatalogoCanton,
                    entity.IdCatalogoDistrito,
                    entity.Estado,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<DBEntity> Update(AgenciaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("AgenciaActualizar", new
                {
                    entity.AgenciaId,
                    entity.Nombre,
                    entity.IdCatalogoProvincia,
                    entity.IdCatalogoCanton,
                    entity.IdCatalogoDistrito,
                    entity.Estado,
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<DBEntity> Delete(AgenciaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("AgenciaEliminar", new
                {
                    entity.AgenciaId,
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
