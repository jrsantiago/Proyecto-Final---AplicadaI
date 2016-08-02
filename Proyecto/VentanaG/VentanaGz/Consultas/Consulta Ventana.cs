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
using Microsoft.Reporting.WinForms;

namespace VentanaGz
{
    public partial class Consulta_Ventana : Form
    {
        int id;
        public Consulta_Ventana()
        {
            id = 0;
            InitializeComponent();
        }
        VentanaAlumiBll ven = new VentanaAlumiBll();
        VentanaGzDb db = new VentanaGzDb();
        
        
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            ReporteVentana ven = new ReporteVentana();

            ven.reportVieVentana.Reset();
            ven.reportVieVentana.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            ven.reportVieVentana.LocalReport.ReportPath = @"C:\Users\juniorsantiago\Desktop\Proyecto\VentanaG\VentanaGz\Reportes\ListarVentana.rdlc";
            ven.reportVieVentana.LocalReport.DataSources.Clear();

            ven.reportVieVentana.LocalReport.DataSources.Add(
                new ReportDataSource("Ventana",
                VentanaAlumiBll.GetLista(id)));

            ven.reportVieVentana.LocalReport.Refresh();

            ven.Show();
        }

        private void bottonBuscar_Click(object sender, EventArgs e)
        {
            string tipoComando = ((string)comboBCliente.SelectedItem).ToString();
            id = VentanaAlumiBll.BuscarCampoCliente(tipoComando, textBoxCampo.Text);
           
            dataGVentana.DataSource = VentanaAlumiBll.GetLista(id);
        }
    }
}
