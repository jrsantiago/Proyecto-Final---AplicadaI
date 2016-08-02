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
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }
        VentanaGzDb db = new VentanaGzDb();
        UsuarioBLL usu = new UsuarioBLL();
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            try {
                string tipoComando = ((string)comboBoxUsuario.SelectedItem).ToString();
                if (tipoComando == "Id")
                {
                    id = int.Parse(textBuscar.Text);
                    var data = from a in db.Usuario

                               where a.idUsuario == id
                               select a;

                    dataGridViewUsuario.DataSource = data.ToList();
                } else if (tipoComando == "Nombre Usuario")
                {
                    var data = from a in db.Usuario

                               where a.userName.Contains(textBuscar.Text)
                               select a;
                    dataGridViewUsuario.DataSource = data.ToList();
                }
                else if (tipoComando == "Contraseña")
                {
                    var data = from a in db.Usuario

                               where a.userName == textBuscar.Text
                               select a;
                    dataGridViewUsuario.ScrollBars = ScrollBars.None;
                    dataGridViewUsuario.DataSource = data.ToList();
                }

            }
            catch (Exception) { MessageBox.Show("Campo Incorrecto"); }



        }
    }
}
