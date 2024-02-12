using Unidad_II_Clases;

Lectura l = new Lectura("C:/Pruebas/dq3a.txt");

string[] lineas = l.leer();
for (int i = 0; i < lineas.Length - 1; i++)
{
    string[] cont = lineas[i].Split(",");
    //string aux = cont[2];
    if (cont[2][0] == 'H')
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
        Console.WriteLine(cont[0]);

}

l.Cerrar();
//Console.BackgroundColor = ConsoleColor.Green;
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("Hola, soy un mensaje modificado");

