using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            // this.FabricarVentanaAluminio = new HashSet<FabricarVentanaAluminio>();
            //  this.Proyecto = new HashSet<Proyecto>();
            this.cliente = new HashSet<Cliente>();
        }
            [Key]

        public int idAlumi { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<double> ancho { get; set; }
        public Nullable<double> altura { get; set; }
        public string tipoMaterial { get; set; }
        public string color { get; set; }
        public Nullable <double> precio { get; set; }

        public Nullable<System.DateTime> fecha { get; set; }

        public string Detail { get; set; }

        [Browsable(false)]
        public virtual ICollection<Cliente> cliente { get; set; }
        public ventanaAluminio(int id , float ancho, float altura )
        {
            this.idAlumi = 1;
            this.ancho = ancho;
            this.altura = altura;
            this.cliente = new HashSet<Cliente>();

        }
       

     //   public Nullable <double> Total{ get; set; }
        //public virtual Cliente Cliente { get; set; }

        // public virtual ICollection<FabricarVentanaAluminio> FabricarVentanaAluminio { get; set; }
        // public virtual ICollection<Proyecto> Proyecto { get; set; }

    }
}
