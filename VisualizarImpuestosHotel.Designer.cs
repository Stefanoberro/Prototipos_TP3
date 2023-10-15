namespace AgenciaViajes_Prototipo_G5
{
    partial class VisualizarImpuestosHotel
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
            textBox6 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            buttonVolverAtras = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(464, 296);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(127, 31);
            textBox6.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 302);
            label8.Name = "label8";
            label8.Size = new Size(157, 25);
            label8.TabIndex = 26;
            label8.Text = "Tarifa total a Pagar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(250, 248);
            label7.Name = "label7";
            label7.Size = new Size(417, 25);
            label7.TabIndex = 25;
            label7.Text = ".................................................................................";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(469, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 31);
            textBox4.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 201);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 21;
            label5.Text = "Impuestos";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(469, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 31);
            textBox3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 146);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 19;
            label4.Text = "Servicios Extras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(367, 43);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 18;
            label3.Text = "Desgloce de Tarifa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(469, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 31);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 92);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 16;
            label2.Text = "Precio Habitación";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 31);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 14;
            label1.Text = "Hotel";
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = SystemColors.ButtonFace;
            buttonVolverAtras.FlatStyle = FlatStyle.Popup;
            buttonVolverAtras.ForeColor = SystemColors.ControlText;
            buttonVolverAtras.Location = new Point(581, 345);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(188, 58);
            buttonVolverAtras.TabIndex = 28;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // VisualizarImpuestosHotel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolverAtras);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "VisualizarImpuestosHotel";
            Text = "Visualizar Impuestos Hotelería";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label8;
        private Label label7;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button buttonVolverAtras;
    }
}