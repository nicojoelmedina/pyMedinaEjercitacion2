namespace pyMedinaEjercitacion2
{
    partial class frmIncidentes
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
            lblCritico = new Label();
            lblAlto = new Label();
            lblMedio = new Label();
            lblBajo = new Label();
            lblResultadoBajo = new Label();
            lblResultadoMedio = new Label();
            lblResultadoAlto = new Label();
            lblResultadoCritico = new Label();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(79, 82);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(45, 15);
            lblCritico.TabIndex = 0;
            lblCritico.Text = "Critico ";
            lblCritico.Click += lblCritico_Click;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(79, 127);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(29, 15);
            lblAlto.TabIndex = 2;
            lblAlto.Text = "Alto";
            lblAlto.Click += lblAlto_Click;
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(79, 171);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(41, 15);
            lblMedio.TabIndex = 3;
            lblMedio.Text = "Medio";
            lblMedio.Click += lblMedio_Click;
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Location = new Point(79, 210);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(30, 15);
            lblBajo.TabIndex = 4;
            lblBajo.Text = "Bajo";
            lblBajo.Click += lblBajo_Click;
            // 
            // lblResultadoBajo
            // 
            lblResultadoBajo.AutoSize = true;
            lblResultadoBajo.Location = new Point(168, 210);
            lblResultadoBajo.Name = "lblResultadoBajo";
            lblResultadoBajo.Size = new Size(12, 15);
            lblResultadoBajo.TabIndex = 8;
            lblResultadoBajo.Text = "-";
            // 
            // lblResultadoMedio
            // 
            lblResultadoMedio.AutoSize = true;
            lblResultadoMedio.Location = new Point(168, 171);
            lblResultadoMedio.Name = "lblResultadoMedio";
            lblResultadoMedio.Size = new Size(12, 15);
            lblResultadoMedio.TabIndex = 7;
            lblResultadoMedio.Text = "-";
            // 
            // lblResultadoAlto
            // 
            lblResultadoAlto.AutoSize = true;
            lblResultadoAlto.Location = new Point(168, 127);
            lblResultadoAlto.Name = "lblResultadoAlto";
            lblResultadoAlto.Size = new Size(12, 15);
            lblResultadoAlto.TabIndex = 6;
            lblResultadoAlto.Text = "-";
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(168, 82);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 5;
            lblResultadoCritico.Text = "-";
            // 
            // frmIncidentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(lblResultadoBajo);
            Controls.Add(lblResultadoMedio);
            Controls.Add(lblResultadoAlto);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBajo);
            Controls.Add(lblMedio);
            Controls.Add(lblAlto);
            Controls.Add(lblCritico);
            Name = "frmIncidentes";
            Text = "SOC - - Incidentes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCritico;
        private Label lblAlto;
        private Label lblMedio;
        private Label lblBajo;
        private Label lblResultadoBajo;
        private Label lblResultadoMedio;
        private Label lblResultadoAlto;
        private Label lblResultadoCritico;
    }
}