namespace AgenciaViajes_Prototipo_G5
{
    partial class ConfirmacionItinerario
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
            textBoxFechaActual = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            buttonConfItinerario = new Button();
            buttonVolverAtrasConfItinerario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "Número de Itinerario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 39);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 2;
            label2.Text = "Número Pre-Reserva";
            // 
            // textBoxFechaActual
            // 
            textBoxFechaActual.Location = new Point(547, 82);
            textBoxFechaActual.Name = "textBoxFechaActual";
            textBoxFechaActual.Size = new Size(153, 31);
            textBoxFechaActual.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 39);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha Actual";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(43, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 186);
            label4.Name = "label4";
            label4.Size = new Size(276, 25);
            label4.TabIndex = 6;
            label4.Text = "Fecha Primer Partida del Itinerario";
            // 
            // buttonConfItinerario
            // 
            buttonConfItinerario.Location = new Point(320, 318);
            buttonConfItinerario.Name = "buttonConfItinerario";
            buttonConfItinerario.Size = new Size(175, 72);
            buttonConfItinerario.TabIndex = 8;
            buttonConfItinerario.Text = "Confirmar y Guardar Cambio";
            buttonConfItinerario.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtrasConfItinerario
            // 
            buttonVolverAtrasConfItinerario.Location = new Point(539, 318);
            buttonVolverAtrasConfItinerario.Name = "buttonVolverAtrasConfItinerario";
            buttonVolverAtrasConfItinerario.Size = new Size(175, 72);
            buttonVolverAtrasConfItinerario.TabIndex = 9;
            buttonVolverAtrasConfItinerario.Text = "Volver Atras";
            buttonVolverAtrasConfItinerario.UseVisualStyleBackColor = true;
            buttonVolverAtrasConfItinerario.Click += buttonVolverAtrasConfItinerario_Click;
            // 
            // ConfirmacionItinerario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolverAtrasConfItinerario);
            Controls.Add(buttonConfItinerario);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBoxFechaActual);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ConfirmacionItinerario";
            Text = "Confirmacion Itinerario";
            Load += ConfirmacionItinerario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBoxFechaActual;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button buttonConfItinerario;
        private Button buttonVolverAtrasConfItinerario;
    }
}