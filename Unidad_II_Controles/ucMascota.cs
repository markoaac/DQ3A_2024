using Unidad_II_Clases;
namespace Unidad_II_Controles
{
    public partial class ucMascota : UserControl
    {
        public Mascota mascota { get; set; }

        public ucMascota()
        {
            InitializeComponent();
        }

        public void setInfoMascota()
        {
            lblNombre.Text = mascota.Nombre;
            lblEdad.Text = mascota.Edad.ToString();
            lblEspecie.Text = mascota.Especie;
            pbMascota.Image = Image.FromFile(mascota.Foto);
        }
    }
}
