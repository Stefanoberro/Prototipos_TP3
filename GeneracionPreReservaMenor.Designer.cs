namespace AgenciaViajes_Prototipo_G5
{
    partial class GeneracionPreReservaMenor
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
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(220, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(131, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // button3
            // 
            button3.Location = new Point(299, 317);
            button3.Name = "button3";
            button3.Size = new Size(126, 44);
            button3.TabIndex = 33;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 317);
            button2.Name = "button2";
            button2.Size = new Size(126, 44);
            button2.TabIndex = 32;
            button2.Text = "Confirmar pre-reserva";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 317);
            button1.Name = "button1";
            button1.Size = new Size(126, 44);
            button1.TabIndex = 31;
            button1.Text = "Cargar otra persona";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(220, 71);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(131, 23);
            textBox8.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 74);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 29;
            label9.Text = "Nombre";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(220, 100);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(131, 23);
            textBox7.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 103);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 27;
            label8.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 132);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 26;
            label7.Text = "Fecha de nacimiento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 45);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 24;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 23;
            label1.Text = "Menores";
            // 
            // GeneracionPreReservaMenor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 392);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GeneracionPreReservaMenor";
            Text = "GeneracionPreReservasMenor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private Label label7;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}