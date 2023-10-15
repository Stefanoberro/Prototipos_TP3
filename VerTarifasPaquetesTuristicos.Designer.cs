namespace AgenciaViajes_Prototipo_G5
{
    partial class VerTarifasPaquetesTuristicos
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
            ListViewItem listViewItem1 = new ListViewItem("Adultos: $5000");
            ListViewItem listViewItem2 = new ListViewItem("Menores: $2000");
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 41);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Listado de tarifas";
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(32, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(254, 107);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(158, 210);
            button1.Name = "button1";
            button1.Size = new Size(128, 56);
            button1.TabIndex = 2;
            button1.Text = "Regresar a Paquetes Turisticos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VerTarifasPaquetesTuristicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 296);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "VerTarifasPaquetesTuristicos";
            Text = "VerTarifasPaquetesTuristicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
    }
}