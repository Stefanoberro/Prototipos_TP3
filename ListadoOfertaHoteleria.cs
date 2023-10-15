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
    public partial class ListadoOfertaHoteleria : Form
    {
        public ListadoOfertaHoteleria()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuardarOpcion guardarOpcion = new GuardarOpcion();
            guardarOpcion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicioExtraHotel servicioExtraHotel = new ServicioExtraHotel();
            servicioExtraHotel.Show();
        }
    }
}
