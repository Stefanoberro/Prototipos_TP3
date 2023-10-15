namespace AgenciaViajes_Prototipo_G5
{
    partial class FormGeneracionPreReserva
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
            listView1.Location = new Point(50, 25);
            listView1.Name = "listView1";
            listView1.Size = new Size(729, 200);
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
            buttonCrearItinNuevo.Location = new Point(50, 312);
            buttonCrearItinNuevo.Name = "buttonCrearItinNuevo";
            buttonCrearItinNuevo.Size = new Size(151, 77);
            buttonCrearItinNuevo.TabIndex = 1;
            buttonCrearItinNuevo.Text = "Crear Itinerario Nuevo";
            buttonCrearItinNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonVerItinPresup
            // 
            buttonVerItinPresup.Location = new Point(243, 312);
            buttonVerItinPresup.Name = "buttonVerItinPresup";
            buttonVerItinPresup.Size = new Size(151, 77);
            buttonVerItinPresup.TabIndex = 2;
            buttonVerItinPresup.Text = "Ver Itinerario y presupuesto";
            buttonVerItinPresup.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(628, 312);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(151, 77);
            buttonVolverAtras.TabIndex = 3;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarPreReserva
            // 
            buttonGenerarPreReserva.Location = new Point(437, 312);
            buttonGenerarPreReserva.Name = "buttonGenerarPreReserva";
            buttonGenerarPreReserva.Size = new Size(151, 77);
            buttonGenerarPreReserva.TabIndex = 4;
            buttonGenerarPreReserva.Text = "Generar Pre-Reserva";
            buttonGenerarPreReserva.UseVisualStyleBackColor = true;
            // 
            // FormGeneracionPreReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(buttonGenerarPreReserva);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonVerItinPresup);
            Controls.Add(buttonCrearItinNuevo);
            Controls.Add(listView1);
            Name = "FormGeneracionPreReserva";
            Text = "Generación Pre-Reserva";
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