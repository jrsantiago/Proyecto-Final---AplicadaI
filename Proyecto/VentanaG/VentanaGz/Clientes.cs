using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;
using Entidad;
using BLL;

namespace VentanaGz
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        ClienteBll cli = new ClienteBll();
        public void llenarCamposBuscar(Cliente cliente)
        {
            try
            {

                textBNombre.Text = cliente.nombre;
                textBTelefono.Text = cliente.telefono;
                maskeBcedula.Text = cliente.cedula;
                textBDireccion.Text = cliente.Direccion;
                textBoxEmail.Text = cliente.Email;

            }
            catch (NullReferenceException) { MessageBox.Show("Id Incorrecto"); }



        }
        public Cliente llenarComposAgregar()
        {

           Cliente cliente = new Cliente();


            if (textBNombre.Text == "" || textBTelefono.Text == "" || maskeBcedula.Text == "" || textBDireccion.Text == "" || textBoxEmail.Text=="")
            {
                cliente = null;
            }

            else
            {
                cliente.nombre = textBNombre.Text;
                cliente.telefono = textBTelefono.Text;
                cliente.cedula = maskeBcedula.Text;
                cliente.Direccion = textBDireccion.Text;
                cliente.Email = textBoxEmail.Text;

            }

            return cliente;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                llenarCamposBuscar(ClienteBll.Buscar(Convert.ToInt32(textBbuscar.Text)));
            }
            catch (Exception) { MessageBox.Show("Introdusca El Id"); }


        } //A esto le puser Usuario(CAMBIARLO..!!)

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string valid = cli.Validar(textBTelefono.Text, maskeBcedula.Text);

            ClienteBll.Insertar(llenarComposAgregar(), valid);
            textBNombre.Text = "";
            textBTelefono.Text = "";
            maskeBcedula.Text = "";
            textBDireccion.Text = "";
            textBoxEmail.Text = "";

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBbuscar.Text);
               

                if (textBNombre.Text == "" || textBTelefono.Text == "" || maskeBcedula.Text == "" || textBoxEmail.Text == "" || textBDireccion.Text=="")
                {
                    MessageBox.Show("llene todos los Campos.!!");
                }
                else
                {
                    cli.Actualizar(id, textBNombre.Text, textBTelefono.Text, maskeBcedula.Text, textBDireccion.Text, textBoxEmail.Text);
                   
                }

            }
            catch (Exception) { MessageBox.Show("Introdusca El Id del Cliente"); }
            textBNombre.Text = "";
            textBTelefono.Text = "";
            maskeBcedula.Text = "";
            textBDireccion.Text = "";
            textBoxEmail.Text = "";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                cli.eliminar(Convert.ToInt32(textBbuscar.Text));
                textBNombre.Text = "";
                textBTelefono.Text = "";
                maskeBcedula.Text = "";
                textBDireccion.Text = "";
                textBoxEmail.Text = "";
            }
            catch (Exception) { MessageBox.Show("Introdusca El 'ID' del Cliente"); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
     }
   }

