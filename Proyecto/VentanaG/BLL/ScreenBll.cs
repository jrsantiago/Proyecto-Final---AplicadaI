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
   
        public class screenBll
        {
            VentanaGzDb db = new VentanaGzDb();
            public bool permisoScreen;
            public int idScreen;
            public float ancho;  //Agregarlo en la Fabricar Screen
            public float altura; //Agregarlo en la tabla Fabricar Screen
            public int orejitas;
            public int Lscreen;
            public float sogaLibra; 
            public string Colores; //NOTA: HAY QUE INVESTIGAR ESTO
           public screenBll()
        {
            this.permisoScreen = false;
        }


            public screenBll(float Aancho, float Aaltura,int id,DateTime fecha)
           {
            try
            {
                float pre = precio(Aancho, Aaltura);
             

                Screens sc = new Screens()
                {
                    idCliente = id,
                    ancho = Aancho,
                    altura = Aaltura,
                    Precio = pre,
                    fecha = fecha
                    

                };
                db.Screens.Add(sc);
                db.SaveChanges();
                MessageBox.Show("Medidas Guardadas");
            }
            catch (Exception) { MessageBox.Show("Introduscar El Campo Correctamente");}
                idScreen = id;

               
                orejitas = 0;
                Lscreen = 4;
                sogaLibra = 1;

            }
            public float MorduraCreenPie()
            {
                float altura = this.altura;
                float ancho = this.ancho;

                float resultado1;
                float resultado2;
                float suma;
                if (ancho > 33)
                {
                    resultado1 = ancho / 12;
                    resultado2 = altura / 12;
                    suma = resultado1 + resultado2 * 2 + (resultado2); // esto es por el divisor cuando la Ventana es doble...
                    orejitas = 12;

                }
                else
                {
                    resultado1 = ancho / 12;
                    resultado2 = altura / 12;
                    suma = resultado1 + resultado2 * 2;
                    orejitas = 6;
                }
                return suma;
            } //Acordar que se compra la barra solamente de 16 o de 21, si son mas de una coviene 21...
            public float yardasTela()
            {
                float ancho = this.ancho;
                float resultado = 0;

                resultado = ancho;

                return resultado;
            }// mas luego cuando se valla a implementar los calculos si es solo una ventana y no pasa las 18 pulgadas se compra media yarda.
             //y si son mas de 2 se suman y se dividen entre 32
            public float yardas()
            {
                float altura = this.altura;
                float resultado = 0;
                if (altura > 0 && altura < 35)
                {
                    resultado = this.ancho * altura;
                }
                else if (altura > 36 && altura < 38)
                {
                    resultado = this.ancho * altura;
                }
                else if (altura > 37 && altura < 41)
                {
                    resultado = this.ancho * altura;
                }
                else if (altura > 42 && altura < 47)
                {
                    resultado = this.ancho * altura;
                }
                else if (altura > 48 && altura < 59)
                {
                    resultado = this.ancho * altura;
                }
                else if (altura > 60 && altura < 70)
                {
                    resultado = this.ancho * altura;
                }

                return resultado;
            }//esto son los estandares para los scrim en altura falta terminarlo talvez luego se implemente...
            public int tornillos()
            {
                int resultado = 0;
                if (this.ancho > 33)
                {
                    resultado = 12;
                }
                else
                {
                    resultado = 6;
                }
                this.orejitas = resultado;
                return resultado;
            }
            public void fabriScreen()
            {

            FabricarScreen fab = new FabricarScreen()
            {
                idScreen = this.idScreen,
                orejitas = this.orejitas,
                Lscreem = this.Lscreen,
                sogaLibra = this.sogaLibra,
                MorduraScreemPie = MorduraCreenPie(),
                yardasTela = yardasTela(),
                tornillos = tornillos(),
                Precio = precio(ancho,altura)
                    
                    
                };
                db.FabricarScreen.Add(fab);
                db.SaveChanges();
            }
            public float precio(float ancho,float altura)
            {
            float resultado = 0;
            resultado = ancho * altura / 144;
            return resultado * 80;

            }
     /*   public static List<Screens> GetLista(Dictionary<string, string> Cliente)
        {
            List<Screens> lista = new List<Screens>();
            Int32 _IdCliente = 0;
            string _CedulaCliente = string.Empty;
            DateTime _fecha = new DateTime();

            var db = new VentanaGzDb();

            if (Cliente.ContainsKey("Id"))
            {
                _IdCliente = Convert.ToInt32(Cliente["Id"]);
                lista = (from r in db.Screens where r.idCliente == _IdCliente select r).ToList();
            }

            if (Cliente.ContainsKey("Fecha"))
            {
                _fecha = Convert.ToDateTime(Cliente["Fecha"].ToString());
                lista = (from r in db.Screens where r.fecha >= _fecha select r).ToList();
            }


            //db.Screens.Find();
            // lista = (from r in db.Screens where r.idScreen == 1 select r).ToList();
            //db.Screens

            //lista = db.Screens.ToList();
            // db.Screens.Find(1).idScreen.ToString();
            // lista = db.Screens.Select(c => new { c.fecha, c.idCliente}.idCliente ==1).ToList();
            //lista.Contains(new Screens { idCliente = 1 });
            // lista =  lista.Find(x => x.idCliente.Equals(1));
            return lista;

        }*/

        public static List<Screens> GetLista (int id)
        {
            List<Screens> lista = new List<Screens>();

            var db = new VentanaGzDb();

             lista = db.Screens.Where(p=> p.idCliente==id).ToList();

            return lista;


        }
        public static int BuscarCampoCliente(string campo, string valor)
        {
            int id = 0;
            string nombre = "";
            try
            {

                if (campo == "Id")
                {
                    id = int.Parse(valor);
                    using (VentanaGzDb db = new VentanaGzDb())
                    {
                        id = db.Cliente.FirstOrDefault(x => x.idCliente == id).idCliente;
                        nombre = db.Cliente.FirstOrDefault(x => x.idCliente == id).nombre.ToString();
                    }
                }
                else
                    if (campo == "Nombre")
                {
                    using (VentanaGzDb db = new VentanaGzDb())
                    {
                        id = db.Cliente.FirstOrDefault(x => x.nombre == valor).idCliente;
                        nombre = db.Cliente.FirstOrDefault(x => x.idCliente == id).nombre.ToString();
                    }
                }
                else
                          if (campo == "Cedula")
                {
                    using (VentanaGzDb db = new VentanaGzDb())
                    {
                        id = db.Cliente.FirstOrDefault(x => x.cedula == valor).idCliente;
                        nombre = db.Cliente.FirstOrDefault(x => x.idCliente == id).nombre.ToString();

                    }
                }
            }
            catch (Exception) { MessageBox.Show("Campo Incorrecto"); }

            MessageBox.Show("Cliente :" + nombre + " Se a Encotrado");
            return id;
        }
        public void actualizar(float ancho, float altura, int idScreen)
        {
            try
            {
                Screens ven = (from a in db.Screens
                                       where a.idScreen == idScreen
                                       select a).FirstOrDefault();
                ven.ancho = ancho;
                ven.altura = altura;
            

                db.SaveChanges();
                MessageBox.Show("El registro se ha Actualizado..!!");
            }
            catch (Exception) { }


        }
        public void eliminar(int id)
        {
            try
            {
                Screens ven = (from a in db.Screens
                               where a.idScreen == id
                               select a).FirstOrDefault();
                db.Screens.Remove(ven);
                db.SaveChanges();
                MessageBox.Show("Regitro Eliminado.!!");
            }
            catch (Exception) { MessageBox.Show("Seleccione Un registro"); }

        }
    }

    }

