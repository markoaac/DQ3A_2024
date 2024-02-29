using Unidad_II_Clases;
using Unidad_II_Controles;

namespace Unidad_II_Formularios
{
    public partial class Form1 : Form
    {
        string pathImage;
        const string archivo = "C:/Pruebas/mascotas.txt";
        public Form1()
        {
            InitializeComponent();
            this.pathImage = null;
            Leer();
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
            if (ofdBuscar.ShowDialog() == DialogResult.OK)
            {
                pathImage = ofdBuscar.FileName;
                MessageBox.Show("Imagen seleccionada");
            }
        }

        private void Escribir()
        {
            Escritura esc = new Escritura(archivo, false);

            foreach (Control uc in contenedor.Controls)
            {
                ucMascota temp = (ucMascota)uc;
                Mascota m = temp.mascota;
                esc.Escribir(m.ToString());
            }
            esc.Cerrar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Escribir();
        }

        private void Leer()
        {
            Lectura lec = new Lectura(archivo);
            string[] lineas = lec.leer();
            for(int i = 0; i < lineas.Length - 1; i++) {
                string[] info = lineas[i].Split(",");
                Mascota m = new Mascota();
                m.Nombre = info[0];
                m.Edad = int.Parse(info[1]);
                m.Foto = info[2];
                m.Especie = info[3];
                ucMascota ucm = new ucMascota();
                ucm.mascota = m;
                ucm.setInfoMascota();
                contenedor.Controls.Add(ucm);
            }
            lec.Cerrar();
        }
    }
}
