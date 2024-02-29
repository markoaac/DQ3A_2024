using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_Clases
{
    public class ProgressBarEstatus
    {
        public int Progreso { get; set; }
        public string? Estatus { get; set; }

        public override string ToString()
        {
            return $"{Progreso},{Estatus}";
        }
    }
}
