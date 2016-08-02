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


namespace VentanaGz
{
    public partial class ConsultaCiente : Form
    {
        public ConsultaCiente()
        {
            InitializeComponent();
        }
        VentanaGzDb db = new VentanaGzDb();
        private void buttonEntrar_Click(object sender, EventArgs e)
        {

            int id = 0;
            try
            {
                string tipoComando = ((string)comboBCampo.SelectedItem).ToString();
                if (tipoComando == "Id")
                {
                    id = int.Parse(textBCampos.Text);
                    var data = from a in db.Cliente

                               where a.idCliente == id
                               select a;

                    dataGridCliente.DataSource = data.ToList();
                }
                else if (tipoComando == "Nombre")
                {
                    var data = from a in db.Usuario

                               where a.userName == textBCampos.Text
                               select a;
                    dataGridCliente.DataSource = data.ToList();
                }
                else if (tipoComando == "Cedula")
                {
                    var data = from a in db.Usuario

                               where a.userName == textBCampos.Text
                               select a;
                    dataGridCliente.DataSource = data.ToList();
                }

            }
            catch (Exception) { MessageBox.Show("Campo Incorrecto"); }



        }
    }
       
    }
