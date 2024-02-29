namespace Unidad_II_Controles
{
    partial class ucProgressBar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbTiempo = new ProgressBar();
            btnIniciar = new Button();
            btnPausar = new Button();
            btnReiniciar = new Button();
            tmrProgreso = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pbTiempo
            // 
            pbTiempo.Location = new Point(3, 3);
            pbTiempo.Name = "pbTiempo";
            pbTiempo.Size = new Size(267, 29);
            pbTiempo.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(3, 38);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(72, 29);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(81, 38);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(98, 29);
            btnPausar.TabIndex = 2;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(185, 38);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(85, 29);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // tmrProgreso
            // 
            tmrProgreso.Interval = 1000;
            // 
            // ucProgressBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReiniciar);
            Controls.Add(btnPausar);
            Controls.Add(btnIniciar);
            Controls.Add(pbTiempo);
            Name = "ucProgressBar";
            Size = new Size(275, 79);
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar pbTiempo;
        private Button btnIniciar;
        private Button btnPausar;
        private Button btnReiniciar;
        private System.Windows.Forms.Timer tmrProgreso;
    }
}
