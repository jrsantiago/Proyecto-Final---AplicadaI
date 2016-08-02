using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public partial class FabricarScreen
    {
        [Key]
        public int id { get; set; }

        public Nullable<int> idScreen { get; set; }
        public Nullable<double> MorduraScreemPie { get; set; }
        public Nullable<int> orejitas { get; set; }
        public Nullable<int> Lscreem { get; set; }
        public Nullable<double> sogaLibra { get; set; }
        public Nullable<double> yardasTela { get; set; }
        public Nullable<int> tornillos { get; set; }
        public Nullable<double> Precio { get; set; }
        public Nullable<double> precioPieCuadrado { get; set; }

       
        public virtual Screens Screen { get; set; }
    }
}
