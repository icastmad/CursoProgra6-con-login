using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IVehiculoService
    {
        Task<DBEntity> Create(VehiculoEntity entity);
        Task<DBEntity> Delete(VehiculoEntity entity);
        Task<IEnumerable<VehiculoEntity>> Get();
        Task<VehiculoEntity> GetById(VehiculoEntity entity);
        Task<DBEntity> Update(VehiculoEntity entity);
    }

    public class VehiculoService : IVehiculoService
    {
        private readonly IDataAccess sql;

        public VehiculoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<VehiculoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<VehiculoEntity,MarcaVehiculoEntity>("VehiculoObtener", "VehiculoId, MarcaVehiculoId");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<VehiculoEntity> GetById(VehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<VehiculoEntity>(sp: "VehiculoObtener", Param: new { entity.VehiculoId });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Create(VehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync(sp: "VehiculoInsertar", Param: new { entity.MarcaVehiculoId, entity.Matricula, entity.Color, entity.Modelo, entity.Estado, entity.FechaModelo, entity.TieneDefectos, entity.Defectos });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Update(VehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync(sp: "VehiculoActualizar", Param: new { entity.VehiculoId, entity.MarcaVehiculoId, entity.Matricula, entity.Color, entity.Modelo, entity.Estado, entity.FechaModelo, entity.TieneDefectos, entity.Defectos });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<DBEntity> Delete(VehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync(sp: "VehiculoEliminar", Param: new { entity.VehiculoId });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
