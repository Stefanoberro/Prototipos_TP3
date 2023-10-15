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
    public partial class GuardarOpcion : Form
    {
        public GuardarOpcion()
        {
            InitializeComponent();
        }

        private void buttonVolverALaBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNuevoItinerario_Click(object sender, EventArgs e)
        {
            ItinerarioCreado itinerarioCreado = new ItinerarioCreado();
            itinerarioCreado.Show();
        }

        private void buttonItinerarioActual_Click(object sender, EventArgs e)
        {
            ItinerarioModificado itinerarioModificado = new ItinerarioModificado();
            itinerarioModificado.Show();
        }

        private void buttonOtroItinerario_Click(object sender, EventArgs e)
        {
            OtroItinerario otroItinerario = new OtroItinerario();
            otroItinerario.Show();
        }
    }
}
