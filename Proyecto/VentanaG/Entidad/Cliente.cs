using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public partial class Cliente
    {
        // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
           //  this.Screen = new HashSet<Screens>();
          //  this.ventanaAluminio = new HashSet<ventanaAluminio>();

            this.VentanaAluminio = new List<Entidad.ventanaAluminio>();
        }         
           
         [Key]
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string cedula { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string  detalle { get; set; }

        public virtual List<Entidad.ventanaAluminio> VentanaAluminio { get; set; }


      //  public virtual ICollection<Screens> Screen { get; set; }
      //  public virtual ICollection<ventanaAluminio> ventanaAluminio { get; set; }
  
    }
}
