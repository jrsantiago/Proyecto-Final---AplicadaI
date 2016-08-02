using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidad;
using DALL;

namespace VentanaGz
{
    public partial class UsuarioVentana : Form
    {
        
        public UsuarioVentana()
        {
            
            InitializeComponent();
        }
        UsuarioBLL usu = new UsuarioBLL();
        public void llenarCamposBuscar(Usuario usuario)
        {
            try
            {


                if (usuario.sexo == "F")
                {
                    radioButtoFeme.Checked = true;
                }
                if (usuario.sexo == "M")
                {
                    radioButtoMascu.Checked = true;
                }

                textBNombre.Text = usuario.nombre;
                textBApellido.Text = usuario.apellido;
                textBUserName.Text = usuario.userName;
                textBContra.Text = usuario.contrasena;

            }
            catch (NullReferenceException) { MessageBox.Show("Id Incorrecto");}

            

        }
        public Usuario llenarComposAgregar()
        {
            
            string sexo = "";
            string restrincciones = "";
            if (radioButtoFeme.Checked == true)
            {
                sexo = "F";
            }
            if (radioButtoMascu.Checked == true)
            {
                sexo = "M";
            }
            if(radioBuAdministrador.Checked==true)
            {
                restrincciones = "Administrador";
            }
            if (radioButtAsociado.Checked == true)
            {
                restrincciones = "Asociado";
            }




            Usuario usuario = new Usuario();
           

            if (textBNombre.Text == "" || textBApellido.Text == "" || textBUserName.Text == "" || textBContra.Text == "" || sexo == "" || restrincciones=="")
            {              
                usuario = null;              
            }
          
            else
            {
              usuario.nombre = textBNombre.Text;
              usuario.apellido = textBApellido.Text;
              usuario.userName = textBUserName.Text;
              usuario.contrasena = textBContra.Text;
              usuario.sexo = sexo;
              usuario.restriccion = restrincciones;
                              
            }
          
            return usuario;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string valid = usu.Validar(textBUserName.Text, textBContra.Text);
            UsuarioBLL.Insertar(llenarComposAgregar(),valid);
         
            textBNombre.Text = "";
            textBApellido.Text = "";
            textBUserName.Text = "";
            textBContra.Text = "";
            radioButtoFeme.Checked = false;
            radioButtoMascu.Checked = false;
            radioButtAsociado.Checked = false;
            radioBuAdministrador.Checked = false;
        
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            

            try
            {
                int id = int.Parse(textBbuscarUsuario.Text);
                string sexo = "";
                string restrincciones = "";
                if (radioButtoFeme.Checked == true)
                {
                    sexo = "F";
                }
                if (radioButtoMascu.Checked == true)
                {
                    sexo = "M";
                }
                if (radioBuAdministrador.Checked == true)
                {
                    restrincciones = "Administrador";
                }
                if (radioButtAsociado.Checked == true)
                {
                    restrincciones = "Asociado";
                }


                if (textBNombre.Text=="" || textBApellido.Text=="" || textBUserName.Text=="" || textBContra.Text=="" || sexo=="" || restrincciones=="")
                {
                    MessageBox.Show("llene todos los Campos.!!");
                }
                else
                {
                    usu.Actualizar(id, textBNombre.Text, textBApellido.Text, textBUserName.Text, textBContra.Text, sexo);
                    textBNombre.Text = "";
                    textBApellido.Text = "";
                    textBUserName.Text = "";
                    textBContra.Text = "";
                    radioButtoFeme.Checked = false;
                    radioButtoMascu.Checked = false;
                    radioBuAdministrador.Checked = false;
                    radioButtAsociado.Checked = false;
                }
               
            }catch(Exception) { MessageBox.Show("Introdusca El Id del Usuario"); }   
    
           
        }
        private void buttoBuscarUsuario_Click(object sender, EventArgs e)
        {

            
            try
            {
                llenarCamposBuscar(UsuarioBLL.Buscar(Convert.ToInt32(textBbuscarUsuario.Text)));
            }
            catch (Exception){ MessageBox.Show("Introdusca El Id"); }
            
            
              
            
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               usu.eliminar(Convert.ToInt32(textBbuscarUsuario.Text));
                textBNombre.Text = "";
                textBApellido.Text = "";
                textBUserName.Text = "";
                textBContra.Text = "";
                radioButtoFeme.Checked = false;
                radioButtoMascu.Checked = false;
            }
            catch (Exception) { MessageBox.Show("Introdusca El 'ID' del Usuario"); }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioVentana_Load(object sender, EventArgs e)
        {

        }
    }
}
