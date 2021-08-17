using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebAplicacion.Pages.Cliente
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

        public ClientesEntity Entity { get; set; } = new ClientesEntity();

        public IEnumerable<AgenciaEntity> AgenciaLista { get; set; } = new List<AgenciaEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.ClientesGetById(id.Value);
                }

                AgenciaLista = await service.AgenciaGetLista();


                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}
