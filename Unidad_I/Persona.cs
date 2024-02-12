using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_I
{
    public class Persona
    {
        //private string nombre;
        //public void setNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}
        //public string getNombre()
        //{
        //       return nombre; 
        //}
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Sexo { get; set; }

        public override string ToString()
        {
            return Nombre + "," + Edad + "," + Sexo;
        }
    }
}
