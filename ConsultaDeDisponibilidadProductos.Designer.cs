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
            label5 = new Label();
            label6 = new Label();
            dateTimePickerIda = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label15 = new Label();
            button2 = new Button();
            hotelesButton = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            vuelosButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de personas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Adultos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 69);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Menores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 69);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Infantes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox1.Location = new Point(109, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(46, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            label6.Location = new Point(80, 154);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 8;
            label6.Text = "Ida";
            // 
            // dateTimePickerIda
            // 
            dateTimePickerIda.CustomFormat = "dd/MM/yyyy";
            dateTimePickerIda.Location = new Point(109, 148);
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
            label7.Location = new Point(263, 154);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 10;
            label7.Text = "Vuelta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 212);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 12;
            label8.Text = "Origen y Destino";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(286, 256);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 13;
            label9.Text = "Destino";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 256);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 14;
            label10.Text = "Origen";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 279);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 15;
            label11.Text = "Pais";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(55, 311);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 16;
            label12.Text = "Ciudad";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Argentina" });
            comboBox4.Location = new Point(110, 276);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(113, 23);
            comboBox4.TabIndex = 19;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Buenos Aires" });
            comboBox5.Location = new Point(110, 308);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(113, 23);
            comboBox5.TabIndex = 20;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(55, 366);
            label15.Name = "label15";
            label15.Size = new Size(90, 15);
            label15.TabIndex = 23;
            label15.Text = "Tipo de Servicio";
            // 
            // button2
            // 
            button2.Location = new Point(586, 343);
            button2.Name = "button2";
            button2.Size = new Size(112, 79);
            button2.TabIndex = 26;
            button2.Text = "Regresar a Menú Principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonBackMenu_Click;
            // 
            // hotelesButton
            // 
            hotelesButton.Location = new Point(80, 384);
            hotelesButton.Name = "hotelesButton";
            hotelesButton.Size = new Size(163, 38);
            hotelesButton.TabIndex = 27;
            hotelesButton.Text = "Hoteles";
            hotelesButton.UseVisualStyleBackColor = true;
            hotelesButton.Click += hotelesButton_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox2.Location = new Point(229, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(46, 23);
            comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox3.Location = new Point(343, 66);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(46, 23);
            comboBox3.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(309, 148);
            dateTimePicker1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 23);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.Value = new DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Mendoza" });
            comboBox6.Location = new Point(343, 308);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(113, 23);
            comboBox6.TabIndex = 34;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Argentina" });
            comboBox7.Location = new Point(343, 276);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(113, 23);
            comboBox7.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(286, 311);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 32;
            label13.Text = "Ciudad";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(286, 279);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 31;
            label14.Text = "Pais";
            // 
            // vuelosButton
            // 
            vuelosButton.Location = new Point(270, 384);
            vuelosButton.Name = "vuelosButton";
            vuelosButton.Size = new Size(163, 38);
            vuelosButton.TabIndex = 36;
            vuelosButton.Text = "Vuelos";
            vuelosButton.UseVisualStyleBackColor = true;
            vuelosButton.Click += vuelosButton_Click;
            // 
            // ConsultaDeDisponibilidadProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 463);
            Controls.Add(vuelosButton);
            Controls.Add(comboBox6);
            Controls.Add(comboBox7);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(hotelesButton);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePickerIda);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerIda;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label15;
        private Button button2;
        private Button hotelesButton;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label13;
        private Label label14;
        private Button vuelosButton;
    }
}