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
namespace Unidad_II_Controles
{
    public partial class ucProgressBar : UserControl
    {
        public ProgressBarEstatus PBEstatus { get; set; }

        public ucProgressBar()
        {
            InitializeComponent();
        }

        public void ControlAgregado()
        {
            btnPausar.Enabled = false;
            btnReiniciar.Enabled = false;
        }
        public void ControlLeido()
        {
            if(PBEstatus.Estatus == "Inicio")
            {
                ControlAgregado();
            }
            else
            {
                pbTiempo.Value = PBEstatus.Progreso;
                btnIniciar.Enabled = false;
                tmrProgreso.Enabled = true;
                tmrProgreso.Tick += TmrProgreso_Tick;
                if(PBEstatus.Estatus == "Pausar")
                {
                    btnPausar.Text = "Continuar";
                    tmrProgreso.Stop();
                }
                else
                {
                    btnPausar.Text = "Pausar";
                    tmrProgreso.Start();
                }
            }
            //else if(PBEstatus.Estatus == "Pausar")
            //{
            //    pbTiempo.Value = PBEstatus.Progreso;
            //    btnIniciar.Enabled = false;
            //    btnPausar.Text = "Continuar";
            //    tmrProgreso.Enabled = true;
            //    tmrProgreso.Stop();
            //    tmrProgreso.Tick += TmrProgreso_Tick;
            //}
            //else
            //{
            //    pbTiempo.Value = PBEstatus.Progreso;
            //    btnIniciar.Enabled = false;
            //    btnPausar.Text = "Pausar";
            //    tmrProgreso.Enabled = true;
            //    tmrProgreso.Start();
            //    tmrProgreso.Tick += TmrProgreso_Tick;
            //}
        }

           private void btnIniciar_Click(object sender, EventArgs e)
        {
            pbTiempo.Value = PBEstatus.Progreso;
            tmrProgreso.Enabled = true;
            tmrProgreso.Tick += TmrProgreso_Tick;
            btnIniciar.Enabled = false;
            btnPausar.Enabled = true;
            btnReiniciar.Enabled = true;
            PBEstatus.Estatus = "Continuar";
        }

        private void TmrProgreso_Tick(object sender, EventArgs e)
        {
            if(PBEstatus.Progreso == 0 || pbTiempo.Value == 0)
            {
                tmrProgreso.Stop();
            }
            else
            {
                PBEstatus.Progreso--;
                pbTiempo.Value = PBEstatus.Progreso;
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Pausar")
            {
                tmrProgreso.Stop();
                btnPausar.Text = "Continuar";
                PBEstatus.Estatus = "Pausar";
            }
            else
            {
                tmrProgreso.Start();
                btnPausar.Text = "Pausar";
                PBEstatus.Estatus = "Continuar";
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            PBEstatus.Progreso = 100;
            pbTiempo.Value = 100;
        }
    }
}
