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
            listView1 = new ListView();
            columnHeaderNumIti = new ColumnHeader();
            columnHeaderNomCliente = new ColumnHeader();
            columnHeaderFechaInicioIti = new ColumnHeader();
            columnHeaderConfirmIti = new ColumnHeader();
            buttonCrearItinNuevo = new Button();
            buttonVerItinPresup = new Button();
            buttonVolverAtras = new Button();
            buttonGenerarPreReserva = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderNumIti, columnHeaderNomCliente, columnHeaderFechaInicioIti, columnHeaderConfirmIti });
            listView1.Location = new Point(35, 15);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(512, 122);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderNumIti
            // 
            columnHeaderNumIti.Text = "Número Itinerario";
            columnHeaderNumIti.Width = 160;
            // 
            // columnHeaderNomCliente
            // 
            columnHeaderNomCliente.Text = "Nombre Cliente";
            columnHeaderNomCliente.TextAlign = HorizontalAlignment.Center;
            columnHeaderNomCliente.Width = 180;
            // 
            // columnHeaderFechaInicioIti
            // 
            columnHeaderFechaInicioIti.Text = "Fecha Inicio Itinerario";
            columnHeaderFechaInicioIti.Width = 180;
            // 
            // columnHeaderConfirmIti
            // 
            columnHeaderConfirmIti.Text = "Confirmación Itinerario";
            columnHeaderConfirmIti.Width = 200;
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
            // ListadoItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 270);
            Controls.Add(buttonGenerarPreReserva);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonVerItinPresup);
            Controls.Add(buttonCrearItinNuevo);
            Controls.Add(listView1);
            Margin = new Padding(2);
            Name = "ListadoItinerario";
            Text = "Listado de itinerarios";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeaderNumIti;
        private ColumnHeader columnHeaderNomCliente;
        private ColumnHeader columnHeaderFechaInicioIti;
        private ColumnHeader columnHeaderConfirmIti;
        private Button buttonCrearItinNuevo;
        private Button buttonVerItinPresup;
        private Button buttonVolverAtras;
        private Button buttonGenerarPreReserva;
    }
}