namespace Unidad_I
{
    partial class Form4
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
            button1 = new Button();
            contenedor = new FlowLayoutPanel();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(138, 57);
            button1.Name = "button1";
            button1.Size = new Size(166, 29);
            button1.TabIndex = 0;
            button1.Text = "Agregar Foco";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.Gainsboro;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(31, 101);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(612, 313);
            contenedor.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(341, 57);
            button2.Name = "button2";
            button2.Size = new Size(177, 29);
            button2.TabIndex = 2;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(button2);
            Controls.Add(contenedor);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel contenedor;
        private Button button2;
    }
}