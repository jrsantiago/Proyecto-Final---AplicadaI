using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public partial class Materiales
    {
        [Key]
        public int idMateriale { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> unidad { get; set; }
        public Nullable<double> CantidadPie { get; set; }
        public Nullable<double> precio { get; set; }
    }
}

