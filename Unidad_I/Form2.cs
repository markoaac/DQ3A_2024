using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_I
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(75, 75);
            pb.Image = 
                Image.FromFile("C:\\Pruebas\\mouse.png");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            contenedor.Controls.Add(pb);
        }
    }
}
