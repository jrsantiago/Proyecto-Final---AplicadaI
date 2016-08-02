using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Usuario
    {
        [Key]

        public int idUsuario { get; set; }
        public string contrasena { get; set; }
        public string userName { get; set; }
        public string nombre { get; set; }
        public string apellido  { get; set; }
        public string sexo { get; set; }
        public string  restriccion { get; set; }



    }
}
