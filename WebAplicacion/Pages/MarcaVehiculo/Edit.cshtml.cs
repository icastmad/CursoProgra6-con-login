using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebAplicacion.Pages.MarcaVehiculo
{
    public class EditModel : PageModel
    {
        private readonly IMarcaVehiculoService marcaVehiculoService;

        public EditModel(IMarcaVehiculoService marcaVehiculoService)
        {
            this.marcaVehiculoService = marcaVehiculoService;
        }

        [BindProperty(SupportsGet =true)]
        public int? id { get; set; }

        [BindProperty]
        [FromBody]
        public MarcaVehiculoEntity Entity { get; set; } = new MarcaVehiculoEntity();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await marcaVehiculoService.GetById( entity: new() { MarcaVehiculoId=id});
                }
                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var result = new DBEntity();
                if (Entity.MarcaVehiculoId.HasValue)
                {
                    //Actualizar
                   result = await marcaVehiculoService.Update(Entity);

                }
                else
                {
                    // Nuevo Registro
                   result = await marcaVehiculoService.Create(entity: Entity);

                }
                return new JsonResult(result);
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }
    }
}
