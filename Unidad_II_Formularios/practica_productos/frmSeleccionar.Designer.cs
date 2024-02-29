namespace Unidad_II_Formularios.practica_productos
{
    partial class frmSeleccionar
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
            lblNombreProducto = new Label();
            lblStock = new Label();
            txtCantidad = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProducto.Location = new Point(12, 9);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(366, 43);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "label1";
            lblNombreProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(12, 88);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(366, 43);
            lblStock.TabIndex = 1;
            lblStock.Text = "label1";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(75, 161);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(235, 34);
            txtCantidad.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 217);
            button1.Name = "button1";
            button1.Size = new Size(235, 38);
            button1.TabIndex = 3;
            button1.Text = "Agregar a carrito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(75, 261);
            button2.Name = "button2";
            button2.Size = new Size(235, 36);
            button2.TabIndex = 4;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 328);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCantidad);
            Controls.Add(lblStock);
            Controls.Add(lblNombreProducto);
            Name = "frmSeleccionar";
            Text = "frmSeleccionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private Label lblStock;
        private TextBox txtCantidad;
        private Button button1;
        private Button button2;
    }
}