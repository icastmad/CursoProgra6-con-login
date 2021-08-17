using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using WBL;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesServices clientesServices;

        public ClientesController(IClientesServices clientesServices)
        {
            this.clientesServices = clientesServices;
        }

        [HttpGet]
        public async Task<IEnumerable<ClientesEntity>> Get()
        {
            try
            {
                return await clientesServices.Get();
            }
            catch (Exception ex)
            {

                return new List<ClientesEntity>();
            }


        }

        [HttpGet("{id}")]
        public async Task<ClientesEntity> GetById(int id)
        {
            try
            {
                return await clientesServices.GetById(new ClientesEntity { ClientesId = id });
            }
            catch (Exception ex)
            {

                return new ClientesEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPost]
        public async Task<DBEntity> Create(ClientesEntity entity)
        {
            try
            {
                return await clientesServices.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPut]
        public async Task<DBEntity> Update(ClientesEntity entity)
        {
            try
            {
                return await clientesServices.Update(entity);
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
                return await clientesServices.Delete(new ClientesEntity { ClientesId = id });
            }
            catch (Exception ex)
            {

                return new ClientesEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }

        }
    }
}
