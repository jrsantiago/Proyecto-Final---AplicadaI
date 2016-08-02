using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public class Proyecto
    {
        public Proyecto()
        {
            // this.Ventana = new List<Entidad.ventanaAluminio>();
            //   this.Screens = new List<Entidad.Screens>();
            // this.Clientes = new List<Entidad.Cliente>();
            this.Ventana = new List<Entidad.ventanaAluminio>();
        }
        [Key]
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idAlumi { get; set; }
        public string detalle { get; set; }


        public virtual Cliente Cliente { get; set; }
        //public virtual Screens Screen { get; set; }
       public virtual ventanaAluminio ventanaAluminio { get; set; }
        // public virtual List<Entidad.Screens> Screens { get; set; }
       public virtual List<Entidad.ventanaAluminio> Ventana { get; set; }
      //  public virtual List <Entidad.Cliente>Clientes { get; set; }
    }
}
