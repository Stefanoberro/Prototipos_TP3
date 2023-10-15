namespace AgenciaViajes_Prototipo_G5
{
    partial class ConfirmacionReservas
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
            NumeroPrePreserva = new ColumnHeader();
            NombreCliente = new ColumnHeader();
            FechaPreReserva = new ColumnHeader();
            buttonConfirmarPreReserva = new Button();
            buttonVolverAtras = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroPrePreserva, NombreCliente, FechaPreReserva });
            listView1.Location = new Point(91, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(556, 207);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroPrePreserva
            // 
            NumeroPrePreserva.Text = "Numero Pre Reserva";
            NumeroPrePreserva.Width = 180;
            // 
            // NombreCliente
            // 
            NombreCliente.Text = "Nombre de Cliente";
            NombreCliente.Width = 180;
            // 
            // FechaPreReserva
            // 
            FechaPreReserva.Text = "Fecha Pre Reserva";
            FechaPreReserva.Width = 180;
            // 
            // buttonConfirmarPreReserva
            // 
            buttonConfirmarPreReserva.Location = new Point(123, 333);
            buttonConfirmarPreReserva.Name = "buttonConfirmarPreReserva";
            buttonConfirmarPreReserva.Size = new Size(175, 76);
            buttonConfirmarPreReserva.TabIndex = 1;
            buttonConfirmarPreReserva.Text = "Confirmar Pre Reserva";
            buttonConfirmarPreReserva.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(424, 333);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(175, 76);
            buttonVolverAtras.TabIndex = 2;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // ConfirmacionReservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonConfirmarPreReserva);
            Controls.Add(listView1);
            Name = "ConfirmacionReservas";
            Text = "Confirmación de Reservas";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader NumeroPrePreserva;
        private ColumnHeader NombreCliente;
        private ColumnHeader FechaPreReserva;
        private Button buttonConfirmarPreReserva;
        private Button buttonVolverAtras;
    }
}