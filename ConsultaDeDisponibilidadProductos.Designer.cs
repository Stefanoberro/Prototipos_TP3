namespace AgenciaViajes_Prototipo_G5
{
    partial class ConsultaDeDisponibilidadProductos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePickerIda = new DateTimePicker();
            label7 = new Label();
            dateTimePickerVuelta = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            label15 = new Label();
            comboBox8 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            seleccionarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 39);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de personas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 74);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Adultos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 74);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Menores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 74);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Infantes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1" });
            comboBox1.Location = new Point(109, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(35, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1" });
            comboBox2.Location = new Point(239, 71);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(35, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "0" });
            comboBox3.Location = new Point(353, 71);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(35, 23);
            comboBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 130);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Fechas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 173);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 8;
            label6.Text = "Ida";
            // 
            // dateTimePickerIda
            // 
            dateTimePickerIda.CustomFormat = "dd/MM/yyyy";
            dateTimePickerIda.Location = new Point(109, 167);
            dateTimePickerIda.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePickerIda.MinDate = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            dateTimePickerIda.Name = "dateTimePickerIda";
            dateTimePickerIda.Size = new Size(124, 23);
            dateTimePickerIda.TabIndex = 9;
            dateTimePickerIda.Value = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            dateTimePickerIda.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 173);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 10;
            label7.Text = "Vuelta";
            // 
            // dateTimePickerVuelta
            // 
            dateTimePickerVuelta.Location = new Point(353, 167);
            dateTimePickerVuelta.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePickerVuelta.MinDate = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            dateTimePickerVuelta.Name = "dateTimePickerVuelta";
            dateTimePickerVuelta.Size = new Size(124, 23);
            dateTimePickerVuelta.TabIndex = 11;
            dateTimePickerVuelta.Value = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 241);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 12;
            label8.Text = "Origen y Destino";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(288, 279);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 13;
            label9.Text = "Destino";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 279);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 14;
            label10.Text = "Origen";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 306);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 15;
            label11.Text = "Pais";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 345);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 16;
            label12.Text = "Ciudad";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(288, 306);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 17;
            label13.Text = "Pais";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(288, 345);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 18;
            label14.Text = "Ciudad";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Argentina" });
            comboBox4.Location = new Point(120, 303);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(113, 23);
            comboBox4.TabIndex = 19;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Colombia" });
            comboBox5.Location = new Point(120, 337);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(113, 23);
            comboBox5.TabIndex = 20;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Buenos Aires" });
            comboBox6.Location = new Point(376, 303);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(113, 23);
            comboBox6.TabIndex = 21;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Medellín" });
            comboBox7.Location = new Point(376, 342);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(113, 23);
            comboBox7.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(58, 393);
            label15.Name = "label15";
            label15.Size = new Size(90, 15);
            label15.TabIndex = 23;
            label15.Text = "Tipo de Servicio";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Vuelo" });
            comboBox8.Location = new Point(63, 432);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(113, 23);
            comboBox8.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(586, 66);
            button1.Name = "button1";
            button1.Size = new Size(112, 79);
            button1.TabIndex = 25;
            button1.Text = "Ver Paquete Turistico";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(586, 393);
            button2.Name = "button2";
            button2.Size = new Size(112, 79);
            button2.TabIndex = 26;
            button2.Text = "Regresar a Menú Principal";
            button2.UseVisualStyleBackColor = true;
            // 
            // seleccionarButton
            // 
            seleccionarButton.Location = new Point(314, 434);
            seleccionarButton.Name = "seleccionarButton";
            seleccionarButton.Size = new Size(163, 38);
            seleccionarButton.TabIndex = 27;
            seleccionarButton.Text = "Seleccionar";
            seleccionarButton.UseVisualStyleBackColor = true;
            seleccionarButton.Click += seleccionarButton_Click;
            // 
            // ConsultaDeDisponibilidadProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(seleccionarButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox8);
            Controls.Add(label15);
            Controls.Add(comboBox7);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dateTimePickerVuelta);
            Controls.Add(label7);
            Controls.Add(dateTimePickerIda);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaDeDisponibilidadProductos";
            Text = "ConsultaDeDisponibilidadProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerIda;
        private Label label7;
        private DateTimePicker dateTimePickerVuelta;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label15;
        private ComboBox comboBox8;
        private Button button1;
        private Button button2;
        private Button seleccionarButton;
    }
}