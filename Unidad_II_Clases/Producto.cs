using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_Clases
{
    //cambiar internal a public porque de lo contrario
    //no será válido en el control de usuario
    public class Producto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio  { get; set; }
        public int Stock { get; set; }
        public string? Imagen { get; set; }
        public int CantidadVendida { get; set; }

        public override string ToString()
        {
            return $"{Id},{Nombre},{Precio}," +
                $"{Stock},{Imagen},{CantidadVendida}";
        }


    }
}
