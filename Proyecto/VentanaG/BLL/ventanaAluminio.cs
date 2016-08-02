using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ventanaAluminio
    { 
      public  ventanaAluminio()
        {
          // this.FabricarVentanaAluminio = new HashSet<FabricarVentanaAluminio>();
        }
    [Key]
    public int idAlumi { get; set; }
    public Nullable<int> idCliente { get; set; }
    public string tipoMaterial { get; set; }
    public string color { get; set; }
    public Nullable<double> ancho { get; set; }
    public Nullable<double> altura { get; set; }
    public string colores { get; set; }
    public Nullable<double> PrecioPieCuadrado { get; set; }

    public virtual Cliente Cliente { get; set; }
    // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //public virtual ICollection<FabricarVentanaAluminio> FabricarVentanaAluminio { get; set; }
 }
}
