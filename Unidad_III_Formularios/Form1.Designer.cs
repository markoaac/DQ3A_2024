namespace Unidad_III_Formularios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            txtMensaje = new TextBox();
            progressBar1 = new ProgressBar();
            cuadro = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)cuadro).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 0;
            button1.Text = "Mostrar Saludo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 12);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 1;
            button2.Text = "Ejecutar Ciclo For";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(12, 60);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(170, 27);
            txtMensaje.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 146);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(761, 85);
            progressBar1.TabIndex = 3;
            // 
            // cuadro
            // 
            cuadro.BackColor = Color.Yellow;
            cuadro.Location = new Point(12, 256);
            cuadro.Name = "cuadro";
            cuadro.Size = new Size(129, 147);
            cuadro.TabIndex = 4;
            cuadro.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(35, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Mover";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(cuadro);
            Controls.Add(progressBar1);
            Controls.Add(txtMensaje);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cuadro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtMensaje;
        private ProgressBar progressBar1;
        private PictureBox cuadro;
        private Button button3;
    }
}
