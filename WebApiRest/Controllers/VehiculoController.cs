using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using WBL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService vehiculoService;

        public VehiculoController(IVehiculoService vehiculoService)
        {
            this.vehiculoService = vehiculoService;
        }

        [HttpGet]
        public async Task<IEnumerable<VehiculoEntity>> Get()
        {
            try
            {
                return await vehiculoService.Get();
            }
            catch (Exception ex)
            {

                return new List<VehiculoEntity>();
            }


        }

        [HttpGet("{id}")]
        public async Task<VehiculoEntity> GetById(int id)
        {
            try
            {
                return await vehiculoService.GetById(new VehiculoEntity { VehiculoId = id });
            }
            catch (Exception ex)
            {

                return new VehiculoEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPost]
        public async Task<DBEntity> Create(VehiculoEntity entity)
        {
            try
            {
                return await vehiculoService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPut]
        public async Task<DBEntity> Update(VehiculoEntity entity)
        {
            try
            {
                return await vehiculoService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await vehiculoService.Delete(new VehiculoEntity { VehiculoId = id });
            }
            catch (Exception ex)
            {

                return new VehiculoEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }

        }
    }
}
