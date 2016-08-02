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

namespace VentanaGz
{
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
            //Loging lo = new Loging();
            //if (lo.ShowDialog()==DialogResult.OK)
            //{
            //    MenuGz menu = new MenuGz();
            //    this.Visible = false;
            //    menu.Show();
            //}
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EntrarSesinbutton_Click(object sender, EventArgs e)
        {
            sesion();
        }

        private void textbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sesion();
            }
        }
    }
}
