namespace Unidad_II_Formularios.practica_productos
{
    partial class frmProductos
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
            label1 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            contenedor = new FlowLayoutPanel();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 32);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(219, 27);
            txtProducto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 94);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(219, 27);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio del Producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 159);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(219, 27);
            txtStock.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 4;
            label3.Text = "Stock del Producto";
            // 
            // button1
            // 
            button1.Location = new Point(71, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contenedor
            // 
            contenedor.AutoScroll = true;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(264, 12);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(524, 416);
            contenedor.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(56, 227);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 8;
            button2.Text = "Ver carrito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(contenedor);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "frmProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private FlowLayoutPanel contenedor;
        private Button button2;
    }
}