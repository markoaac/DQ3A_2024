namespace Unidad_III_Formularios.Ejercicio_1
{
    partial class frmLista
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
            lstNumeros = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(39, 12);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(224, 204);
            lstNumeros.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(72, 222);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 1;
            button1.Text = "Agregar números";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._89277c77fcd4498c67989039bd3c0a9e_ilustracia_n_de_jinete;
            pictureBox1.Location = new Point(901, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._89277c77fcd4498c67989039bd3c0a9e_ilustracia_n_de_jinete;
            pictureBox2.Location = new Point(901, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // frmLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 487);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lstNumeros);
            Name = "frmLista";
            Text = "frmLista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstNumeros;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}