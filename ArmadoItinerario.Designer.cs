namespace AgenciaViajes_Prototipo_G5
{
    partial class FormArmadoItinerario
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
            labelNumIti = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            groupBoxServAereo = new GroupBox();
            buttonImpAereo = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            groupBoxServHotel = new GroupBox();
            listView3 = new ListView();
            columnHeader15 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            buttonImpHotel = new Button();
            label4 = new Label();
            textBox5 = new TextBox();
            buttonGenerarPreRese = new Button();
            buttonGuardarIti = new Button();
            buttonVolverAtras = new Button();
            label6 = new Label();
            textBox7 = new TextBox();
            groupBoxServAereo.SuspendLayout();
            groupBoxServHotel.SuspendLayout();
            SuspendLayout();
            // 
            // labelNumIti
            // 
            labelNumIti.AutoSize = true;
            labelNumIti.Location = new Point(40, 18);
            labelNumIti.Name = "labelNumIti";
            labelNumIti.Size = new Size(105, 15);
            labelNumIti.TabIndex = 0;
            labelNumIti.Text = "Número Itinerario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 24);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(594, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 24);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 18);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Fecha Inicio Itinerario";
            // 
            // groupBoxServAereo
            // 
            groupBoxServAereo.Controls.Add(buttonImpAereo);
            groupBoxServAereo.Controls.Add(label2);
            groupBoxServAereo.Controls.Add(textBox3);
            groupBoxServAereo.Controls.Add(listView1);
            groupBoxServAereo.Location = new Point(17, 57);
            groupBoxServAereo.Name = "groupBoxServAereo";
            groupBoxServAereo.Size = new Size(1071, 147);
            groupBoxServAereo.TabIndex = 4;
            groupBoxServAereo.TabStop = false;
            groupBoxServAereo.Text = "Servicios Aéreos";
            // 
            // buttonImpAereo
            // 
            buttonImpAereo.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImpAereo.Location = new Point(861, 98);
            buttonImpAereo.Name = "buttonImpAereo";
            buttonImpAereo.Size = new Size(190, 42);
            buttonImpAereo.TabIndex = 7;
            buttonImpAereo.Text = "Impuesto Aéreo";
            buttonImpAereo.UseVisualStyleBackColor = true;
            buttonImpAereo.Click += buttonImpAereo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(859, 25);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Subtotal";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(859, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 24);
            textBox3.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(25, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(805, 81);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Aerolínea";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Origen";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destino";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salida";
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Arribo";
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Asiento";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Vuelo";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tarifa";
            columnHeader8.Width = 90;
            // 
            // groupBoxServHotel
            // 
            groupBoxServHotel.Controls.Add(listView3);
            groupBoxServHotel.Controls.Add(buttonImpHotel);
            groupBoxServHotel.Controls.Add(label4);
            groupBoxServHotel.Controls.Add(textBox5);
            groupBoxServHotel.Location = new Point(17, 224);
            groupBoxServHotel.Name = "groupBoxServHotel";
            groupBoxServHotel.Size = new Size(1071, 147);
            groupBoxServHotel.TabIndex = 5;
            groupBoxServHotel.TabStop = false;
            groupBoxServHotel.Text = "Servicios Hotelería";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader15, columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23 });
            listView3.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView3.Location = new Point(25, 54);
            listView3.Name = "listView3";
            listView3.Size = new Size(805, 81);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Código";
            columnHeader15.Width = 70;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Nombre";
            columnHeader17.Width = 90;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Ciudad";
            columnHeader18.Width = 90;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Dirección";
            columnHeader19.Width = 100;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "CheckIn";
            columnHeader20.Width = 90;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "CheckOut";
            columnHeader21.Width = 90;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Hab.";
            columnHeader22.Width = 70;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Tarifa";
            // 
            // buttonImpHotel
            // 
            buttonImpHotel.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImpHotel.Location = new Point(875, 99);
            buttonImpHotel.Name = "buttonImpHotel";
            buttonImpHotel.Size = new Size(190, 42);
            buttonImpHotel.TabIndex = 13;
            buttonImpHotel.Text = "Impuesto Hotel";
            buttonImpHotel.UseVisualStyleBackColor = true;
            buttonImpHotel.Click += buttonImpHotel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(873, 26);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Subtotal";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(873, 54);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(183, 24);
            textBox5.TabIndex = 12;
            // 
            // buttonGenerarPreRese
            // 
            buttonGenerarPreRese.Location = new Point(35, 399);
            buttonGenerarPreRese.Name = "buttonGenerarPreRese";
            buttonGenerarPreRese.Size = new Size(206, 62);
            buttonGenerarPreRese.TabIndex = 6;
            buttonGenerarPreRese.Text = "Generar Pre-Reserva";
            buttonGenerarPreRese.UseVisualStyleBackColor = true;
            buttonGenerarPreRese.Click += buttonGenerarPreRese_Click;
            // 
            // buttonGuardarIti
            // 
            buttonGuardarIti.Location = new Point(285, 399);
            buttonGuardarIti.Name = "buttonGuardarIti";
            buttonGuardarIti.Size = new Size(206, 62);
            buttonGuardarIti.TabIndex = 7;
            buttonGuardarIti.Text = "Guardar Itinerario";
            buttonGuardarIti.UseVisualStyleBackColor = true;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(529, 399);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(206, 62);
            buttonVolverAtras.TabIndex = 8;
            buttonVolverAtras.Text = "Volver Atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(861, 401);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 17;
            label6.Text = "Tarifa Total a Abonar";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(861, 429);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(183, 24);
            textBox7.TabIndex = 18;
            // 
            // FormArmadoItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1099, 494);
            Controls.Add(label6);
            Controls.Add(buttonVolverAtras);
            Controls.Add(textBox7);
            Controls.Add(buttonGuardarIti);
            Controls.Add(buttonGenerarPreRese);
            Controls.Add(groupBoxServHotel);
            Controls.Add(groupBoxServAereo);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelNumIti);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "FormArmadoItinerario";
            Text = "Armado Itinerario";
            groupBoxServAereo.ResumeLayout(false);
            groupBoxServAereo.PerformLayout();
            groupBoxServHotel.ResumeLayout(false);
            groupBoxServHotel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumIti;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private GroupBox groupBoxServAereo;
        private Label label2;
        private TextBox textBox3;
        private ListView listView1;
        private GroupBox groupBoxServHotel;
        private Button buttonImpAereo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView listView3;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private Button buttonImpHotel;
        private Label label4;
        private TextBox textBox5;
        private ColumnHeader columnHeader23;
        private Button buttonGenerarPreRese;
        private Button buttonGuardarIti;
        private Button buttonVolverAtras;
        private Label label6;
        private TextBox textBox7;
    }
}