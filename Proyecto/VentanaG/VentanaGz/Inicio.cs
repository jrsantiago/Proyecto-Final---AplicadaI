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
using DALL;
using Entidad;

namespace VentanaGz
{
    public partial class VentanaGz : Form
    {
        //internal object cliente;

        public VentanaGz()
        {
            InitializeComponent();
            //Loging lo = new Loging();
            //if (lo.ShowDialog()==DialogResult.OK)
            //{
            //    MenuGz menu = new MenuGz();
            //    this.Visible = false;
            //    menu.Show();
            //}
            
        } //probando lo que el me enseño


       public void sesion()
        {
            bool valor = false;


            valor = UsuarioBLL.log(textbUserName.Text, textbContrasena.Text);
            string restrinccion = "";
            try
            {
                using (VentanaGzDb db = new VentanaGzDb())
                {
                    restrinccion = db.Usuario.FirstOrDefault(x => x.contrasena == textbContrasena.Text).restriccion.ToString();
                }

            }
            catch (Exception) { }

            if (valor == true)
            {
                MenuGz menu = new MenuGz(restrinccion);
                this.Visible = false;
                menu.Show();
            }
        }
        private void EntrarSesinbutton_Click(object sender, EventArgs e)
        {
            sesion();
        }

      

        private void textbContrasena_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                sesion();
            }
        }

        private void VentanaGz_Load(object sender, EventArgs e)
        {

        }
    }
    }
