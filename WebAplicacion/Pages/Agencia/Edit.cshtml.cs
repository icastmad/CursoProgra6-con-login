using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebAplicacion.Pages.Agencia
{
    public class EditModel : PageModel
    {
        private readonly IAgenciaService agenciaService;
        private readonly ICatalogoProvinciaService catalogoProvinciaService;
        private readonly ICatalogoCantonService catalogoCantonService;
        private readonly ICatalogoDistritoService catalogoDistritoService;



        public EditModel(IAgenciaService agenciaService, ICatalogoProvinciaService catalogoProvinciaService, ICatalogoCantonService catalogoCantonService, ICatalogoDistritoService catalogoDistritoService)
        {
            this.agenciaService = agenciaService;
            this.catalogoProvinciaService = catalogoProvinciaService;
            this.catalogoCantonService = catalogoCantonService;
            this.catalogoDistritoService = catalogoDistritoService;

        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        [BindProperty]
        [FromBody]
        public AgenciaEntity Entity { get; set; } = new AgenciaEntity();

        public IEnumerable<CatalogoProvinciaEntity> ProvinciaLista { get; set; } = new List<CatalogoProvinciaEntity>();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await agenciaService.GetById(new() { AgenciaId = id });
                }

                ProvinciaLista = await catalogoProvinciaService.GetLista();

                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnPost()
        {
            try
            {

                var result = new DBEntity();
                if (Entity.AgenciaId.HasValue)
                {
                    //Actualizar
                    result = await agenciaService.Update(Entity);


                }
                else
                {
                    //Nuevo
                    result = await agenciaService.Create(Entity);


                }

                return new JsonResult(result);


            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }

        }

        public async Task<IActionResult> OnPostChangeProvincia()
        {
            try
            {
                var result = await catalogoCantonService.GetLista(
                    
                    new CatalogoProvinciaEntity { IdCatalogoProvincia=Entity.IdCatalogoProvincia}

                    );
                return new JsonResult(result);

            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }

        public async Task<IActionResult> OnPostChangeCanton()
        {
            try
            {
                var result = await catalogoDistritoService.GetLista(

                    new CatalogoCantonEntity { IdCatalogoCanton = Entity.IdCatalogoCanton }

                    );
                return new JsonResult(result);

            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }

    }
}
