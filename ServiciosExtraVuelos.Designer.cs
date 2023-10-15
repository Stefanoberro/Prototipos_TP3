namespace AgenciaViajes_Prototipo_G5
{
    partial class ServiciosExtraVuelos
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
            listBox1 = new ListBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 45);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Servicio Extra";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(34, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 49);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 76);
            label2.Name = "label2";
            label2.Size = new Size(274, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo |    Nombre    |    Descripcion    |    Precios   |";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(34, 184);
            button1.Name = "button1";
            button1.Size = new Size(132, 49);
            button1.TabIndex = 3;
            button1.Text = "Agregar Servicio Extra";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(277, 184);
            button2.Name = "button2";
            button2.Size = new Size(132, 49);
            button2.TabIndex = 4;
            button2.Text = "Regresar Oferta Vuelos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ServiciosExtraVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 245);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "ServiciosExtraVuelos";
            Text = "ServiciosExtraVuelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}