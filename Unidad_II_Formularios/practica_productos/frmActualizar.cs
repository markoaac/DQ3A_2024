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
namespace Unidad_II_Formularios.practica_productos
{
    public partial class frmActualizar : Form
    {
        ucProducto ucp;
        public frmActualizar(ucProducto ucp)
        {

            InitializeComponent();
            this.ucp = ucp;
            txtProducto.Text = ucp.MiProducto.Nombre;
            txtPrecio.Text = ucp.MiProducto
                                .Precio.ToString();
            txtStock.Text = ucp.MiProducto.Stock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucp.MiProducto.Precio =
                decimal.Parse(txtPrecio.Text);
            ucp.MiProducto.Stock =
                int.Parse(txtStock.Text);
            ucp.MiProducto.Nombre =
                txtProducto.Text;
            ucp.MiProducto.CantidadVendida = 0;
            if (chkImagen.Checked)
            {
                if(openFileDialog1.ShowDialog() == 
                    DialogResult.OK) {
                    ucp.MiProducto.Imagen =
                          openFileDialog1.FileName;
                    
                }
            }
            ucp.ActualizarInterfaz();
            this.Close();
        }
    }
}
