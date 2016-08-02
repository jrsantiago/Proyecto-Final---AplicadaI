using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public partial class Screens
    {
        public Screens()
        {
            this.FabricarScreen = new HashSet<FabricarScreen>();
            this.Proyecto = new HashSet<Proyecto>();
        }
        [Key]
        public int idScreen { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<double> ancho { get; set; }
        public Nullable<double> altura { get; set; }
        public Nullable<double> Precio { get; set; }
     // public Nullable<double> Total { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<FabricarScreen> FabricarScreen { get; set; }
        public virtual ICollection<Proyecto> Proyecto { get; set; }

    }
}
