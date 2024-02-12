namespace Unidad_I
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnNombre = new Button();
            contenedor = new FlowLayoutPanel();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(131, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(23, 87);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(94, 29);
            btnNombre.TabIndex = 2;
            btnNombre.Text = "Presióname";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // contenedor
            // 
            contenedor.AutoScroll = true;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(283, 87);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(505, 351);
            contenedor.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(499, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(contenedor);
            Controls.Add(btnNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnNombre;
        private FlowLayoutPanel contenedor;
        private Button btnAgregar;
    }
}
