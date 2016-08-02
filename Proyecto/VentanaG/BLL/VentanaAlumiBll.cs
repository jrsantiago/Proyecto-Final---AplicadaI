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
   public class VentanaAlumiBll
    {
        public int idClien; //esto van en la tabla automaticanmenta identity

        public bool permisoValumi;
        public float precios;
        public float suma;

        public string Colores;
        public string tipoMaterial;
        public int hueco; //esto van en la tabla automaticanmenta identity
        public float cantidadCelocia; //esto sirve para saber cuantos remaches NO VA EN LA TABLA..!!!!
        public float ancho;
        public float altura;
        public float resultadoCabesal; // esto es para mas luego verificar si es doble la ventana NO VA EN LA TABLA....   
        public float balancin;
        public int operadores;
        public int fundaRemache;
        public int masilla;
        public int tarugos;

        VentanaGzDb db = new VentanaGzDb();
        public VentanaAlumiBll()
        {
            this.permisoValumi = false;

        }
        public VentanaAlumiBll(float Aancho, float Aaltura, string Acolor, string AtipoMat,int AidCliente,DateTime fech, string aDetail)
        {
           
          this.precios = precio(Aancho,Aaltura);
        

              idClien = AidCliente;
        
            try
            {
                ventanaAluminio ven = new ventanaAluminio()
                {

                    idCliente = AidCliente,
                    tipoMaterial = AtipoMat,
                    color = Acolor,
                    ancho = Aancho,
                    altura = Aaltura,
                    fecha = fech,
                    precio = precios,
                    Detail = aDetail,
                    //   Total = suma


                };
                db.ventanaAluminio.Add(ven);
                MessageBox.Show("Los Datos se han Guardado");
                db.SaveChanges();
            }
            catch (Exception) { MessageBox.Show("Campo Incorrecto Correctamente"); }
            this.ancho = Aancho;
            this.altura = Aaltura;
            this.Colores = Acolor;
            this.tipoMaterial = AtipoMat;

            resultadoCabesal = 0;
            cantidadCelocia = 0;
            balancin = 1; // se compra la barra y tiene 20 pie.....
            fundaRemache = 1;
            operadores = 0;
            masilla = 1;
            tarugos = 0;
        }

        public float pieCabezal()
        {
            float ancho = this.ancho;
            resultadoCabesal = ancho;
            return ancho / 12;

        }
        public float pieAlfesia()
        {
            float ancho = this.ancho;
            return ancho / 12;
        }
        public float PieJamba()
        {
            float altura = this.altura;
            float resultado = 0;

            if (resultadoCabesal >= 33)
            {
                resultado = altura * 4;
                operadores = 4;

            }
            else
            {
                resultado = altura * 2;
                operadores = 2;
            }
            this.balancin = resultado;
            return resultado / 12;
        }
        public float pieCelocia()
        {
            float aux = 0;

            if (resultadoCabesal >= 33)
            {
                aux = this.ancho / 4.5f; //4.5 Volumen de la jamba.....
                aux = aux / 2; //se divide en 2 porque supera las 33 pulgadas....
                aux += 3; //por el doble que se le hace a la celocia.......


                aux = this.altura / 3.5f;
                aux *= 2;

            }

            else
            {
                aux = this.ancho / 4.5f;
                aux += 3;

                aux = this.altura / 3.5f;
            }

            return aux / 12;

        }
        public int tornillosUna()
        {
            int tornillos = 0;
            if (resultadoCabesal >= 33)
            {
                tornillos = 8;
            }
            else tornillos = 4;

            this.tarugos = tornillos / 2;

            return tornillos;
        }
        public int tornillosMedia()
        {
            int tornillos = 0;
            if (this.ancho > 33)
            {
                tornillos = 16;
            }
            else tornillos = 8;

            return tornillos;
        }

        public float precio()
        {
            float resultado = 0;
            float pie = ancho * altura/144;
            if (tipoMaterial == "Doble A" && Colores == "Blanco")
            {
                resultado = pie * 200;
            }else 
            if (tipoMaterial == "Doble A" && Colores == "Negro")
            {
                resultado = pie * 220;
            }


            if (tipoMaterial == "Doble A Superior" && Colores == "Blanco")
            { 
                resultado = pie* 240;
            }else 
             if (tipoMaterial == "Doble A Superio" && Colores == "Negri")
               {
                resultado = pie * 260;
               }

                return resultado;
        }

        public static int BuscarCampoCliente(string campo,string valor)
        {int id = 0;
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

            MessageBox.Show("Cliente :"+nombre+" Se a Encotrado");
            return id;
        }
        public void actualizar(float ancho,float altura,string color,string tipoMaterial,int idAluminio)
        {
            try
            {
                ventanaAluminio ven = (from a in db.ventanaAluminio
                                       where a.idAlumi == idAluminio
                                       select a).FirstOrDefault();
                ven.ancho = ancho;
                ven.altura = altura;
                ven.color = color;
                ven.tipoMaterial = tipoMaterial;

                db.SaveChanges();
                MessageBox.Show("El registro se ha Actualizado..!!");
            }
            catch (Exception) { }
            

        }       
        public void fabriVentanaAluninio()
        {
            FabricarVentanaAluminio ven = new FabricarVentanaAluminio()
            {
                idVentana = idClien,
                precio = precio(),//sumar todo esto para que de el monto
                balancin = this.balancin,
                operadores = this.operadores,
                masilla = this.masilla,
                pieCabezal = pieCabezal(),
                pieAlfecia=pieAlfesia(),
                pieJamba = PieJamba(),
                pieCelocia = pieCelocia(),
                tornillosUna=tornillosUna(),
                tornillosMedia = tornillosMedia(),
                tarugos = this.tarugos,
                fundaRemaches = this.fundaRemache,

            };
            db.FabricarVentanaAluminio.Add(ven);
            db.SaveChanges();
        }
        public static bool Insertar(ventanaAluminio ventana, string validar)
        {
            bool retorno = false;
            try
            {


                if (validar == "Cedula Ya Existe" || validar == "Telefono ya Existe" || validar == "Nombre de usuario y Contraseña ya Existen.!!")
                {
                    ventana = null;
                }
                else
                {
                    ventanaAluminio ven = new ventanaAluminio();
                    ven = ventana;
                    using (var dbs = new VentanaGzDb())
                    {
                        dbs.ventanaAluminio.Add(ven);
                        dbs.SaveChanges();
                        MessageBox.Show("Ventana Agregada");

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
        public static ventanaAluminio Buscar(int id)
        {

            var db = new VentanaGzDb();

            return db.ventanaAluminio.Find(id);




        }
        public void eliminar(int id)
        {
            try
            {
                 ventanaAluminio ven = (from a in db.ventanaAluminio
                           where a.idAlumi == id
                           select a).FirstOrDefault();
              db.ventanaAluminio.Remove(ven);
              db.SaveChanges();
              MessageBox.Show("Registro Eliminado.!!");
            }
            catch (Exception) { MessageBox.Show("Seleccione Un registro"); }
           
        }

        public static List<ventanaAluminio> GetLista(int id)
        {
            List<ventanaAluminio> lista = new List<ventanaAluminio>();

            var db = new VentanaGzDb();

            //lista = db.ventanaAluminio.Where(p => p.idCliente == id).ToList();
            lista = db.ventanaAluminio.ToList();

            return lista;


        }
        public float precio(float ancho, float altura)
        {
            float resultado = 0;
            resultado = ancho * altura / 144;
            return resultado * 80;

        }


    }
}
