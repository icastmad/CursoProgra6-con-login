using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebAplicacion.Pages.Vehiculo
{
    public class GridModel : PageModel
    {
        private readonly  ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }

        public IEnumerable<VehiculoEntity> GridList { get; set; } = new List<VehiculoEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await service.VehiculoGet();
                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
