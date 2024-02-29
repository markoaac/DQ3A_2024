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

namespace Unidad_II_Controles
{
    public partial class ucProducto : UserControl
    {
        public Producto MiProducto { get; set; }

        public event EventHandler eventActualizar_Click;
        public event EventHandler eventSeleccionar_Click;

        public ucProducto()
        {
            InitializeComponent();
        }

        public void ActualizarInterfaz()
        {
            lblProducto.Text = MiProducto.Nombre;
            lblPrecio.Text = MiProducto.Precio.ToString();
            lblStock.Text = MiProducto.Stock.ToString();
            pbProducto.Image = Image.FromFile(MiProducto.Imagen);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (eventActualizar_Click != null)
                eventActualizar_Click(this, e);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(eventSeleccionar_Click != null)
            {
                eventSeleccionar_Click (this, e);
            }
        }
    }
}
