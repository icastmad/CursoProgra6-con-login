using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaVehiculoController : ControllerBase
    {

        private readonly IMarcaVehiculoService marcavehiculoService;

        public MarcaVehiculoController(IMarcaVehiculoService marcavehiculoService)
        {
            this.marcavehiculoService = marcavehiculoService;
        }


        [HttpGet("Lista")]
        public async Task<IEnumerable<MarcaVehiculoEntity>> GetLista()
        {
            try
            {
                return await marcavehiculoService.GetLista();
            }
            catch (Exception ex)
            {

                return new List<MarcaVehiculoEntity>();
            }
        }
    }
}
