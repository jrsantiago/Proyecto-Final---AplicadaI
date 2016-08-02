using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using DALL;

namespace BLL
{
   public class ProyectoBll
    {
        public static List<Proyecto> GetListaProyecto(int id)
        {
            List<Proyecto> lista = new List<Proyecto>();

            var db = new VentanaGzDb();

            lista = db.Poyecto.Where(p => p.id == id && p.Ventana.Count > 0).ToList();

            return lista;

        }
    }
}
