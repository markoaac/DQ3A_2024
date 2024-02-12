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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongTimeString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
            else
                progressBar1.Value++;
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            try
            {
                StreamReader lectura =
                    new StreamReader("C:/Pruebas/dq3a.txt");
                string contenido = lectura.ReadToEnd();
                string[] lineas = contenido.Split("\n");
                //MessageBox.Show(lineas.Length.ToString());
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    Label lbl = new Label();
                    string[] datos = lineas[i].Split(",");
                    Persona p = new Persona();
                    p.Nombre = datos[0];
                    p.Edad = int.Parse(datos[1]);
                    p.Sexo = datos[2];
                    lbl.Text = datos[0];
                    lbl.Tag = p;
                    lbl.Click += lbl_click;
                    if (p.Sexo[0] == 'M')
                    {
                        lbl.BackColor = Color.Pink;
                    }
                    else
                    {
                        lbl.BackColor = Color.Blue;
                        lbl.ForeColor = Color.White;
                    }
                    contenedor.Controls.Add(lbl);
                }
                lectura.Close();
                MessageBox.Show(contenido);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter esc =
                    new StreamWriter
                    ("C:/Pruebas/dq3a.txt",true);
                Persona p = new Persona();
                p.Nombre = txtNombre.Text;
                p.Edad = int.Parse(txtEdad.Text);
                p.Sexo = txtSexo.Text;
                esc.WriteLine(p.ToString());
                esc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        private void lbl_click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Persona p = (Persona)lbl.Tag;

            //string info =
            //    "Nombre: " + p.Nombre +
            //    "\nEdad: " + p.Edad +
            //    "\nSexo: " + p.Sexo;
           

            string info = $"Nombre: {p.Nombre}\nEdad: {p.Edad}\nSexo: {p.Sexo}";

            MessageBox.Show(info);
        }
    }
}
