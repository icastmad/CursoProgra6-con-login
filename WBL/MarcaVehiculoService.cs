using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IMarcaVehiculoService
    {
        Task<DBEntity> Create(MarcaVehiculoEntity entity);
        Task<DBEntity> Delete(MarcaVehiculoEntity entity);
        Task<IEnumerable<MarcaVehiculoEntity>> Get();
        Task<IEnumerable<MarcaVehiculoEntity>> GetLista();
        Task<MarcaVehiculoEntity> GetById(MarcaVehiculoEntity entity);
        Task<DBEntity> Update(MarcaVehiculoEntity entity);
    }

    public class MarcaVehiculoService : IMarcaVehiculoService
    {
        private readonly IDataAccess sql;

        public MarcaVehiculoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<MarcaVehiculoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<MarcaVehiculoEntity>(sp: "MarcaVehiculoObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<MarcaVehiculoEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<MarcaVehiculoEntity>(sp: "MarcaVehiculoLista");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<MarcaVehiculoEntity> GetById(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<MarcaVehiculoEntity>(sp: "MarcaVehiculoObtener", Param: new { entity.MarcaVehiculoId });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Create(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync(sp: "MarcaVehiculoInsertar", Param: new { entity.Descripcion, entity.Estado });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Update(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync(sp: "MarcaVehiculoActualizar", Param: new { entity.MarcaVehiculoId, entity.Descripcion, entity.Estado });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Delete(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync(sp: "MarcaVehiculoEliminar", Param: new { entity.MarcaVehiculoId });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
