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
    public partial class ListadoItinerario : Form
    {
        public ListadoItinerario()
        {
            InitializeComponent();
        }

        private void buttonCrearItinNuevo_Click(object sender, EventArgs e)
        {
            ConsultaDeDisponibilidadProductos nuevoItinerario = new ConsultaDeDisponibilidadProductos();
            nuevoItinerario.Show();
        }

        private void buttonVerItinPresup_Click(object sender, EventArgs e)
        {
            FormArmadoItinerario itinerario = new FormArmadoItinerario();
            itinerario.Show();
        }

        private void buttonGenerarPreReserva_Click(object sender, EventArgs e)
        {
            GeneracionPreReservaPersonas generacionPreReserva = new GeneracionPreReservaPersonas();
            generacionPreReserva.Show();
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
