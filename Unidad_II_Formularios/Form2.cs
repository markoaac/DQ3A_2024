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
using Unidad_II_Controles;
namespace Unidad_II_Formularios
{
    public partial class Form2 : Form
    {
        const string archivo = "C:/Pruebas/pbe.txt";
        public Form2()
        {
            InitializeComponent();
            Leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgressBarEstatus pbe = new ProgressBarEstatus();
            pbe.Estatus = "Inicio";
            pbe.Progreso = 100;
            ucProgressBar ucp = new ucProgressBar();
            ucp.PBEstatus = pbe;
            ucp.ControlAgregado();
            contenedor.Controls.Add(ucp);
        }

        private void Escribir()
        {
            Escritura esc = new Escritura(archivo, false);
            foreach (Control c in contenedor.Controls)
            {
                ucProgressBar uc = (ucProgressBar)c;
                esc.Escribir(uc.PBEstatus.ToString());
            }
            esc.Cerrar();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Escribir();
        }

        private void Leer()
        {
            Lectura lex = new Lectura(archivo);
            string[] lineas = lex.leer();
            for(int i = 0; i < lineas.Length - 1; i++)
            {
                ProgressBarEstatus pbe = new ProgressBarEstatus();
                string[] info = lineas[i].Split(",");
                pbe.Progreso = int.Parse(info[0]);
                pbe.Estatus = info[1].Replace("\r", "");
                ucProgressBar uc = new ucProgressBar();
                uc.PBEstatus = pbe;
                uc.ControlLeido();
                contenedor.Controls.Add(uc);//agregar control a contenedor
            }
            lex.Cerrar();
        }
    }
}
