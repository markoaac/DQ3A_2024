using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_III_Formularios.Ejercicio_2
{
    public partial class frmPingPong : Form
    {
        Thread hiloMoverPelota;
        int vidas;
        int puntos;
        bool movimiento;
        int velocidad;
        public frmPingPong()
        {
            InitializeComponent();
            velocidad = 210;
            vidas = 3;
            puntos = 0;
            movimiento = true;
            lblVidas.Text = getDatos();
            hiloMoverPelota = new Thread(mover_pelota);
            hiloMoverPelota.Start();

        }

        private string getDatos()
        {
            return $"Vidas: {vidas}, Puntos: {puntos}";
        }

        //Paso 1. Declara delegado
        private delegate void delegado_mover(int x, int y);
        private delegate void delegado_vidas(string v);
        //Paso 2. Invocar delegado
        private void metodo_vidas(string v)
        {
            if (InvokeRequired)
            {
                delegado_vidas dv =
                    new delegado_vidas(metodo_vidas);
                object[] p = new object[] { v };
                Invoke(dv, p);
            }
            else
            {
                lblVidas.Text = v;
            }
        }

        private void metodo_mover(int x, int y)
        {
            if (InvokeRequired)
            {
                delegado_mover dm =
                    new delegado_mover(metodo_mover);
                object[] p = new object[] { x, y };
                Invoke(dm, p);
            }
            else
            {
                pelota.Location = new Point(x, y);
            }
        }

        //Paso 3. Método de mover
        private void mover_pelota()
        {
            bool izq = false;
            bool bajando = false;
            int x = pelota.Location.X;
            int y = pelota.Location.Y;
            Random rand = new Random();
            int rx = rand.Next(40, 50);
            int ry = rand.Next(40, 50);
            while (movimiento)
            {
                if (izq)
                {
                    x -= rx;
                }
                else
                {
                    x += rx;
                }
                if (bajando)
                {
                    y += ry;
                }
                else
                {
                    y -= ry;
                }
                metodo_mover(x, y);
                Thread.Sleep(velocidad);

                if (x + pelota.Width + rx > Width)
                {
                    izq = true;
                    rx = rand.Next(40, 50);
                }

                if (x < 0)
                {
                    izq = false;
                    rx = rand.Next(40, 50);
                }

                if(pelota.Bounds.IntersectsWith(
                    barra.Bounds))
                {
                    bajando = false;
                    ry = rand.Next(40, 50);
                    if(velocidad > 10)
                    {
                        velocidad -= 20;
                    }
                    puntos++;
                    metodo_vidas(getDatos());
                }

                if (y + pelota.Height + ry > Height)
                {
                    vidas--;
                    puntos--;
                    metodo_vidas(getDatos());
                    if(vidas == 0)
                    {
                        movimiento = false;
                        metodo_vidas("Game over");
                    }
                    bajando = false;
                    ry = rand.Next(40, 50);
                }


                if (y < 0)
                {
                    bajando = true;
                    ry = rand.Next(40, 50);
                }
            }
        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (barra.Location.X + barra.Width < Width)
                {
                    barra.Location = new Point(
                        barra.Location.X + 35,
                        barra.Location.Y
                        );
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                if (barra.Location.X > 0)
                {
                    barra.Location = new Point(
                        barra.Location.X - 35,
                        barra.Location.Y
                        );
                }
            }
        }

        private void frmPingPong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
