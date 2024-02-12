using System.IO;
namespace Unidad_II_Clases
{
    public class Escritura
    {
        StreamWriter escritura;
        public Escritura(string ruta, bool append)
        {
            try
            {
                escritura = new StreamWriter(ruta, append);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Escribir(string texto)
        {
            escritura.WriteLine(texto);
        }
        public void Cerrar()
        {
            if(escritura != null)
            {
                escritura.Close();
            }
        }
    }
}
