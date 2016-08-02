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
    public partial class ReporteScreen : Form
    {
        public ReporteScreen()
        {
            InitializeComponent();
        }

        private void ReporteScreen_Load(object sender, EventArgs e)
        {

            this.reportVieScreen.RefreshReport();
        }
    }
}
