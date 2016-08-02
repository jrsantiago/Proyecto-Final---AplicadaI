using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using BLL;
using DALL;

namespace VentanaGz
{
    public partial class MenuGz : Form
    {
       string cliente;
        int clienteid;
        string restriccion;
        public bool permiso;
        public MenuGz(string restricc)
        {
            this.restriccion = restricc;
           // clienteid = 0;
            cliente = "";
            InitializeComponent();
        }
        //Cliente cliente = new Cliente();

        VentanaGzDb db = new VentanaGzDb();

        VentanaGz v = new VentanaGz();




        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
          {
            
           
          }

        public void MenuGz_Load(object sender, EventArgs e)
        {
           
            if(restriccion=="Asociado")
            {
               nuevoUsuarioToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }
           
           
        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioVentana usu = new UsuarioVentana();
            usu.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuario usu = new ConsultaUsuario();
            usu.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clie = new Clientes();
            clie.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCiente clie = new ConsultaCiente();
            clie.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana ven = new Ventana();
            ven.Show();

        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Ventana ven = new Consulta_Ventana();
            ven.Show();
        }

        private void screenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Screen sc = new Screen();
            sc.Show();
        }

        private void screenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaScreen sc = new ConsultaScreen();
            sc.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material mate = new Material();
            mate.Show();
        }

        private void materialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaMateriales ma = new ConsultaMateriales();
            ma.Show();
        }

        private void MenuGz_FormClosing(object sender, FormClosingEventArgs e)
        {
            v.Close();
        }

        private void MenuGz_FormClosed(object sender, FormClosedEventArgs e)
        {
            v.Close();
        }
    }
}
