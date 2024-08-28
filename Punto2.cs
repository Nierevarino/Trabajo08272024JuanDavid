using System;
public class Punto2
{
    static void Taller2()
    {
        int i = 0;
        int suma=1;

        while (suma<=10)
        {
            i=i+suma;
            suma+=1;
        }
        Console.WriteLine("La suma de todos los numero es " + i);
    }
}