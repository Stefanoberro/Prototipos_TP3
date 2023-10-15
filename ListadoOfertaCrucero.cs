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
    public partial class ListadoOfertaCrucero : Form
    {
        public ListadoOfertaCrucero()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerParadasCrucero formVerParadasCrucero = new VerParadasCrucero();
            formVerParadasCrucero.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerTarifa formVerTarifa = new VerTarifa();
            formVerTarifa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuardarOpcion guardarOpcion = new GuardarOpcion();
            guardarOpcion.Show();
        }
    }
}
