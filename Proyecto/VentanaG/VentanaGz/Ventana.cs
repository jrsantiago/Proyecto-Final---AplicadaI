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
    public partial class Ventana : Form
    {
        int id;
        string Detail; 
        float ancho;
        float altura;
        string color;
        string tipoMaterial;
        string selecioDatagrind;
      


        public Ventana()
        {
           
            id = 0;
            ancho = 0;
            altura = 0;
            color = string.Empty;
            tipoMaterial = string.Empty;
            selecioDatagrind = string.Empty;
            Detail = string.Empty;
            InitializeComponent();
        }
        VentanaAlumiBll ventana = new VentanaAlumiBll();
        VentanaGzDb db = new VentanaGzDb();
        Cliente cliente = new Cliente();
        public void grid()
        {
            var data = from a in db.ventanaAluminio
                    //   where a.idCliente == this.id
                       select a;

            dataGridVentana.DataSource = data.ToList();
            Ventana ven = new Ventana();
        }
        private void buttoBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoComando = ((string)comboBCliente.SelectedItem).ToString();

                this.id = VentanaAlumiBll.BuscarCampoCliente(tipoComando, textBbuscar.Text);
            }
            catch (Exception) { MessageBox.Show("Seleccione Un Campo"); }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // string tipoComando = ((string)comboBCliente.SelectedItem).ToString();
            try
            {
                if (selecioDatagrind == null)
                {
                    MessageBox.Show("Seleccione el Id del registro a actualizar");
                }
                Detail = (string)cboDetail.SelectedItem;
                id = int.Parse(textBbuscar.Text);
                color = (string)comboBcolor.SelectedItem;
                tipoMaterial = (string)comboBTipoMaterial.SelectedItem;
                ancho = float.Parse(textBancho.Text);
                altura = float.Parse(textBoxAltura.Text);
       
              DateTime tiempo;
               tiempo = dateTimeVentana.Value;
      
                VentanaAlumiBll ven = new VentanaAlumiBll(ancho, altura, color, tipoMaterial, this.id,tiempo, Detail);
                ven.fabriVentanaAluninio();
                MessageBox.Show("Ventana se ha agregado");

                comboBcolor.Text = "Seleccione Color";
                comboBTipoMaterial.Text = "Seleccione Tipo de Material";
                textBancho.Text = "";
                textBoxAltura.Text = "";


            }
            catch (Exception) { MessageBox.Show("Introdusca Todos los Datos"); }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selecioDatagrind);


                if (selecioDatagrind == null)
                {
                    MessageBox.Show("Seleccione el Id del registro a actualizar");
                }
                else
                {
                    if (textBancho.Text == "")
                    {
                        MessageBox.Show("Introdusca el Ancho");
                    }
                    else

                      if (textBoxAltura.Text == "")
                    {
                        MessageBox.Show("Introdusca la Altura");
                    }
                    else
                        if (comboBcolor.Text == null)
                    {
                        MessageBox.Show("Seleccione el Color");
                    }
                    else
                        if (comboBTipoMaterial == null)
                    {
                        MessageBox.Show("Seleccione Tipo Material");
                    } else

                        color = ((string)comboBcolor.SelectedItem).ToString();
                    tipoMaterial = ((string)comboBTipoMaterial.SelectedItem).ToString();
                    ancho = float.Parse(textBancho.Text);
                    altura = float.Parse(textBoxAltura.Text);
                    ventana.actualizar(ancho, altura, color, tipoMaterial, id);

                }
            }
            catch (Exception) { MessageBox.Show("Seleccione el Id del registro ha actualizar"); }


            comboBcolor.Text = "Seleccione Color";
            comboBTipoMaterial.Text = "Seleccione Tipo de Material";
            textBancho.Text = "";
            textBoxAltura.Text = "";



        }

        private void dataGridVentana_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow data = dataGridVentana.Rows[e.RowIndex];
                selecioDatagrind = Convert.ToString(data.Cells["idAlumi"].Value);
            }
            catch (Exception) { MessageBox.Show("Seleccione IdAlumi del registro"); }


        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            var data = from a in db.ventanaAluminio
                      // where a.idCliente == this.id
                       select a;
            dataGridVentana.ScrollBars = ScrollBars.None;
            dataGridVentana.DataSource = data.ToList();
            Ventana ven = new Ventana();


        }

        private void textBbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try { 
                 int id = int.Parse(selecioDatagrind);
                 ventana.eliminar(id);
               }catch (FormatException) { MessageBox.Show("Seleccione Un Registro"); }
        }

        private void buttonAddFecha_Click(object sender, EventArgs e)
        {

        }

      
    }
    }

