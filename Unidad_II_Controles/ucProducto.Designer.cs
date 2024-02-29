namespace Unidad_II_Controles
{
    partial class ucProducto
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
            pbProducto = new PictureBox();
            lblProducto = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            btnSeleccionar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // pbProducto
            // 
            pbProducto.BorderStyle = BorderStyle.Fixed3D;
            pbProducto.Location = new Point(3, 3);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(95, 105);
            pbProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProducto.TabIndex = 0;
            pbProducto.TabStop = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblProducto.Location = new Point(104, 3);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(55, 24);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "-----";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblPrecio.Location = new Point(104, 48);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(55, 24);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "-----";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblStock.Location = new Point(104, 88);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 24);
            lblStock.TabIndex = 3;
            lblStock.Text = "-----";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(4, 114);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(296, 29);
            btnSeleccionar.TabIndex = 4;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(3, 149);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(296, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ucProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnActualizar);
            Controls.Add(btnSeleccionar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Controls.Add(pbProducto);
            Name = "ucProducto";
            Size = new Size(305, 183);
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProducto;
        private Label lblProducto;
        private Label lblPrecio;
        private Label lblStock;
        private Button btnSeleccionar;
        private Button btnActualizar;
    }
}
