namespace AgenciaViajes_Prototipo_G5
{
    partial class VerTarifa
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
            ListViewItem listViewItem1 = new ListViewItem("Premium  | $150000 | 4 | 1 | 3 | 0 | 5");
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Name = "label1";
            label1.Size = new Size(703, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Tarifa | Tarifa | Capacidad Tarifa Cant. Adulto Permitido | Cant. Menores Permitido | Cant. Infantes Permitido | Disponibilidad";
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.LabelWrap = false;
            listView1.Location = new Point(35, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(703, 97);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(538, 225);
            button1.Name = "button1";
            button1.Size = new Size(200, 57);
            button1.TabIndex = 2;
            button1.Text = "Regresar a Cruceros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VerTarifa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 306);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "VerTarifa";
            Text = "VerTarifa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
    }
}