using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   
    public partial class ventanaAluminio
    {
        public ventanaAluminio()
        {
                this.FabricarVentanaAluminio = new HashSet<FabricarVentanaAluminio>();
            }
            [Key]

        public int idAlumi { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<double> ancho { get; set; }
        public Nullable<double> altura { get; set; }
        public string tipoMaterial { get; set; }
        public string color { get; set; }
        public Nullable <double> precio { get; set; }
     //   public Nullable <double> Total{ get; set; }
        public Nullable<System.DateTime> fecha { get; set; }

        public virtual Cliente Cliente { get; set; }
       
        public virtual ICollection<FabricarVentanaAluminio> FabricarVentanaAluminio { get; set; }
     }
    }
