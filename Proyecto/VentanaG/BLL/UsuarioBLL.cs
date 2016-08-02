using DALL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class UsuarioBLL
    {


        public string valida;
        public string usuario;
        public string contra;


        public string u;
        public string c;

        public string nombre;
        public string apellido;
        public string userName;
        public string sexo;
        public string contrasena;
        VentanaGzDb db = new VentanaGzDb();

        public UsuarioBLL()
        {
            valida = "";
            sexo = "";
            nombre = "";
            apellido = "";
            userName = "";
            this.contrasena = "";

            this.usuario = "";
            this.contra = "";
            u = "";
            c = "";

        }

        public Usuario llenar()
        {
            Usuario usuario = new Usuario();

            usuario.nombre = nombre;
            usuario.apellido = apellido;
            usuario.userName = userName;
            usuario.contrasena = contrasena;
            usuario.sexo = sexo;

            return usuario;

        }
        public static bool Insertar(Usuario usuario, string validar)
        {
            bool retorno = false;
            try
            {


                if (validar == "Nombre de Usuario Ya Existe" || validar == "Contraseña ya Existe" || validar == "Nombre de usuario y Contraseña ya Existen.!!")
                {
                    usuario = null;
                }
                else
                {
                    Usuario us = new Usuario();
                    us = usuario;
                    using (var dbs = new VentanaGzDb())
                    {
                        dbs.Usuario.Add(us);
                        dbs.SaveChanges();
                        MessageBox.Show("Usuario Creado");

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
        public static Usuario Buscar(int id)
        {

            var db = new VentanaGzDb();

            return db.Usuario.Find(id);




        }
        public VentanaGzDb GetLista(int id, string tipoComando)
        {
            var data = new VentanaGzDb();
            if (tipoComando == "Contraseña")
            {
                data.Usuario.Find(id);
            }
            return data;
        }
        public void Actualizar(int id, string nom, string apell, string userName, string contras, string sexo)
        {
            Usuario usuario = (from a in db.Usuario
                               where a.idUsuario == id
                               select a).FirstOrDefault();

            usuario.nombre = nom;
            usuario.apellido = apell;
            usuario.userName = userName;
            usuario.contrasena = contras;
            usuario.sexo = sexo;

            db.SaveChanges();
            MessageBox.Show(" Usuario Se ha Actualiado..!!");
        }
        public void eliminar(int id)
        {
            Usuario usu = (from a in db.Usuario
                           where a.idUsuario == id
                           select a).FirstOrDefault();
            db.Usuario.Remove(usu);
            db.SaveChanges();
            MessageBox.Show("Usuario Eliminado.!!");
        }
        public string Validar(string userName, string contra)
        {


            string user = "";
            string contr = "";

            try
            {

                using (VentanaGzDb db = new VentanaGzDb())
                {
                    user = db.Usuario.FirstOrDefault(x => x.userName == userName).userName.ToString();
                    contr = db.Usuario.FirstOrDefault(x => x.contrasena == contra).contrasena.ToString();
                }
                if (user != "")
                {
                    valida = "Nombre de Usuario Ya Existe";
                    MessageBox.Show("Nombre de Usuario Ya Existe");
                }
                else

                if (contr != "")
                {
                    valida = "Contraseña ya Existe";
                    MessageBox.Show("Contraseña ya Existe");

                }
                else

                if (user != "" && contr != "")
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
        public static bool log(string user, string contra)
        {
            string userName = "";
            string contrasena = "";
            string probar = "";
      
            bool valor = false;
            try
            {
                using (VentanaGzDb db = new VentanaGzDb())
                {
                    userName = db.Usuario.FirstOrDefault(x => x.userName == user).userName.ToString();
                    contrasena = db.Usuario.FirstOrDefault(x => x.contrasena == contra).contrasena.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Contraseña o Nombre de Usuario incorrectos");
                probar = "Contraseña o Nombre de Usuario incorrectos";
            }
      

            if (probar!= "Contraseña o Nombre de Usuario incorrectos")
            {
                valor = true;
            }

            return valor;
        }
    }
}
