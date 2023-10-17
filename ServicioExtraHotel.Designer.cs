namespace AgenciaViajes_Prototipo_G5
{
    partial class ServicioExtraHotel
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(197, 214);
            button2.Name = "button2";
            button2.Size = new Size(132, 49);
            button2.TabIndex = 9;
            button2.Text = "Regresar Oferta Hotelería";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(47, 214);
            button1.Name = "button1";
            button1.Size = new Size(132, 49);
            button1.TabIndex = 8;
            button1.Text = "Agregar Servicio Extra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 69);
            label2.Name = "label2";
            label2.Size = new Size(274, 15);
            label2.TabIndex = 7;
            label2.Text = "Codigo |    Nombre    |    Descripcion    |    Precios   |";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 5;
            label1.Text = "Elegir servicio extra:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1 |  Desayuno continental | Desayuno completo | $5000" });
            checkedListBox1.Location = new Point(75, 94);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(520, 76);
            checkedListBox1.TabIndex = 10;
            // 
            // ServicioExtraHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 314);
            Controls.Add(checkedListBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ServicioExtraHotel";
            Text = "ServicioExtraHotel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}