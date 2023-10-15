namespace AgenciaViajes_Prototipo_G5
{
    partial class VerPaqueteTuristico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPaqueteTuristico));
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
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(924, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Paq. |  Código Origen | Código Destino | Fecha Inicio | Fecha Fin | Cant. Adulto Permitido | Cant. Menores Permitido | Cant. Infantes Permitido | Disponibilidad Paquete";
            label1.Click += label1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { resources.GetString("checkedListBox1.Items") });
            checkedListBox1.Location = new Point(25, 68);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(1020, 94);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 210);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 244);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 329);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Destino";
            // 
            // listView1
            // 
            listView1.AutoArrange = false;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(103, 235);
            listView1.Name = "listView1";
            listView1.Size = new Size(66, 48);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.AutoArrange = false;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView2.Location = new Point(103, 309);
            listView2.Name = "listView2";
            listView2.Size = new Size(66, 35);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(25, 399);
            button1.Name = "button1";
            button1.Size = new Size(155, 39);
            button1.TabIndex = 7;
            button1.Text = "Guardar opción seleccionada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(408, 399);
            button2.Name = "button2";
            button2.Size = new Size(118, 39);
            button2.TabIndex = 8;
            button2.Text = "Ver Actividades";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(572, 399);
            button3.Name = "button3";
            button3.Size = new Size(113, 39);
            button3.TabIndex = 9;
            button3.Text = "Ver Adicionales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(737, 399);
            button4.Name = "button4";
            button4.Size = new Size(116, 39);
            button4.TabIndex = 10;
            button4.Text = "Ver Tarifa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(905, 399);
            button5.Name = "button5";
            button5.Size = new Size(155, 39);
            button5.TabIndex = 11;
            button5.Text = "Regresar a Búsqueda";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // VerPaqueteTuristico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 450);
            Controls.Add(button5);
            Controls.Add(button4);
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
            Name = "VerPaqueteTuristico";
            Text = "VerPaqueteTuristico";
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
        private Button button4;
        private Button button5;
    }
}