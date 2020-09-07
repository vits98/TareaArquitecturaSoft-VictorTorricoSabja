using System;
using System.Collections.Generic;
using System.Text;

namespace CelularEjemploVictorTorricoSabja
{
    class Program1
    {
        static void Main(string[] args)
        {
            Celular samsung = new Celular();

            Console.WriteLine(samsung.MostrarEstadoBateria());
            samsung.Llamar();
            Console.WriteLine(samsung.MostrarEstadoBateria());

            Electronico electronico = new Celular();

            electronico.Sonar();

        }

    }
}
