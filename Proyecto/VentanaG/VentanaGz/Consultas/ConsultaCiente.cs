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
        int id = 0;
        public ConsultaCiente()
        {
            InitializeComponent();
        }
        VentanaGzDb db = new VentanaGzDb();
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                string tipoComando = ((string)cboCliente.SelectedItem).ToString();
                if (tipoComando == "Id")
                {
                    id = int.Parse(txtBuscar.Text);
                    var data = from a in db.Cliente

                               where a.idCliente == id
                               select a;

                    llenarCampos(data.ToList());
                }
                else if (tipoComando == "Nombre")
                {
                    var data = from a in db.Cliente

                               where a.nombre == txtBuscar.Text
                               select a;
                    llenarCampos(data.ToList());
                }
                else if (tipoComando == "Cedula")
                {
                    var data = from a in db.Cliente

                               where a.cedula == txtBuscar.Text
                               select a;

                    llenarCampos(data.ToList());
                }

                var dataDetail = (from a in db.ventanaAluminio
                                 where a.idCliente == id
                                 select new
                                 {
                                     Numero = a.idAlumi,
                                     Produto = a.Detail,
                                     Dimension = a.ancho + " X " + a.altura,
                                     Material = a.tipoMaterial,
                                     Color = a.color,
                                     Precio = a.precio,
                                     Fecha = a.fecha
                                 });
                
                dataGridCliente.DataSource = dataDetail.ToList();

            }
            catch (Exception) { MessageBox.Show("Campo Incorrecto"); }

        }

        private void llenarCampos(List<Cliente> Cliente)
        { 
            id = Cliente[0].idCliente;
            txtCedula.Text = Cliente[0].cedula.ToString();
            txtNombre.Text = Cliente[0].nombre.ToString();
            txtDireccion.Text = Cliente[0].Direccion.ToString();
            txtEmail.Text = Cliente[0].Email.ToString();
        }

        private void Limpiar()
        {
            id =0;
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dataGridCliente.DataSource = null;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {

        }
    }
       
    }
