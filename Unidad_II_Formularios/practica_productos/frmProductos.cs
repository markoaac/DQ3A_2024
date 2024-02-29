using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_II_Controles;
using Unidad_II_Clases;

namespace Unidad_II_Formularios.practica_productos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            Globales.carrito = new List<ucProducto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                #region definición de producto
                Producto productoForm = new Producto();
                productoForm.Nombre = txtProducto.Text;
                productoForm.Precio = decimal.Parse(txtPrecio.Text);
                productoForm.Stock = int.Parse(txtStock.Text);
                productoForm.Imagen = openFileDialog1.FileName;
                productoForm.CantidadVendida = 0;
                productoForm.Id = Guid.NewGuid();
                #endregion

                #region vincular con UserControl
                ucProducto ucp = new ucProducto();
                ucp.MiProducto = productoForm;
                ucp.eventActualizar_Click += Ucp_eventActualizar_Click;
                ucp.eventSeleccionar_Click += Ucp_eventSeleccionar_Click;
                ucp.ActualizarInterfaz();
                #endregion

                #region agregar user control a contenedor
                contenedor.Controls.Add(ucp);
                #endregion
            }
        }

        private void Ucp_eventSeleccionar_Click(object sender, EventArgs e)
        {
            ucProducto uc = (ucProducto)sender;
            frmSeleccionar f = new frmSeleccionar(uc);
            f.ShowDialog();

        }

        private void Ucp_eventActualizar_Click(object sender, EventArgs e)
        {
            ucProducto p = (ucProducto)sender;
            frmActualizar f = new frmActualizar(p);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCarrito f = new frmCarrito(contenedor.Controls);
            f.ShowDialog();
        }
    }
}
