using System;
class Trabajo23082024
{
    static void Main()//Punto 5
    {
        int niveles = 5;

        for (int i = 1; i <= niveles; i++)
        {
            // Imprimir los espacios antes de los asteriscos
            for (int j = niveles; j > i; j--)
            {
                Console.Write(" ");
            }

            // Imprimir los asteriscos
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            // Mover a la siguiente línea después de imprimir una fila de asteriscos
            Console.WriteLine();
        }
    }
}