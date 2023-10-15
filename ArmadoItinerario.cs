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
    public partial class FormArmadoItinerario : Form
    {
        public FormArmadoItinerario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonImpAereo_Click(object sender, EventArgs e)
        {
            VisualizarImpuestosCrucero formImpuestoAereo = new VisualizarImpuestosCrucero();
            formImpuestoAereo.Show();
        }

        private void buttonGenerarPreRese_Click(object sender, EventArgs e)
        {
            GeneracionPreReservaPersonas generacionPreReserva = new GeneracionPreReservaPersonas();
            generacionPreReserva.Show();
        }

        private void buttonImpCrucero_Click(object sender, EventArgs e)
        {
            VisualizarImpuestosCrucero impuestosCrucero = new VisualizarImpuestosCrucero();
            impuestosCrucero.Show();
        }

        private void buttonImpHotel_Click(object sender, EventArgs e)
        {
            VisualizarImpuestosHotel impuestosHotel = new VisualizarImpuestosHotel();
            impuestosHotel.Show();
        }

        private void buttonImpPaquete_Click(object sender, EventArgs e)
        {
            VisualizarImpuestoPaqueteTuristico impuestoPaqueteTuristico = new VisualizarImpuestoPaqueteTuristico();
            impuestoPaqueteTuristico.Show();
        }
    }
}
