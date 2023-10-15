namespace AgenciaViajes_Prototipo_G5
{
    public partial class FormMenuPpal : Form
    {
        public FormMenuPpal()
        {
            InitializeComponent();
        }

        private void buttonConsultaEstadoReserva_Click(object sender, EventArgs e)
        {
            //creo la llamada del proximo winform
            ConsultaEstadoReserva formConsultaEstadoReserva = new ConsultaEstadoReserva();
            formConsultaEstadoReserva.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaDeDisponibilidadProductos formConsultaDeDisponibilidadProductos = new ConsultaDeDisponibilidadProductos();
            formConsultaDeDisponibilidadProductos.Show();
        }

        private void buttonConfirmacionItinerario_Click(object sender, EventArgs e)
        {
            ConfirmacionItinerario formConsultaItinerario = new ConfirmacionItinerario();
            formConsultaItinerario.Show();
        }

        private void buttonbuttonConfirmacionReserva_Click(object sender, EventArgs e)
        {
            ConfirmacionReservas formConfirmacionReservas = new ConfirmacionReservas();
            formConfirmacionReservas.Show();
        }

        private void buttonGeneracionPreReserva_Click(object sender, EventArgs e)
        {
            ListadoItinerario formListadoItinerario = new ListadoItinerario();
            formListadoItinerario.Show();
        }

        private void FormMenuPpal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}