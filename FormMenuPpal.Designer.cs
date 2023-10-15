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
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una de las opciones:";
            // 
            // buttonConsultaDeDisponibilidad
            // 
            buttonConsultaDeDisponibilidad.Location = new Point(103, 75);
            buttonConsultaDeDisponibilidad.Name = "buttonConsultaDeDisponibilidad";
            buttonConsultaDeDisponibilidad.Size = new Size(206, 62);
            buttonConsultaDeDisponibilidad.TabIndex = 1;
            buttonConsultaDeDisponibilidad.Text = "Consulta de Disponibilidad de Productos";
            buttonConsultaDeDisponibilidad.UseVisualStyleBackColor = true;
            buttonConsultaDeDisponibilidad.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 142);
            button2.Name = "button2";
            button2.Size = new Size(206, 62);
            button2.TabIndex = 2;
            button2.Text = "Armado Itinerarios / Presupuestos";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonGeneracionPreReserva
            // 
            buttonGeneracionPreReserva.Location = new Point(103, 208);
            buttonGeneracionPreReserva.Name = "buttonGeneracionPreReserva";
            buttonGeneracionPreReserva.Size = new Size(206, 62);
            buttonGeneracionPreReserva.TabIndex = 3;
            buttonGeneracionPreReserva.Text = "Generación de Pre Reserva";
            buttonGeneracionPreReserva.UseVisualStyleBackColor = true;
            buttonGeneracionPreReserva.Click += buttonGeneracionPreReserva_Click;
            // 
            // buttonConfirmacionReserva
            // 
            buttonConfirmacionReserva.Location = new Point(103, 277);
            buttonConfirmacionReserva.Name = "buttonConfirmacionReserva";
            buttonConfirmacionReserva.Size = new Size(206, 62);
            buttonConfirmacionReserva.TabIndex = 4;
            buttonConfirmacionReserva.Text = "Confirmación de Reservas";
            buttonConfirmacionReserva.UseVisualStyleBackColor = true;
            buttonConfirmacionReserva.Click += buttonbuttonConfirmacionReserva_Click;
            // 
            // buttonConsultaEstadoReserva
            // 
            buttonConsultaEstadoReserva.Location = new Point(103, 343);
            buttonConsultaEstadoReserva.Name = "buttonConsultaEstadoReserva";
            buttonConsultaEstadoReserva.Size = new Size(206, 62);
            buttonConsultaEstadoReserva.TabIndex = 5;
            buttonConsultaEstadoReserva.Text = "Consultar Estado de Reservas";
            buttonConsultaEstadoReserva.UseVisualStyleBackColor = true;
            buttonConsultaEstadoReserva.Click += buttonConsultaEstadoReserva_Click;
            // 
            // button6
            // 
            button6.Location = new Point(569, 411);
            button6.Name = "button6";
            button6.Size = new Size(206, 62);
            button6.TabIndex = 6;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmacionItinerario
            // 
            buttonConfirmacionItinerario.Location = new Point(103, 411);
            buttonConfirmacionItinerario.Name = "buttonConfirmacionItinerario";
            buttonConfirmacionItinerario.Size = new Size(206, 62);
            buttonConfirmacionItinerario.TabIndex = 7;
            buttonConfirmacionItinerario.Text = "Confirmación Itinerario";
            buttonConfirmacionItinerario.UseVisualStyleBackColor = true;
            buttonConfirmacionItinerario.Click += buttonConfirmacionItinerario_Click;
            // 
            // FormMenuPpal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 527);
            Controls.Add(buttonConfirmacionItinerario);
            Controls.Add(button6);
            Controls.Add(buttonConsultaEstadoReserva);
            Controls.Add(buttonConfirmacionReserva);
            Controls.Add(buttonGeneracionPreReserva);
            Controls.Add(button2);
            Controls.Add(buttonConsultaDeDisponibilidad);
            Controls.Add(label1);
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