using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AgenciaEntity:EN
    {
        public AgenciaEntity()
        {
            Provincia = Provincia ?? new CatalogoProvinciaEntity();
            Canton = Canton ?? new CatalogoCantonEntity();
            Distrito = Distrito ?? new CatalogoDistritoEntity();
        }



        public int? AgenciaId { get; set; }
        public string Nombre { get; set; }
        public int? IdCatalogoProvincia { get; set; }
        public CatalogoProvinciaEntity Provincia { get; set; }
        public int? IdCatalogoCanton { get; set; }
        public CatalogoCantonEntity Canton { get; set; }
        public int? IdCatalogoDistrito { get; set; }
        public CatalogoDistritoEntity Distrito { get; set; }
    }
}
