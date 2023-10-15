namespace AgenciaViajes_Prototipo_G5
{
    partial class ListadoOfertaHoteleria
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(145, 204);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 47);
            button1.TabIndex = 0;
            button1.Text = "Ver Disponibilidad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 262);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(135, 47);
            button2.TabIndex = 1;
            button2.Text = "Ver Servicios Extra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(437, 204);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(135, 47);
            button3.TabIndex = 2;
            button3.Text = "Guardar Opción Seleccionada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(437, 262);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(135, 47);
            button4.TabIndex = 3;
            button4.Text = "Volver a la búsqueda";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1  |  Hotel 1 | Buenos Aires |  Juramento 2552  | 3 estrellas" });
            checkedListBox1.Location = new Point(99, 62);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(512, 112);
            checkedListBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 34);
            label2.Name = "label2";
            label2.Size = new Size(279, 15);
            label2.TabIndex = 5;
            label2.Text = "Codigo | Nombre | Ciudad | Direccion | Calificacion ";
            // 
            // ListadoOfertaHoteleria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoOfertaHoteleria";
            Text = "ListadoOfertaHoteleria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
    }
}