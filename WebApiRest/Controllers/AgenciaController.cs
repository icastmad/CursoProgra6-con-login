using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciaController : ControllerBase
    {

        private readonly IAgenciaService agenciaService;

        public AgenciaController(IAgenciaService agenciaService)
        {
            this.agenciaService = agenciaService;
        }


        [HttpGet("Lista")]
        public async Task<IEnumerable<AgenciaEntity>> GetLista()
        {
            try
            {
                return await agenciaService.GetLista();
            }
            catch (Exception ex)
            {

                return new List<AgenciaEntity>();
            }
        }
    }
}
