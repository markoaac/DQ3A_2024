namespace Unidad_I
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblFecha = new Label();
            progressBar1 = new ProgressBar();
            btnLectura = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            label2 = new Label();
            txtSexo = new TextBox();
            label3 = new Label();
            button1 = new Button();
            contenedor = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(12, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(96, 38);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 67);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(363, 29);
            progressBar1.TabIndex = 1;
            // 
            // btnLectura
            // 
            btnLectura.Location = new Point(12, 123);
            btnLectura.Name = "btnLectura";
            btnLectura.Size = new Size(156, 29);
            btnLectura.TabIndex = 2;
            btnLectura.Text = "Lectura de Archivo";
            btnLectura.UseVisualStyleBackColor = true;
            btnLectura.Click += btnLectura_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 66);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(447, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(447, 159);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(166, 27);
            txtEdad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 136);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "Edad";
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(447, 229);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(166, 27);
            txtSexo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 206);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Sexo";
            // 
            // button1
            // 
            button1.Location = new Point(483, 273);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contenedor
            // 
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(30, 190);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(372, 215);
            contenedor.TabIndex = 10;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contenedor);
            Controls.Add(button1);
            Controls.Add(txtSexo);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnLectura);
            Controls.Add(progressBar1);
            Controls.Add(lblFecha);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblFecha;
        private ProgressBar progressBar1;
        private Button btnLectura;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label label2;
        private TextBox txtSexo;
        private Label label3;
        private Button button1;
        private FlowLayoutPanel contenedor;
    }
}