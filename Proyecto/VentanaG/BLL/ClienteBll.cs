using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using DALL;
using System.Windows.Forms;

namespace BLL
{
   
    public class ClienteBll
    {
        public string valida;
        public ClienteBll()
        {
            valida = "";
        }

        VentanaGzDb db = new VentanaGzDb();
      
        public static bool Insertar(Cliente cliente, string validar)
        {
            bool retorno = false;
            try
            {


                if (validar == "Cedula Ya Existe" || validar == "Telefono ya Existe" || validar == "Nombre de usuario y Contraseña ya Existen.!!")
                {
                    cliente = null;
                }
                else
                {
                    Cliente clien = new Cliente();
                    clien = cliente;
                    using (var dbs = new VentanaGzDb())
                    {
                        dbs.Cliente.Add(clien);
                        dbs.SaveChanges();
                        MessageBox.Show("Cliente Creado");

                    }
                    retorno = true;
                }


        }
            catch (Exception)
            {

                MessageBox.Show("Inserte Todos Los Campos");

                //throw ex;
            }

            return retorno;
        }
        public static Cliente Buscar(int id)
        {

            var db = new VentanaGzDb();

            return db.Cliente.Find(id);




        }
     
        public void Actualizar(int ids,string nom, string telef, string cedula, string direcci, string email)
        {
            Cliente cliente = (from a in db.Cliente
                               where a.idCliente == ids
                               select a).FirstOrDefault();

            cliente.nombre = nom;
            cliente.telefono = telef;
            cliente.cedula = cedula;
            cliente.Direccion = direcci;
            cliente.Email = email;
             

            db.SaveChanges();
            MessageBox.Show(" Cliente Se ha Actualiado..!!");
        }
        public void eliminar(int id)
        {
           Cliente clien = (from a in db.Cliente
                           where a.idCliente == id
                           select a).FirstOrDefault();
            db.Cliente.Remove(clien);
            db.SaveChanges();
            MessageBox.Show("Cliente Eliminado.!!");
        }
        public string Validar(string ced, string telef)
        {


            string cedula = "";
            string telefono = "";

            try
            {

                using (VentanaGzDb db = new VentanaGzDb())
                {
                    cedula = db.Cliente.FirstOrDefault(x => x.cedula == ced).cedula.ToString();
                    telefono = db.Cliente.FirstOrDefault(x => x.telefono == telef).telefono.ToString();
                }
                if (ced != "")
                {
                    valida = "Cedula Ya Existe";
                    MessageBox.Show("Cedula Ya Existe");
                }
                else

                if (telefono != "")
                {
                    valida = "Telefono ya Existe";
                    MessageBox.Show("Telefono ya Existe");

                }else
                if (cedula != "" && telefono != "")
                {
                    valida = "Nombre de usuario y Contraseña ya Existen.!!";
                    MessageBox.Show("Nombre de usuario y Contraseña ya Existen.!!");

                }
                else
                {
                    valida = "validado";
                }


            }
            catch (Exception) { }

            return valida;
        }
        public static List<Cliente> GetListaCliente(int id)
        {
            List<Cliente> lista = new List<Cliente>();

            var db = new VentanaGzDb();

            lista = db.Cliente.Where(p => p.idCliente == id && p.VentanaAluminio.Count > 0).ToList();

            return lista;

        }
    }
}


