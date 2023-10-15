namespace AgenciaViajes_Prototipo_G5
{
    partial class ElegirAdicionalesPaqueteTuristico
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista Adicionales";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Almuerzo", "Show en vivo" });
            checkedListBox1.Location = new Point(41, 78);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(272, 94);
            checkedListBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(189, 195);
            button1.Name = "button1";
            button1.Size = new Size(124, 43);
            button1.TabIndex = 2;
            button1.Text = "Regresar a Paquetes Turisticos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(65, 195);
            button2.Name = "button2";
            button2.Size = new Size(96, 43);
            button2.TabIndex = 3;
            button2.Text = "Agregar Adicionales";
            button2.UseVisualStyleBackColor = true;
            // 
            // ElegirAdicionalesPaqueteTuristico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 267);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "ElegirAdicionalesPaqueteTuristico";
            Text = "ElegirAdicionalesPaqueteTuristico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
    }
}