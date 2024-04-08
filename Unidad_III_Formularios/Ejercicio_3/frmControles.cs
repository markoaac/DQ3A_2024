using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_III_Formularios.Ejercicio_3
{
    public partial class frmControles : Form
    {
        public frmControles()
        {
            InitializeComponent();
        }
        //Paso 1. Crear delegado
        private delegate void delegado_control(Control c, bool agregado);
        private delegate void delegado_mover_control(Control c, Point p);

        //Paso 2. Instanciar delegado
        private void metodo_manipular_control(Control c, bool agregado)
        {
            if (InvokeRequired)
            {
                delegado_control dc = new delegado_control
                    (metodo_manipular_control);
                object[] ps = new object[] { c, agregado };
                Invoke(dc, ps);
            }
            else
            {
                if (agregado)
                    Controls.Add(c);
                else
                    Controls.Remove(c);
            }
        }

        private void metodo_mover_control(Control c, Point p)
        {
            if (InvokeRequired)
            {
                delegado_mover_control dmc = new
                    delegado_mover_control
                    (metodo_mover_control);
                object[] ps = new object[] { c, p };
                Invoke(dmc, ps);
            }
            else
            {
                c.Location = p;
            }
        }

        private void crear_imagen()
        {
            PictureBox pb = GetPictureBox();
            metodo_manipular_control(pb, true);
            int tx = pb.Location.X;
            int y = pb.Location.Y;
            while (tx > 0)
            {
                metodo_mover_control(pb, new Point(tx, y));
                tx -= 30;
                Thread.Sleep(200);
            }
            metodo_manipular_control(pb, false);
        }

        private PictureBox GetPictureBox()
        {
            PictureBox pb = new PictureBox();
            Random r = new Random();
            pb.Size = new Size(r.Next(100, 150), r.Next(100, 150));
            int x = Width - pb.Width - 15;
            pb.Location = new
                Point(x, r.Next(0, Height - pb.Height - 15));
            pb.BackColor =
                Color.FromArgb(255, r.Next(1, 255),
                r.Next(1, 255), r.Next(1, 255));
            return pb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(crear_imagen);
            hilo.Start();
        }
    }
}
