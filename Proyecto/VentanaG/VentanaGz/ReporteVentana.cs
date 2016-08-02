using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaGz
{
    public partial class ReporteVentana : Form
    {
        public ReporteVentana()
        {
            InitializeComponent();
        }

        private void ReporteVentana_Load(object sender, EventArgs e)
        {

            this.reportVieVentana.RefreshReport();
        }
    }
}
