using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebAplicacion.Pages.MarcaVehiculo
{
    public class GridModel : PageModel
    {
        private readonly IMarcaVehiculoService marcaVehiculoService;

        public GridModel(IMarcaVehiculoService marcaVehiculoService)
        {
            this.marcaVehiculoService = marcaVehiculoService;
        }

        public IEnumerable<MarcaVehiculoEntity> GridList { get; set; } = new List<MarcaVehiculoEntity>();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await marcaVehiculoService.Get();
                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<JsonResult> OnDeleteEliminar(int id)
        {
            try
            {
                var result = await marcaVehiculoService.Delete(entity: new()
                {

                    MarcaVehiculoId = id
                });

                return new JsonResult(result);

            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }
    }
}
