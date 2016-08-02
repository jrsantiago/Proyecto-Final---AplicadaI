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
    public partial class Material : Form
    {
        string selecioDatagrind;
       
        string tipoComando;
        int unidad ;
        float cantidadPie ;
        float precio;
        public Material()
        {
            selecioDatagrind = "";
            tipoComando = "";
            unidad = 0;
            cantidadPie = 0;
            precio = 0;
            InitializeComponent();
        }
        VentanaGzDb db = new VentanaGzDb();
        MaterialesBll mate = new MaterialesBll();
        public void llenarCamposBuscar(Materiales material)
        {
            comboBdescripcion.Text = material.Descripcion;
            textBoxUnidad.Text = material.unidad.ToString();
            textBCantiPie.Text = material.CantidadPie.ToString();
            textBPrecio.Text = material.precio.ToString();
           // this.id = material.idMateriale;

        }
        public Materiales llenarComposAgregar()
        {

            Materiales material = new Materiales(); 


            try
            {
                string tipoComando = ((string)comboBdescripcion.SelectedItem).ToString();
                int unidad = int.Parse(textBoxUnidad.Text);
                float cantiPie = float.Parse(textBCantiPie.Text);
                float precio = float.Parse(textBPrecio.Text);
                material.Descripcion = tipoComando;
                material.unidad = unidad;
                material.CantidadPie = cantiPie;
                material.precio = precio;
            }
            catch (Exception) { MessageBox.Show("Introdusca los datos correctamente"); }


            return material;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                tipoComando = ((string)comboBdescripcion.SelectedItem).ToString();
                unidad = int.Parse(textBoxUnidad.Text);
                cantidadPie = float.Parse(textBCantiPie.Text);
                precio = float.Parse(textBPrecio.Text);
            }
            catch (Exception) { }


            if (tipoComando == "" || unidad == 0 || cantidadPie == 0 || precio == 0)
            {
                MessageBox.Show("Introdusca los Campos Correctamente");
            }
            else
            {
                MaterialesBll.Insertar(llenarComposAgregar());
                comboBdescripcion.Text = "Seleccione Materiales";
                textBCantiPie.Text = "";
                textBoxUnidad.Text = "";
                textBPrecio.Text = "";
            }

        }
        private void buttoBuscarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                llenarCamposBuscar(MaterialesBll.Buscar(Convert.ToInt32(textBbuscar.Text)));
            }
            catch (Exception) { MessageBox.Show("Id Incorrecto"); }
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
           {
                int id = int.Parse(selecioDatagrind);

                if (selecioDatagrind == null)
                {
                    MessageBox.Show("Seleccione el id del registro a actualizar");
                }
                if (textBCantiPie.Text == "")
                {
                    MessageBox.Show("Introdusca Cantidad Pie");
                }
                else
              if (textBoxUnidad.Text == "")
                {
                    MessageBox.Show("Introdusca la Unidades");
                }
                else
               if (textBPrecio.Text == "")
                {
                    MessageBox.Show("Introdusca El Precio");
                }
                else 
                if(comboBdescripcion.Text==null)
                {
                    MessageBox.Show("Introdusca La descripcion");
                }
                else
                {

                    tipoComando = ((string)comboBdescripcion.SelectedItem).ToString();
                    unidad = int.Parse(textBoxUnidad.Text);
                    cantidadPie = float.Parse(textBCantiPie.Text);
                    precio = float.Parse(textBPrecio.Text);
                    mate.Actualizar(id, tipoComando, unidad, cantidadPie, precio);

                }

            } catch (Exception) { MessageBox.Show("Seleccione el Id del registro a actualizar"); }
            
        
                comboBdescripcion.Text = "Seleccione Materiales";
                textBCantiPie.Text = "";
                textBoxUnidad.Text = "";
                textBPrecio.Text = "";
            
            
        }
         
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
              int id = int.Parse(selecioDatagrind);
                mate.Eliminar(id);
                 comboBdescripcion.Text = "Seleccione Materiales";
                 textBCantiPie.Text = "";
                 textBoxUnidad.Text = "";
                 textBPrecio.Text = "";
            }
            catch (Exception) { MessageBox.Show("Seleccion El id a Eliminar"); }
          
        }
        private void Mostrar_Click(object sender, EventArgs e)
        {
            var data = from a in db.Materiales                  
                       select a;

            dataGridMateriales.ScrollBars = ScrollBars.None;
            dataGridMateriales.DataSource = data.ToList();

        }
        private void dataGridMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = dataGridMateriales.Rows[e.RowIndex];
                selecioDatagrind = Convert.ToString(data.Cells["idMateriale"].Value);
            }
            catch (Exception) { MessageBox.Show("Seleccione IdAlumi del registro"); }
        }
    }
}
