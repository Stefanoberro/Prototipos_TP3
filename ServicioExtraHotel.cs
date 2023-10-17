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
    public partial class ServicioExtraHotel : Form
    {
        public ServicioExtraHotel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea agregar este servicio?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Servicio agregado exitosamente", "Servicio agregado", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
