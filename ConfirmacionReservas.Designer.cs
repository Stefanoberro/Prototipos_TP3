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
            listView1.Location = new Point(64, 37);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(544, 126);
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
            buttonConfirmarPreReserva.Location = new Point(148, 200);
            buttonConfirmarPreReserva.Margin = new Padding(2, 2, 2, 2);
            buttonConfirmarPreReserva.Name = "buttonConfirmarPreReserva";
            buttonConfirmarPreReserva.Size = new Size(122, 46);
            buttonConfirmarPreReserva.TabIndex = 1;
            buttonConfirmarPreReserva.Text = "Confirmar Pre Reserva";
            buttonConfirmarPreReserva.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(399, 200);
            buttonVolverAtras.Margin = new Padding(2, 2, 2, 2);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(122, 46);
            buttonVolverAtras.TabIndex = 2;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // ConfirmacionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 270);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonConfirmarPreReserva);
            Controls.Add(listView1);
            Margin = new Padding(2, 2, 2, 2);
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