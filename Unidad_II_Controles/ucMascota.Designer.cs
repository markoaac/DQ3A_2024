namespace Unidad_II_Controles
{
    partial class ucMascota
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbMascota = new PictureBox();
            lblNombre = new Label();
            lblEspecie = new Label();
            lblEdad = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMascota).BeginInit();
            SuspendLayout();
            // 
            // pbMascota
            // 
            pbMascota.BorderStyle = BorderStyle.Fixed3D;
            pbMascota.Location = new Point(16, 13);
            pbMascota.Name = "pbMascota";
            pbMascota.Size = new Size(81, 102);
            pbMascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMascota.TabIndex = 0;
            pbMascota.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(103, 13);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(39, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "-----";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(103, 52);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(39, 20);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "-----";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(103, 95);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(39, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "-----";
            // 
            // ucMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEdad);
            Controls.Add(lblEspecie);
            Controls.Add(lblNombre);
            Controls.Add(pbMascota);
            Name = "ucMascota";
            Size = new Size(303, 137);
            ((System.ComponentModel.ISupportInitialize)pbMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMascota;
        private Label lblNombre;
        private Label lblEspecie;
        private Label lblEdad;
    }
}
