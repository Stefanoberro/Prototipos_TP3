namespace AgenciaViajes_Prototipo_G5
{
    partial class FormMenuPpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonConsultaDeDisponibilidad = new Button();
            button2 = new Button();
            buttonGeneracionPreReserva = new Button();
            buttonConfirmacionReserva = new Button();
            buttonConsultaEstadoReserva = new Button();
            button6 = new Button();
            buttonConfirmacionItinerario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una de las opciones:";
            // 
            // buttonConsultaDeDisponibilidad
            // 
            buttonConsultaDeDisponibilidad.Location = new Point(72, 45);
            buttonConsultaDeDisponibilidad.Margin = new Padding(2);
            buttonConsultaDeDisponibilidad.Name = "buttonConsultaDeDisponibilidad";
            buttonConsultaDeDisponibilidad.Size = new Size(248, 37);
            buttonConsultaDeDisponibilidad.TabIndex = 1;
            buttonConsultaDeDisponibilidad.Text = "Consulta de Disponibilidad de Productos";
            buttonConsultaDeDisponibilidad.UseVisualStyleBackColor = true;
            buttonConsultaDeDisponibilidad.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 85);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(248, 37);
            button2.TabIndex = 2;
            button2.Text = "Itinerarios / Presupuestos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonGeneracionPreReserva_Click;
            // 
            // buttonGeneracionPreReserva
            // 
            buttonGeneracionPreReserva.Location = new Point(72, 125);
            buttonGeneracionPreReserva.Margin = new Padding(2);
            buttonGeneracionPreReserva.Name = "buttonGeneracionPreReserva";
            buttonGeneracionPreReserva.Size = new Size(248, 37);
            buttonGeneracionPreReserva.TabIndex = 3;
            buttonGeneracionPreReserva.Text = "Generación de Pre Reserva";
            buttonGeneracionPreReserva.UseVisualStyleBackColor = true;
            buttonGeneracionPreReserva.Click += buttonGeneracionPreReserva_Click;
            // 
            // buttonConfirmacionReserva
            // 
            buttonConfirmacionReserva.Location = new Point(72, 166);
            buttonConfirmacionReserva.Margin = new Padding(2);
            buttonConfirmacionReserva.Name = "buttonConfirmacionReserva";
            buttonConfirmacionReserva.Size = new Size(248, 37);
            buttonConfirmacionReserva.TabIndex = 4;
            buttonConfirmacionReserva.Text = "Confirmación de Reservas";
            buttonConfirmacionReserva.UseVisualStyleBackColor = true;
            buttonConfirmacionReserva.Click += buttonbuttonConfirmacionReserva_Click;
            // 
            // buttonConsultaEstadoReserva
            // 
            buttonConsultaEstadoReserva.Location = new Point(72, 206);
            buttonConsultaEstadoReserva.Margin = new Padding(2);
            buttonConsultaEstadoReserva.Name = "buttonConsultaEstadoReserva";
            buttonConsultaEstadoReserva.Size = new Size(248, 37);
            buttonConsultaEstadoReserva.TabIndex = 5;
            buttonConsultaEstadoReserva.Text = "Consultar Estado de Reservas";
            buttonConsultaEstadoReserva.UseVisualStyleBackColor = true;
            buttonConsultaEstadoReserva.Click += buttonConsultaEstadoReserva_Click;
            // 
            // button6
            // 
            button6.Location = new Point(129, 305);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(144, 37);
            button6.TabIndex = 6;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // buttonConfirmacionItinerario
            // 
            buttonConfirmacionItinerario.Location = new Point(72, 247);
            buttonConfirmacionItinerario.Margin = new Padding(2);
            buttonConfirmacionItinerario.Name = "buttonConfirmacionItinerario";
            buttonConfirmacionItinerario.Size = new Size(248, 37);
            buttonConfirmacionItinerario.TabIndex = 7;
            buttonConfirmacionItinerario.Text = "Confirmación Itinerario";
            buttonConfirmacionItinerario.UseVisualStyleBackColor = true;
            buttonConfirmacionItinerario.Click += buttonConfirmacionItinerario_Click;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 407);
            Controls.Add(buttonConfirmacionItinerario);
            Controls.Add(button6);
            Controls.Add(buttonConsultaEstadoReserva);
            Controls.Add(buttonConfirmacionReserva);
            Controls.Add(buttonGeneracionPreReserva);
            Controls.Add(button2);
            Controls.Add(buttonConsultaDeDisponibilidad);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormMenuPpal";
            Text = "Menú Principal";
            Load += FormMenuPpal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonConsultaDeDisponibilidad;
        private Button button2;
        private Button buttonGeneracionPreReserva;
        private Button buttonConfirmacionReserva;
        private Button buttonConsultaEstadoReserva;
        private Button button6;
        private Button buttonConfirmacionItinerario;
    }
}