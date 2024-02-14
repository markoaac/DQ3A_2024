namespace Unidad_II_Formularios
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ofdBuscar = new OpenFileDialog();
            contenedor = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(22, 156);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(180, 27);
            txtEspecie.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 114);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Especie";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(22, 245);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(180, 27);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 203);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // button1
            // 
            button1.Location = new Point(64, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(64, 327);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ofdBuscar
            // 
            ofdBuscar.FileName = "openFileDialog1";
            // 
            // contenedor
            // 
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(245, 27);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(709, 408);
            contenedor.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 528);
            Controls.Add(contenedor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtEspecie);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEspecie;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private Button button1;
        private Button button2;
        private OpenFileDialog ofdBuscar;
        private FlowLayoutPanel contenedor;
    }
}
