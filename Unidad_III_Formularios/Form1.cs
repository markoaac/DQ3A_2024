namespace Unidad_III_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread hiloPB = new Thread(ActualizarPB);
            hiloPB.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola :D");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloCicloFor = new Thread(CicloFor);
            hiloCicloFor.Start();
        }

        private void CicloFor()
        {
            for (long i = 0; i < 3000000000; i++)
            {

            }
            //MessageBox.Show("Fin");
            txtMensaje.Text = "fin";
        }

        private void ActualizarPB()
        {
            int i = 1;
            while (i < progressBar1.Maximum + 1)
            {
                progressBar1.Value = i;
                i++;
                Thread.Sleep(100);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread hiloCuadro = new Thread(MoverCuadro);
            hiloCuadro.Start();
        }

        private void MoverCuadro()
        {
            int x = cuadro.Location.X;
            int y = cuadro.Location.Y;
            int m = x + 200;
            while(x < m)
            {
                cuadro.Location = new Point(x, y);
                x += 10;
                Thread.Sleep(100);
            }
        }
    }
}
