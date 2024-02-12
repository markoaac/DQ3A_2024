namespace Unidad_I
{
    public partial class Form1 : Form
    {
        int cont = 1;
        public Form1()
        {
            InitializeComponent();
            txtNombre.Text = "Ingrese su nombre";
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            string cadena = txtNombre.Text;
            MessageBox.Show(cadena);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "0";
            btn.Name = "btn" + cont;
            btn.Tag = 0;
            btn.Size = new Size(200, 100);
            btn.Click += btnAgregado_click;
            contenedor.Controls.Add(btn);
            cont++;
        }

        private void btnAgregado_click(object sender, EventArgs e)
        {
            
            Button miboton = (Button)sender;
            int clicks = (int)miboton.Tag;
            clicks++;
            miboton.Text = clicks.ToString();
            miboton.Tag = clicks;
            //Button btn = sender as Button;
            //int n1 = Convert.ToInt32(btn.Tag);
            //int n2 = int.Parse("5");
            //int n1 = (int)miboton.Tag;
            //int cuadrado = n1 * n1;
            //MessageBox.Show(cuadrado.ToString());
        }
    }
}
