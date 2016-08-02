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
using BLL;
using Microsoft.Reporting.WinForms;
using Entidad;

namespace VentanaGz
{
    public partial class ConsultaScreen : Form
    {
        int id;
        public ConsultaScreen()
        {
            id = 0;
            InitializeComponent();
        }
        VentanaGzDb db = new VentanaGzDb();
        screenBll sc = new screenBll();
        private void bottonBuscar_Click(object sender, EventArgs e)
        {
            string tipoComando = ((string)comboBCliente.SelectedItem).ToString();

          id=  screenBll.BuscarCampoCliente(tipoComando, textBoxCampo.Text);
           // string tipoComando = ((string)comboBCliente.SelectedItem).ToString();
            //Dictionary<string, string> Cliente = new Dictionary<string, string>();

            //Cliente.Add((string)comboBCliente.SelectedItem, textBoxCampo.Text);
            //Cliente.Add("Fecha",dtpFecha.Value.ToShortDateString());

            //dataGScreen.DataSource = screenBll.GetLista(Cliente); 
      //  );
            dataGScreen.DataSource = screenBll.GetLista(id);
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            ReporteScreen scre = new ReporteScreen();

            scre.reportVieScreen.Reset();
            scre.reportVieScreen.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            scre.reportVieScreen.LocalReport.ReportPath = @"C:\Users\juniorsantiago\Desktop\Proyecto\VentanaG\VentanaGz\Reportes\ListarScreen.rdlc";
            scre.reportVieScreen.LocalReport.DataSources.Clear();

            scre.reportVieScreen.LocalReport.DataSources.Add(
                new ReportDataSource("Screen",
                screenBll.GetLista(id)));

            scre.reportVieScreen.LocalReport.Refresh();

            scre.Show();

        }
    }
}
