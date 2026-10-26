// Practica_1_1.cs
// Programa que simula el ordenador de a bordo de un coche
// para calcular el consumo de combustible y avisar sobre la autonomia.

using System;

class Practica_1_1
{
    static void Main()
    {
        int capacidad;
        int litrosActuales;
        int porcentaje;

        // Se usa do. while para no repetir codigo al pedir y comprobar
        // la capacidad del deposito debe estar entre 30 y 100 L
        do
        {
            Console.Write("Dime la capacidad del depósito (30-100L): ");
            capacidad = Convert.ToInt32(Console.ReadLine());

            if (capacidad < 30 || capacidad > 100)
            {
                Console.Write("Valor incorrecto. ");
                Console.WriteLine("Debe estar entre 30 y 100.");
            }
        }
        while (capacidad < 30 || capacidad > 100);

        // Se piden los litros actuales en el deposito
        Console.Write("Dime los litros actuales: ");
        litrosActuales = Convert.ToInt32(Console.ReadLine());

        // Comprobacion de los litros actuales respecto a la capacidad
        if (litrosActuales < 0 || litrosActuales > capacidad)
        {
            Console.WriteLine("Cantidad no válida");
        }
        else
        {
            // Calculo del porcentaje de combustible restante
            porcentaje = litrosActuales * 100 / capacidad;

            if (porcentaje < 15)
            {
                Console.WriteLine("Atención: Entrando en reserva");
            }

            // Clasificacion de la autonomia segun los litros actuales
            if (litrosActuales < 10)
            {
                Console.Write("Autonomía baja: ");
                Console.WriteLine("Busca una gasolinera pronto");
            }
            else if (litrosActuales <= 30)
            {
                Console.WriteLine("Autonomía media");
            }
            else
            {
                Console.WriteLine("Autonomía suficiente");
            }
        }
    }
}
