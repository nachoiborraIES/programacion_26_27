/* Programa que calcula la autonomía de un coche pidiéndole al usuario
 * la capacidad del depósito hasta que dé un valor correcto
 * y los litros actuales. Calcula el porcentaje de combustible disponible
 * y saca un mensaje según los litros restantes en el depósito.*/

using System;

class Ejercicio
{
    static void Main()
    {
        int capacidad, litrosActuales;
        
        do 
        {
            Console.WriteLine("Dime la capacidad del depósito (30-100 L)");
            capacidad = Convert.ToInt32(Console.ReadLine());
            
            if (capacidad < 30 || capacidad > 100)
            {
                Console.WriteLine("Valor incorrecto. " +
                    "Debe estar entre 30 y 100.");
            }
        }
        
        while (capacidad < 30 || capacidad > 100);
        
        Console.WriteLine("Dime los litros actuales:");
        litrosActuales = Convert.ToInt32(Console.ReadLine());
        
        if (litrosActuales < 0 || litrosActuales > capacidad)
        {
            Console.WriteLine("Cantidad no válida");
        }
        else
        {
            int porcentaje;
            porcentaje = (litrosActuales * 100) / capacidad;
            
            if (porcentaje < 15)
            {
                Console.WriteLine("Atención: entrando en reserva");
            }
            
            if (litrosActuales > 30)
            {
                Console.WriteLine("Autonomía suficiente");
            }
            else if (litrosActuales <= 30 && litrosActuales >= 10)
            {
                Console.WriteLine("Autonomía media");
            }
            else
            {
                Console.WriteLine("Autonomía baja: " +
                    "Busca una gasolinera pronto");
            }
        }
    }
}


