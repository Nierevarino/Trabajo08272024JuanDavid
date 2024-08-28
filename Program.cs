using System;
class Trabajo23082024
{
    static void Main()//Punto 5
    {
        int niveles = 5;

        for (int i = 1; i <= niveles; i++)
        {

            for (int j = niveles; j > i; j--)
            {
                Console.Write(" ");
            }

            // Imprimir los asteriscos
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"{Punto1.Taller1}");
        Console.WriteLine($"{Punto2.Taller2}");
        Console.WriteLine($"{Punto3.Taller3}");
        Console.WriteLine($"{Punto4.Taller4}");
    }
}