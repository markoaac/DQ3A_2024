using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_III_Formularios.Ejercicio_1
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        //Paso 1. Declarar delegado
        //NOTA: Declarar parámetros necesarios
        //según el proceso
        private delegate void delegado_agregar(int n);

        //Paso 2. Llamar delegado
        //Crear un método para instanciar delegado
        //NOTA: el siguiente método DEBE tener los mismos
        //parámetros que el delegado
        private void llamar_delegado_agregar(int n)
        {
            if (InvokeRequired)
            {
                //Paso 2.1 Instanciar delegado
                delegado_agregar d_agregar = new
                    delegado_agregar(llamar_delegado_agregar);
                //object[] p = new object[] { n };
                object[] p = new object[1];
                p[0] = n;
                Invoke(d_agregar, p);
            }
            else
            {
                lstNumeros.Items.Add(n);
            }
        }

        //Paso 3. Utiizar el método agregado anteriormente
        //con la el objetivo (llenar una lista de números)
        //NOTA: el objetivo depende del proceso a ejecutar
        //NOTA 2: El subproceso (hilo) no accede al método
        //anterior si no al que se desarrollará
        private void llenarLista()
        {
            for (int i = 1; i <= 10; i++)
            {
                Random rnd = new Random();
                llamar_delegado_agregar(rnd.Next(1, 1000));
                Thread.Sleep(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloLista = new Thread(llenarLista);
            hiloLista.Start();
        }
    }
}
