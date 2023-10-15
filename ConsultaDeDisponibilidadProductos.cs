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
    public partial class ConsultaDeDisponibilidadProductos : Form
    {
        public ConsultaDeDisponibilidadProductos()
        {
            InitializeComponent();
            dateTimePickerIda.MinDate = DateTime.Now;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            ListadoVuelosDisponibles formListadoVuelosDisponibles = new ListadoVuelosDisponibles();
            formListadoVuelosDisponibles.Show();
        }

        private void buttonVerPaquetesTuristicos_Click(object sender, EventArgs e)
        {
            VerPaqueteTuristico verPaqueteTuristico = new VerPaqueteTuristico();
            verPaqueteTuristico.Show();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
