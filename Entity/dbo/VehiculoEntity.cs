using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VehiculoEntity : EN
    {
        public VehiculoEntity()
        {
            MarcaVehiculo = MarcaVehiculo ?? new MarcaVehiculoEntity();
        }

        public int? VehiculoId { get; set; }

        public int? MarcaVehiculoId { get; set; }

        public virtual MarcaVehiculoEntity MarcaVehiculo { get; set; }

        public string Matricula { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }

        public DateTime FechaModelo { get; set; } = DateTime.Now;

        public bool TieneDefectos { get; set; }

        public string Defectos { get; set; }
    }
}
