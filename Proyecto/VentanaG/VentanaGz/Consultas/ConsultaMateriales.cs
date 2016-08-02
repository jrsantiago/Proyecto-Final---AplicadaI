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

namespace VentanaGz
{
    public partial class ConsultaMateriales : Form
    {
        VentanaGzDb db = new VentanaGzDb();
        public ConsultaMateriales()
        {
            InitializeComponent();
        }

        private void ConsultaMateriales_Load(object sender, EventArgs e)
        {
            var data = from a in db.Materiales
                       select a;
           ;
            dataGriMateriales.DataSource = data.ToList();
            
        }
    }
}
