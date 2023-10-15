using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes_Prototipo_G5
{
    public partial class VisualizarImpuestosHotel : Form
    {
        public VisualizarImpuestosHotel()
        {
            InitializeComponent();
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
