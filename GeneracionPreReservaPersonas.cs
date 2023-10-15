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
    public partial class GeneracionPreReservaPersonas : Form
    {
        public GeneracionPreReservaPersonas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneracionPreReservaAdulto adulto = new GeneracionPreReservaAdulto();
            adulto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneracionPreReservaMenor menor = new GeneracionPreReservaMenor();
            menor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneracionPreReservaInfante infante = new GeneracionPreReservaInfante();
            infante.Show();
        }
    }
}
