using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unidad_I
{
    public partial class Form4 : Form
    {
        string fp, fa, fr, archivo;
        public Form4()
        {
            InitializeComponent();
            fp = "C:/Pruebas/encendido.png";
            fa = "C:/Pruebas/apagado.png";
            fr = "C:/Pruebas/roto.png";
            archivo = "C:/Pruebas/focos.txt";
            Lectura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.Image = Image.FromFile(fa);
            pb.SizeMode =
                PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Tag = 0;
            pb.Click += Pb_Click;
            contenedor.Controls.Add(pb);
        }

        private void Pb_Click(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int cont = Convert.ToInt32(pb.Tag);
            if(cont < 10)
            {
                cont++;
                if (cont % 2 == 0)
                {
                    pb.Image = Image.FromFile(fa);
                }
                else
                {
                    pb.Image = Image.FromFile(fp);
                }
            }
            else
            {
                pb.Image = Image.FromFile(fr);
            }
            
            pb.Tag = cont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter esc = new StreamWriter(archivo);
                foreach (Control item in contenedor.Controls)
                {
                    PictureBox pb = (PictureBox)item;
                    esc.WriteLine(pb.Tag.ToString());
                }
                esc.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            
        }
        private void Lectura()
        {
            try
            {
                StreamReader lec =
                    new StreamReader(archivo);
                string[] imagenes = lec.ReadToEnd().Split("\n");
                for(int i = 0; i < imagenes.Length - 1; i++) { 
                    int clicks = int.Parse(imagenes[i]);
                    PictureBox pb = new PictureBox();
                    if(clicks >= 10) {
                        pb.Image = Image.FromFile(fr);
                    }
                    else
                    {
                        if(clicks % 2 == 0)
                        {
                            pb.Image = Image.FromFile(fa);
                        }
                        else
                        {
                            pb.Image = Image.FromFile(fp);
                        }
                    }
                    
                    pb.SizeMode =
                        PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(100, 100);
                    pb.Tag = clicks;
                    pb.Click += Pb_Click;
                    contenedor.Controls.Add(pb);
                    lec.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
