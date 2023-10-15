namespace AgenciaViajes_Prototipo_G5
{
    partial class ListadoVuelosDisponibles
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
            ListViewItem listViewItem1 = new ListViewItem("Buenos Aires");
            ListViewItem listViewItem2 = new ListViewItem("Medellín");
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            listView3 = new ListView();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(773, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Oferta  | Aerolínea |  Código Origen | Código Destino   | Paradas    | Fecha Salida |   Fecha Arribo |  TiempoVuelo | Codigo Vuelo | Tarifa base";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "AF30     | JETSMART     | BUE        | MED       | 0         | 20/10/2023      | 25/10/2023      | 3 Hs      | RR502    | $100000" });
            checkedListBox1.Location = new Point(12, 72);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(773, 40);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 175);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Destino";
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(61, 175);
            listView1.Name = "listView1";
            listView1.Size = new Size(87, 44);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listView2
            // 
            listView2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView2.Location = new Point(278, 175);
            listView2.Name = "listView2";
            listView2.Size = new Size(121, 44);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(86, 262);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 7;
            button1.Text = "Ver Servicios Extra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(278, 262);
            button2.Name = "button2";
            button2.Size = new Size(134, 34);
            button2.TabIndex = 8;
            button2.Text = "Ver Paradas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(265, 373);
            button3.Name = "button3";
            button3.Size = new Size(134, 33);
            button3.TabIndex = 9;
            button3.Text = "Ver Informacion Tarifa";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 382);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Tarifa TOTAL";
            // 
            // listView3
            // 
            listView3.Location = new Point(99, 370);
            listView3.Name = "listView3";
            listView3.Size = new Size(121, 36);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            button4.Location = new Point(582, 345);
            button4.Name = "button4";
            button4.Size = new Size(134, 43);
            button4.TabIndex = 12;
            button4.Text = "Regresar a Busqueda";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(582, 262);
            button5.Name = "button5";
            button5.Size = new Size(134, 43);
            button5.TabIndex = 13;
            button5.Text = "Guardar Opcion Seleccionada";
            button5.UseVisualStyleBackColor = true;
            // 
            // ListadoVuelosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listView3);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "ListadoVuelosDisponibles";
            Text = "ListadoVuelosDisponibles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private ListView listView2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private ListView listView3;
        private Button button4;
        private Button button5;
    }
}