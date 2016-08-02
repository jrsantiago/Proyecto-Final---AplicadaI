using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public partial class FabricarVentanaAluminio
    {
        [Key]
        public int id { get; set; }
        public Nullable<int> idVentana { get; set; }
        public Nullable<double> balancin { get; set; }
        public Nullable<int> operadores { get; set; }
        public Nullable<int> masilla { get; set; }
        public Nullable<double> pieCabezal { get; set; }
        public Nullable<double> pieAlfecia { get; set; }
        public Nullable<double> pieJamba { get; set; }
        public Nullable<double> pieCelocia { get; set; }
        public Nullable<int> tornillosUna { get; set; }
        public Nullable<int> tornillosMedia { get; set; }
        public Nullable<int> tarugos { get; set; }
        public Nullable<int> fundaRemaches { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<double> precioPieCuadrado { get; set; }
        public virtual ventanaAluminio ventanaAluminio { get; set; }
    }
}
