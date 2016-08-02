using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using BLL;
using Entidad;
using System.Windows.Forms;

namespace BLL
{
  public class MaterialesBll
    {
        public MaterialesBll()
        {

        }
        VentanaGzDb db = new VentanaGzDb();
        public static bool Insertar(Materiales materiales)
        {
            bool retorno = false;
            try
            {

                    
                    using (var dbs = new VentanaGzDb())
                    {
                        dbs.Materiales.Add(materiales);
                        dbs.SaveChanges();
                        MessageBox.Show("Material Registrado");

                    }
                    retorno = true;
                


            }
            catch (Exception)
            {

                MessageBox.Show("Inserte Todos Los Campos");

                //throw ex;
            }

            return retorno;
        }
        public static Materiales Buscar(int id)
        {

            var db = new VentanaGzDb();

            return db.Materiales.Find(id);


        }
        public void Actualizar(int id,string descripcio,int unidad,float CantidadPie, float precio)
        {
            try
            {
                Materiales mate = (from a in db.Materiales
                                   where a.idMateriale == id
                                   select a).FirstOrDefault();

                mate.Descripcion = descripcio;
                mate.Descripcion = descripcio;
                mate.unidad = unidad;
                mate.CantidadPie = CantidadPie;
                mate.precio = precio;

                db.SaveChanges();
                MessageBox.Show("Se ha actualizdo");
            }
            catch (Exception) { MessageBox.Show("Introdusca El Id"); }
        }
        public void Eliminar(int id)
        {
            try
            {
                Materiales mate = (from a in db.Materiales
                                   where a.idMateriale == id
                                   select a).FirstOrDefault();


                db.Materiales.Remove(mate);
                db.SaveChanges();
                MessageBox.Show("Material Eliminado");
            }
            catch (Exception) { MessageBox.Show("Introdusca el Id"); }
        }
     }
 
   }

