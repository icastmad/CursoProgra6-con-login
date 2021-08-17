using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebAplicacion.Pages
{
    public class GridModel : PageModel
    {
        private readonly IAgenciaService agenciaService;

        public GridModel(IAgenciaService agenciaService)
        {
            this.agenciaService = agenciaService;
        }

        public IEnumerable<AgenciaEntity> GridList { get; set; } = new List<AgenciaEntity>();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (this.SessionOnline()) return RedirectToPage("../Login");
                GridList = await agenciaService.Get();


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
                var result = await agenciaService.Delete(new()
                {
                    AgenciaId = id
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

