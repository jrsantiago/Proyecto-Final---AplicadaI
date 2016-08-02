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
    public partial class Screen : Form
    {
        int id;
        float ancho;
        float altura;
        string selecioDatagrind;
        public Screen()
        {
            id = 0;
            selecioDatagrind = "";
            InitializeComponent();
        }
        screenBll sc = new screenBll();
        VentanaGzDb db = new VentanaGzDb();
        private void buttoBuscarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                string tipoComando = ((string)comboBCliente.SelectedItem).ToString();

                this.id = screenBll.BuscarCampoCliente(tipoComando, textBbuscar.Text);
            }
            catch (Exception) { MessageBox.Show("Seleccione Un Campo"); }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                float ancho = float.Parse(textBancho.Text);
                float altura = float.Parse(textBoxAltura.Text);
                //  string tiempo = dateTimeScreen.Value.ToString();
                DateTime tiempo;
                tiempo = dateTimeScreen.Value;

                if (ancho != 0 || altura != 0)
                {
                    screenBll sc = new screenBll(ancho, altura, this.id,tiempo);
                    sc.fabriScreen();
                }


            }
            catch (Exception) { MessageBox.Show("Uno de los Campos esta vacio"); }


              textBoxAltura.Text = "";
              textBancho.Text = "";


        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selecioDatagrind);


                if (selecioDatagrind == null)
                {
                    MessageBox.Show("seleccion el id a actualizar");
                }
                else

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
                {
                    ancho = float.Parse(textBancho.Text);
                    altura = float.Parse(textBoxAltura.Text);
                    sc.actualizar(ancho, altura, id);

                }

            }
            catch (Exception) { MessageBox.Show("Seleccione el Id del registro"); }

            textBancho.Text = "";
            textBoxAltura.Text = "";

        }

        private void dataGridScreen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = dataGridScreen.Rows[e.RowIndex];
                selecioDatagrind = Convert.ToString(data.Cells["idScreen"].Value);
            }
            catch (Exception) { MessageBox.Show("Seleccione IdAlumi del registro"); }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(selecioDatagrind);
                sc.eliminar(id);
            }
            catch (FormatException) { MessageBox.Show("Seleccione Un Registro"); }


        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            var data = from a in db.Screens
                       where a.idCliente == this.id
                       select a;
            dataGridScreen.ScrollBars = ScrollBars.None;
            dataGridScreen.DataSource = data.ToList();

        }

    }
}
