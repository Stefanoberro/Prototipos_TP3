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
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = " Número Pre-Reserva";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 94);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 2;
            label2.Text = "Número de Itinerario";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 159);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 4;
            label3.Text = "Total a Abonar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 213);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 6;
            label4.Text = "Número de Factura";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(588, 36);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 31);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 39);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Pre-Reserva";
            // 
            // buttonVerEstado
            // 
            buttonVerEstado.Location = new Point(54, 272);
            buttonVerEstado.Name = "buttonVerEstado";
            buttonVerEstado.Size = new Size(150, 66);
            buttonVerEstado.TabIndex = 10;
            buttonVerEstado.Text = "Ver Estado";
            buttonVerEstado.UseVisualStyleBackColor = true;
            buttonVerEstado.Click += buttonVerEstado_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(223, 272);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(148, 66);
            buttonModificar.TabIndex = 11;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarPreReserva
            // 
            buttonCancelarPreReserva.Location = new Point(393, 272);
            buttonCancelarPreReserva.Name = "buttonCancelarPreReserva";
            buttonCancelarPreReserva.Size = new Size(176, 66);
            buttonCancelarPreReserva.TabIndex = 12;
            buttonCancelarPreReserva.Text = "Cancelar Pre-Reserva";
            buttonCancelarPreReserva.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(591, 272);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(157, 66);
            buttonVolverAtras.TabIndex = 13;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            // 
            // buttonVerListadoPreReserva
            // 
            buttonVerListadoPreReserva.Location = new Point(307, 353);
            buttonVerListadoPreReserva.Name = "buttonVerListadoPreReserva";
            buttonVerListadoPreReserva.Size = new Size(171, 69);
            buttonVerListadoPreReserva.TabIndex = 14;
            buttonVerListadoPreReserva.Text = "Ver Listado Pre-Reserva";
            buttonVerListadoPreReserva.UseVisualStyleBackColor = true;
            // 
            // FormPreReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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