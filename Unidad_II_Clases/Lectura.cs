using System.IO;
namespace Unidad_II_Clases
{
    public class Lectura
    {
        StreamReader lectura;
        public Lectura(string ruta)
        {
            try
            {
                lectura = new StreamReader(ruta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] leer()
        {
            //string contenido;
            string[] lineas;
            try
            {
                //contenido = lectura.ReadToEnd();
                string contenido = lectura.ReadToEnd();
                lineas = contenido.Split("\n");
            }
            catch (Exception)
            {
                //contenido = null;
                lineas = null;
            }
            //return contenido;
            return lineas;
        }

        public void Cerrar()
        {
            if(lectura != null)
            {
                lectura.Close();
            }
        }
    }
}
