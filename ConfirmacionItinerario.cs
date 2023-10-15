using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes_Prototipo_G5
{
    public partial class ConfirmacionItinerario : Form
    {
        public ConfirmacionItinerario()
        {
            InitializeComponent();
        }

        private void ConfirmacionItinerario_Load(object sender, EventArgs e)
        {
            DateTime FechaActual = DateTime.Now.Date;
            textBoxFechaActual.Text = FechaActual.ToString();

        }

        private void buttonVolverAtrasConfItinerario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
