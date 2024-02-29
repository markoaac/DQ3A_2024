namespace Unidad_II_Formularios.practica_productos
{
    partial class frmActualizar
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
            txtStock = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtProducto = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            chkImagen = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 259);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(43, 171);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(219, 27);
            txtStock.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 147);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 11;
            label3.Text = "Stock del Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(43, 105);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(219, 27);
            txtPrecio.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 9;
            label2.Text = "Precio del Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(43, 43);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(219, 27);
            txtProducto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre del Producto";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkImagen
            // 
            chkImagen.AutoSize = true;
            chkImagen.Location = new Point(43, 214);
            chkImagen.Name = "chkImagen";
            chkImagen.Size = new Size(165, 24);
            chkImagen.TabIndex = 14;
            chkImagen.Text = "¿Actualizar imagen?";
            chkImagen.UseVisualStyleBackColor = true;
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 311);
            Controls.Add(chkImagen);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "frmActualizar";
            Text = "frmActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtProducto;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private CheckBox chkImagen;
    }
}