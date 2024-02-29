using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_II_Clases;
using Unidad_II_Controles;
namespace Unidad_II_Formularios.practica_productos
{
    public partial class frmCarrito : Form
    {
        List<Producto> productos;
        Control.ControlCollection controles;
        public frmCarrito(Control.ControlCollection controles)
        {
            InitializeComponent();
            this.controles = controles;
            productos = new List<Producto>();
            foreach (ucProducto item in Globales.carrito)
            {
                productos.Add(item.MiProducto);
            }
            dataGridView1.DataSource = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                for(int j = 0; j < controles.Count; j++)
                {
                    ucProducto uc = (ucProducto)controles[j];
                    if (productos[i].Id == uc.MiProducto.Id)
                    {
                        uc.MiProducto.Stock -= productos[i].CantidadVendida;
                        uc.ActualizarInterfaz();
                        break;
                    }
                }
            }
            Globales.carrito.Clear();
            this.Close();
        }

      
    }
}
