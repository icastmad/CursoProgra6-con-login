using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebAplicacion.Pages.Vehiculo
{
    public class EditModel : PageModel
    {
        private readonly ServiceApi service;


        public EditModel(ServiceApi service)
        {
            this.service = service;
        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public VehiculoEntity Entity { get; set; } = new VehiculoEntity();

        public IEnumerable<MarcaVehiculoEntity> MarcaVehiculoLista { get; set; } = new List<MarcaVehiculoEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.VehiculoGetById(id.Value);
                }

                MarcaVehiculoLista = await service.MarcaVehiculoGetLista();
                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

    }
}
