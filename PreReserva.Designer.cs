namespace AgenciaViajes_Prototipo_G5
{
    partial class FormPreReserva
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            buttonVerEstado = new Button();
            buttonModificar = new Button();
            buttonCancelarPreReserva = new Button();
            buttonVolverAtras = new Button();
            buttonVerListadoPreReserva = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Número Pre-Reserva";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 22);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 49);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Número de Itinerario";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(414, 30);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Total a Abonar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(414, 57);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 66);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "Número de Factura";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(150, 76);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 84);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Pre-Reserva";
            // 
            // buttonVerEstado
            // 
            buttonVerEstado.Location = new Point(37, 120);
            buttonVerEstado.Margin = new Padding(2);
            buttonVerEstado.Name = "buttonVerEstado";
            buttonVerEstado.Size = new Size(105, 40);
            buttonVerEstado.TabIndex = 10;
            buttonVerEstado.Text = "Ver Estado";
            buttonVerEstado.UseVisualStyleBackColor = true;
            buttonVerEstado.Click += buttonVerEstado_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(155, 120);
            buttonModificar.Margin = new Padding(2);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(104, 40);
            buttonModificar.TabIndex = 11;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarPreReserva
            // 
            buttonCancelarPreReserva.Location = new Point(274, 120);
            buttonCancelarPreReserva.Margin = new Padding(2);
            buttonCancelarPreReserva.Name = "buttonCancelarPreReserva";
            buttonCancelarPreReserva.Size = new Size(123, 40);
            buttonCancelarPreReserva.TabIndex = 12;
            buttonCancelarPreReserva.Text = "Cancelar Pre-Reserva";
            buttonCancelarPreReserva.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(413, 120);
            buttonVolverAtras.Margin = new Padding(2);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(110, 40);
            buttonVolverAtras.TabIndex = 13;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // buttonVerListadoPreReserva
            // 
            buttonVerListadoPreReserva.Location = new Point(214, 169);
            buttonVerListadoPreReserva.Margin = new Padding(2);
            buttonVerListadoPreReserva.Name = "buttonVerListadoPreReserva";
            buttonVerListadoPreReserva.Size = new Size(120, 41);
            buttonVerListadoPreReserva.TabIndex = 14;
            buttonVerListadoPreReserva.Text = "Ver Listado Pre-Reserva";
            buttonVerListadoPreReserva.UseVisualStyleBackColor = true;
            // 
            // FormPreReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 223);
            Controls.Add(buttonVerListadoPreReserva);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonCancelarPreReserva);
            Controls.Add(buttonModificar);
            Controls.Add(buttonVerEstado);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormPreReserva";
            Text = "Pre-Reserva";
            Load += FormPreReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button buttonVerEstado;
        private Button buttonModificar;
        private Button buttonCancelarPreReserva;
        private Button buttonVolverAtras;
        private Button buttonVerListadoPreReserva;
    }
}