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
    public partial class FormPreReserva : Form
    {
        public FormPreReserva()
        {
            InitializeComponent();
        }

        private void FormPreReserva_Load(object sender, EventArgs e)
        {

        }

        private void buttonVerEstado_Click(object sender, EventArgs e)
        {
            ConsultaEstadoReserva formConsultaEstadoReserva = new ConsultaEstadoReserva();
            formConsultaEstadoReserva.Show();
        }
    }
}
