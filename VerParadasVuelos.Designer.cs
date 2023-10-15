namespace AgenciaViajes_Prototipo_G5
{
    partial class VerParadasVuelos
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
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de Paradas del Vuelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(339, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo      ||        Aeropuerto        ||         Tiempo de Parada         ||";
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 105);
            listView1.Name = "listView1";
            listView1.Size = new Size(435, 75);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(28, 220);
            button1.Name = "button1";
            button1.Size = new Size(152, 63);
            button1.TabIndex = 3;
            button1.Text = "Regresar a Ofertas de Vuelos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VerParadasVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 318);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VerParadasVuelos";
            Text = "VerParadasVuelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private Button button1;
    }
}