//Paso 1. Declarar librería de hilo
using System.Threading;
//NOTA: hilo en C# lo conocemos
//como Thread

//Paso 2. Definir el proceso que tendrá
//el hilo

Thread hilo = new Thread(ImprimirY);
hilo.Start();
ImprimirX();
//Paso 3. Declarar el hilo
//Paso 3.1 Comentar el método a utilizar
//Paso 3.2 Agregar el método como parámetro
// en el constructor de Thread
//NOTA: no se colocan paréntesis
//Paso 4. Iniciar hilo
//ImprimirY();//<- Aquí se tendrá que colocar el hilo


void ImprimirX()
{
    for(int i = 1; i < 100; i++)
    {
        Console.Write("X");
    }
}
void ImprimirY()
{
    for (int i = 1; i < 100; i++)
    {
        Console.Write("Y");
    }
}