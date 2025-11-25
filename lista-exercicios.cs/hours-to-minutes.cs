using System;

class Program
{
    static void Main()
    {
        int minutos = 250;
        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;

        Console.WriteLine($"{minutos} minutos equivalem a {horas} horas e {minutosRestantes} minutos.");
    }
}
