namespace AgenciaViajes_Prototipo_G5
{
    partial class ListadoItinerario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCrearItinNuevo = new Button();
            buttonVerItinPresup = new Button();
            buttonVolverAtras = new Button();
            buttonGenerarPreReserva = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonCrearItinNuevo
            // 
            buttonCrearItinNuevo.Location = new Point(35, 187);
            buttonCrearItinNuevo.Margin = new Padding(2);
            buttonCrearItinNuevo.Name = "buttonCrearItinNuevo";
            buttonCrearItinNuevo.Size = new Size(106, 46);
            buttonCrearItinNuevo.TabIndex = 1;
            buttonCrearItinNuevo.Text = "Crear Itinerario Nuevo";
            buttonCrearItinNuevo.UseVisualStyleBackColor = true;
            buttonCrearItinNuevo.Click += buttonCrearItinNuevo_Click;
            // 
            // buttonVerItinPresup
            // 
            buttonVerItinPresup.Location = new Point(170, 187);
            buttonVerItinPresup.Margin = new Padding(2);
            buttonVerItinPresup.Name = "buttonVerItinPresup";
            buttonVerItinPresup.Size = new Size(106, 46);
            buttonVerItinPresup.TabIndex = 2;
            buttonVerItinPresup.Text = "Ver Itinerario y presupuesto";
            buttonVerItinPresup.UseVisualStyleBackColor = true;
            buttonVerItinPresup.Click += buttonVerItinPresup_Click;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(440, 187);
            buttonVolverAtras.Margin = new Padding(2);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(106, 46);
            buttonVolverAtras.TabIndex = 3;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // buttonGenerarPreReserva
            // 
            buttonGenerarPreReserva.Location = new Point(306, 187);
            buttonGenerarPreReserva.Margin = new Padding(2);
            buttonGenerarPreReserva.Name = "buttonGenerarPreReserva";
            buttonGenerarPreReserva.Size = new Size(106, 46);
            buttonGenerarPreReserva.TabIndex = 4;
            buttonGenerarPreReserva.Text = "Generar Pre-Reserva";
            buttonGenerarPreReserva.UseVisualStyleBackColor = true;
            buttonGenerarPreReserva.Click += buttonGenerarPreReserva_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "IT001 || Juan Perez || 22/11/2023" });
            listBox1.Location = new Point(42, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(346, 79);
            listBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 33);
            label2.Name = "label2";
            label2.Size = new Size(339, 15);
            label2.TabIndex = 5;
            label2.Text = "Número de itinerario      ||        Nombre Cliente        ||         Inicio del itinerario         ||";
            // 
            // ListadoItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 270);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(buttonGenerarPreReserva);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonVerItinPresup);
            Controls.Add(buttonCrearItinNuevo);
            Margin = new Padding(2);
            Name = "ListadoItinerario";
            Text = "Listado de itinerarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCrearItinNuevo;
        private Button buttonVerItinPresup;
        private Button buttonVolverAtras;
        private Button buttonGenerarPreReserva;
        private ListBox listBox1;
        private Label label2;
    }
}