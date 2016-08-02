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
    public partial class MasterDetails : Form
    {
        int id;
        public MasterDetails()
        {
            InitializeComponent();
            id = 0;
        }
        Ventana ven = new Ventana();
        Cliente cliente = new Cliente();
        private void MasterDetails_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             id = int.Parse(textBoxId.Text);
            LLenar(ClienteBll.Buscar(id));
        }
        private void LLenar(Cliente cliente)
        {
             id = int.Parse(textBoxId.Text);

            textBoxId.Text = cliente.idCliente.ToString();
            textBoxDetalle.Text = cliente.detalle;
            dataGridDetalle.DataSource = ClienteBll.GetListaCliente(id);



        }

        private void button2_Click(object sender, EventArgs e)
        {
           // float altura = float.Parse(comboBVentana.DisplayMember);
           // float ancho = float.Parse(comboBVentana.DisplayMember);


           // cliente.VentanaAluminio.Add(new ventanaAluminio((int)comboBVentana.SelectedValue,ancho,altura));
        }
        public void cargar()
        {
            comboBVentana.DataSource = VentanaAlumiBll.GetLista(id);
            comboBVentana.ValueMember = "idAlumi";
            comboBVentana.DisplayMember = "altura";
            comboBVentana.DisplayMember = "ancho";
        }
    }
}
