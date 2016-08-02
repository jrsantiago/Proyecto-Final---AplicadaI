using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentanaCorredisa
    {
        public VentanaCorredisa()
        {
            //this.FabricarVentanaCorredisa = new HashSet<FabricarVentanaCorredisa>();
        }
        [Key]
        public int idCorredi { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<double> ancho { get; set; }
        public Nullable<double> altura { get; set; }
        public string color { get; set; }
        public string tipoCristal { get; set; }
        public string TipoMaterial { get; set; }
        public Nullable<double> precioPieCuadrado { get; set; }

        public virtual Cliente Cliente { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<FabricarVentanaCorredisa> FabricarVentanaCorredisa { get; set; }
    }
}
