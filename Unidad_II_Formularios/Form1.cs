using Unidad_II_Clases;
using Unidad_II_Controles;

namespace Unidad_II_Formularios
{
    public partial class Form1 : Form
    {
        string pathImage;
        public Form1()
        {
            InitializeComponent();
            this.pathImage = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pathImage == null)
            {
                MessageBox.Show("No hay imagen");
            }
            else
            {
                Mascota m = new Mascota();
                m.Nombre = txtNombre.Text;
                m.Edad = int.Parse(txtEdad.Text);
                m.Especie = txtEspecie.Text;
                m.Foto = pathImage;
                ucMascota control = new ucMascota();
                control.mascota = m;
                control.setInfoMascota();
                contenedor.Controls.Add(control);
                pathImage = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ofdBuscar.ShowDialog() == DialogResult.OK)
            {
                pathImage = ofdBuscar.FileName;
                MessageBox.Show("Imagen seleccionada");
            }
        }
    }
}
