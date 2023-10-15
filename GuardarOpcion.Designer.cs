namespace AgenciaViajes_Prototipo_G5
{
    partial class GuardarOpcion
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
            buttonNuevoItinerario = new Button();
            buttonItinerarioActual = new Button();
            buttonOtroItinerario = new Button();
            buttonVolverALaBusqueda = new Button();
            SuspendLayout();
            // 
            // buttonNuevoItinerario
            // 
            buttonNuevoItinerario.Location = new Point(20, 55);
            buttonNuevoItinerario.Margin = new Padding(3, 2, 3, 2);
            buttonNuevoItinerario.Name = "buttonNuevoItinerario";
            buttonNuevoItinerario.Size = new Size(131, 41);
            buttonNuevoItinerario.TabIndex = 0;
            buttonNuevoItinerario.Text = "Nuevo Itinerario";
            buttonNuevoItinerario.UseVisualStyleBackColor = true;
            buttonNuevoItinerario.Click += buttonNuevoItinerario_Click;
            // 
            // buttonItinerarioActual
            // 
            buttonItinerarioActual.Location = new Point(173, 55);
            buttonItinerarioActual.Margin = new Padding(3, 2, 3, 2);
            buttonItinerarioActual.Name = "buttonItinerarioActual";
            buttonItinerarioActual.Size = new Size(131, 41);
            buttonItinerarioActual.TabIndex = 1;
            buttonItinerarioActual.Text = "Itinerario Actual";
            buttonItinerarioActual.UseVisualStyleBackColor = true;
            buttonItinerarioActual.Click += buttonItinerarioActual_Click;
            // 
            // buttonOtroItinerario
            // 
            buttonOtroItinerario.Location = new Point(324, 55);
            buttonOtroItinerario.Margin = new Padding(3, 2, 3, 2);
            buttonOtroItinerario.Name = "buttonOtroItinerario";
            buttonOtroItinerario.Size = new Size(131, 41);
            buttonOtroItinerario.TabIndex = 2;
            buttonOtroItinerario.Text = "Otro Itinerario";
            buttonOtroItinerario.UseVisualStyleBackColor = true;
            buttonOtroItinerario.Click += buttonOtroItinerario_Click;
            // 
            // buttonVolverALaBusqueda
            // 
            buttonVolverALaBusqueda.Location = new Point(173, 113);
            buttonVolverALaBusqueda.Margin = new Padding(3, 2, 3, 2);
            buttonVolverALaBusqueda.Name = "buttonVolverALaBusqueda";
            buttonVolverALaBusqueda.Size = new Size(131, 41);
            buttonVolverALaBusqueda.TabIndex = 3;
            buttonVolverALaBusqueda.Text = "Volver a la Busqueda";
            buttonVolverALaBusqueda.UseVisualStyleBackColor = true;
            buttonVolverALaBusqueda.Click += buttonVolverALaBusqueda_Click;
            // 
            // GuardarOpcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 194);
            Controls.Add(buttonVolverALaBusqueda);
            Controls.Add(buttonOtroItinerario);
            Controls.Add(buttonItinerarioActual);
            Controls.Add(buttonNuevoItinerario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GuardarOpcion";
            Text = "GuardarOpcion";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNuevoItinerario;
        private Button buttonItinerarioActual;
        private Button buttonOtroItinerario;
        private Button buttonVolverALaBusqueda;
    }
}