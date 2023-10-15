namespace AgenciaViajes_Prototipo_G5
{
    partial class ListadoOfertaCrucero
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 0;
            label1.Text = "Origen | Destino |Fecha Salida | Fecha llegada";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "BUE44    |  MED184    | 20/10/2023        | 30/10/2023" });
            checkedListBox1.Location = new Point(33, 71);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(317, 40);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(33, 143);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 2;
            button1.Text = "Ver Paradas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 202);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 3;
            button2.Text = "Ver Tarifa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(250, 143);
            button3.Name = "button3";
            button3.Size = new Size(100, 39);
            button3.TabIndex = 4;
            button3.Text = "Guardar opcion seleccionada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(250, 202);
            button4.Name = "button4";
            button4.Size = new Size(100, 39);
            button4.TabIndex = 5;
            button4.Text = "Regresar a Busqueda";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ListadoOfertaCrucero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 253);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "ListadoOfertaCrucero";
            Text = "ListadoOfertaCrucero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}