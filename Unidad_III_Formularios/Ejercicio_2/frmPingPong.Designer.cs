namespace Unidad_III_Formularios.Ejercicio_2
{
    partial class frmPingPong
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
            pelota = new PictureBox();
            barra = new PictureBox();
            lblVidas = new Label();
            ((System.ComponentModel.ISupportInitialize)pelota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barra).BeginInit();
            SuspendLayout();
            // 
            // pelota
            // 
            pelota.BackColor = Color.Maroon;
            pelota.Location = new Point(59, 147);
            pelota.Name = "pelota";
            pelota.Size = new Size(39, 39);
            pelota.TabIndex = 0;
            pelota.TabStop = false;
            // 
            // barra
            // 
            barra.BackColor = Color.ForestGreen;
            barra.Location = new Point(383, 550);
            barra.Name = "barra";
            barra.Size = new Size(228, 43);
            barra.TabIndex = 1;
            barra.TabStop = false;
            // 
            // lblVidas
            // 
            lblVidas.BackColor = Color.Transparent;
            lblVidas.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidas.Location = new Point(12, 9);
            lblVidas.Name = "lblVidas";
            lblVidas.Size = new Size(901, 38);
            lblVidas.TabIndex = 2;
            lblVidas.Text = "---";
            lblVidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPingPong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 605);
            Controls.Add(pelota);
            Controls.Add(lblVidas);
            Controls.Add(barra);
            Name = "frmPingPong";
            Text = "frmPingPong";
            FormClosing += frmPingPong_FormClosing;
            KeyDown += frmPingPong_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pelota).EndInit();
            ((System.ComponentModel.ISupportInitialize)barra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pelota;
        private PictureBox barra;
        private Label lblVidas;
    }
}