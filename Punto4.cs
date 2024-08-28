using System;
public class Punto4
{
    public static void Taller4()
    {
        Console.WriteLine("Digite un numero:");
        int numeroUsuario = int.Parse(Console.ReadLine());
        int contador =1;
        do
        {
            Console.WriteLine("Digite otro numero");
            numeroUsuario = int.Parse(Console.ReadLine());
            if (numeroUsuario >=0)
            {
                contador++;
            }
        }
        while (numeroUsuario>0);
        Console.WriteLine($"Digitaste {contador} numeros positivos");
    }
}
